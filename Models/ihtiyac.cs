﻿using System.ComponentModel.DataAnnotations;

namespace Web_programlama.Models
{
    public class İhtiyac
    {
        [Key]
        public int i_id { get; set; }
        public string? i_adi { get; set; }
        public int i_miktari { get; set; }
        public string? istek_adresi { get; set; }
        public string? ozel_istek { get; set; }
    }
}
