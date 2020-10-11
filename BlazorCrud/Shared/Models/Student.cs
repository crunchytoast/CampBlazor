using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorCrud.Shared.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
       
    }
}

