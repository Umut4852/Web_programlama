using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class Haberler
    {
        [Key]
        public int h_id { get; set; }
        public string son_haberler { get; set; }
        public string gida_dagitim_noktalari { get; set; }
        public string saglik_merkezleri { get; set; }

    }
}
