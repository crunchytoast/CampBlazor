using System.ComponentModel.DataAnnotations;
using System;
using BlazorCrud.Shared.Models;

namespace BlazorCrud.Shared.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset ClassDate { get; set; }
        [Required]
        public DateTimeOffset ClassStartTime { get; set; }
        [Required]
        public DateTimeOffset ClassEndTime { get; set; }
        [Required]
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CampId { get; set; }
        public Camp Camp { get; set; }
        
    }
}

