using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class Education
    {
        //Validations Added And Tested
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string EducationName { get; set; }
        [Required]
        [StringLength(3)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(4)]
        public string ClassName { get; set; }
    }
}
