using System.ComponentModel.DataAnnotations;


namespace Web_programlama.Models
{
    public class Kullanici
    {

        [Key]
        public int k_id { get; set; } 
        public string? isim { get; set; }
        public int? k_tc { get; set; }
        public string? k_yetki_turu { get; set; }
        public int sifre { get; set; }
    }
}
