using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Urun
    {
        [Key]
        public string isim { get; set; } = string.Empty;
        public int adet { get; set; }
    }
}
