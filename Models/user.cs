using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Parola gereklidir.")]
        public string Password { get; set; } = string.Empty;
    }
}
