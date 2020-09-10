﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SampleStore.Models
{
    public class Service
    {
        [key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Service Name")]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Display(Name = "Description")]
        public string LongDesc { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string ImageUlr { get; set; }
        [Required]
        public int CateggoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int FrequencyId{ get; set; }
        [ForeignKey("FrequencyId")]
        public Frequency Frequency { get; set; }
    }
}