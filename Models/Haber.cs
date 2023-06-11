using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Haber
    {
        [Key]
        public int Id { get; set; }
        public string? Baslik { get; set; }
        public string? Icerik { get; set; }
        public DateTime Tarih { get; set; }
    }

}
