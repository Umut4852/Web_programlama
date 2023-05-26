using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Depremzede
    {
        [Key]
        public int id { get; set; }
        public int tc_no { get; set; }
        public string? isim { get; set; }
        public string? soyisim { get; set; }
        public string? cinsiyet { get; set; }
        public string? adres { get; set; }
        public int aile_no { get; set; }
        public int istek_no { get; set; }
        public int sifre { get; set; }
    }
}
