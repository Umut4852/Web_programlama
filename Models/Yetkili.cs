using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Yetkili
    {
        [Key]

        public int y_id { get; set; }
        public int y_tc { get; set; }
        public string? isim { get; set; }
        public string? y_soyadi { get; set; }
        public string? y_d_tarihi { get; set; }
        public string? y_mail { get; set; }
        public int sifre { get; set; }
    }
}
