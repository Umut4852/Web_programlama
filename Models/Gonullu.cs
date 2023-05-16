using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Gonullu
    {
        [Key]
        public int g_id { get; set; }
        public int g_tc { get; set; }
        public string g_isim { get; set; }
        public string g_soyisim { get; set; }
        public string g_meslegi { get; set; }
        public string yasi { get; set; }
        public string y_mail { get; set; }
        public int telefon { get; set; }
        public string y_sifre { get; set; }
    }
}
