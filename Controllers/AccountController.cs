using Microsoft.AspNetCore.Mvc;
using Web_programlama.Models;
using System.Data.SqlClient;

namespace Web_programlama.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;

        private DataContext context;
        public AccountController(DataContext _context)
        {
            context = _context;
        }

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool isAuthenticated = ValidateUser(user.Username, user.Password);

                if (isAuthenticated)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Geçersiz kullanıcı adı veya parola.");
                }
            }

            return View(user);
        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

