using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Colour { get; set; }
        public List<Class> Classes { get; set; }
    }
}
