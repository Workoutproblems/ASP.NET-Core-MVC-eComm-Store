using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SampleStore.Models
{

    public class Frequency
    {
        [key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Frequency Count")]
        public int FrequencyCount { get; set; }
        [Required]
        [Display(Name = "Frequency Name")]
        public string Name { get; set; }

    }
}
