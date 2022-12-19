using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class Book
    {
        //Validations Added and tested
        public int Id { get; set; }
        [Required]
        [Range(0,4, ErrorMessage ="Cant Use A number over x-x-x-x")]
        public int PublishYear { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
