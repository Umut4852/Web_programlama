using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class ToplanmaAlani
    {
        [Key]
        public int a_id { get; set; }
        public int a_kodu { get; set; }
        public string a_adres { get; set; }
        public string a_niteligi { get; set; }
        public int a_tcsi { get; set; }

    }
}
