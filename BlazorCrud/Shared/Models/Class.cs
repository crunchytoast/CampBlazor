using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorCrud.Shared.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        [Required]
        public DateTimeOffset ClassDate { get; set; }
        [Required]
        public DateTimeOffset ClassStartTime { get; set; }
        [Required]
        public DateTimeOffset ClassEndTime { get; set; }
        [Required]
        public string ClassSchool { get; set; }
        public string ClassStudent { get; set; }


    }
}

