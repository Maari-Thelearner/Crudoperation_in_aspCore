using System;
using System.ComponentModel.DataAnnotations;

namespace Kadavule.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Required")]
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
