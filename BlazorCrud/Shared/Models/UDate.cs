using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorCrud.Shared.Models
{
    public class UDate
    {
        public int UDateID { get; set; }
        [Required]
        public int TeacherID { get; set; }
        [Required]
        public DateTimeOffset Date { get; set; }
     

    }
}
