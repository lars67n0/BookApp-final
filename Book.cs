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
        public int PublishYear { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }

        // Foreign Key
        [Required]
        public int ClassId { get; set; }
        // Navigation Property
        public virtual Class Class { get; set; }
    }
}
