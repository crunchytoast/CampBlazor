﻿using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorCrud.Shared.Models
{
    public class Camp
    {
        public int CampId { get; set; }
        [Required]
        public string CampName { get; set; }
        [Required]
        public DateTimeOffset StartDate { get; set; }
        [Required]
        public DateTimeOffset EndDate { get; set; }
        public int DIYs { get; set; }
    }
}
