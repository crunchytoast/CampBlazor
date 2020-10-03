using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Colour { get; set; }
        [Required]
        public string School { get; set; }
    }
}
