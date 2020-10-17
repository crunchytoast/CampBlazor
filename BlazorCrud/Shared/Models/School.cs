using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BlazorCrud.Shared.Models
{
    public class School
    {
        public int SchoolId { get; }
        [Required]
        public string SchoolName { get; }
        [Required]
        public List<Class> Classes { get; set; }
    }
}