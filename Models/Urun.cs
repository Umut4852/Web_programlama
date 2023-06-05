using System.ComponentModel.DataAnnotations;
namespace Web_programlama.Models
{
    public class Urun
    {
        [Key]
        public string isim { get; set; }
        public int adet { get; set; }
    }
}
