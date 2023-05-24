using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Gonullu
    {
        [Key]
        public int g_id { get; set; }
        public int g_tc { get; set; }
        public string? isim { get; set; }
        public string? soyisim { get; set; }
        public string? meslegi { get; set; }
        public string? yasi { get; set; }
        public string? mail { get; set; }
        public int telefon { get; set; }
        public string? sifre { get; set; }
    }
}
