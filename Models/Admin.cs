using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Admin
    {
        [Key]
        public int a_id { get; set; }
        public int a_tc { get; set; }
        public int sifre { get; set; }
        public string isim { get; set; }
        public string a_soyisim { get; set; }
    }
}
