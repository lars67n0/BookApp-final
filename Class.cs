using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class Class
    {
        //Validations Added and tested
        public int Id { get; set; }
        [Required]
        [StringLength(4, ErrorMessage ="Cant Be Above 4 Characters")]
        public string ClassName { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "Cant Be Above 3 Characters")]
        public string TeacherName { get; set; }
        [Required]
        [StringLength(1, ErrorMessage = "Cant Be Above 1 Characters")]
        public string SemesterYear { get; set; }
    }
}
