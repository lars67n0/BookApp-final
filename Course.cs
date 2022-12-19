using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class Course
    {
        //Validations Added and Tested
        public int Id { get; set; }
        [Required]
        [StringLength(3, ErrorMessage ="Need 3 Characters")]
        public string CourseName { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "Need 3 Characters")]
        public string TeacherName { get; set; }
    }
}
