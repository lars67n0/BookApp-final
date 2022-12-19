using Microsoft.EntityFrameworkCore;
namespace BookApp.Data
{
    public class BookListAppDbContext : DbContext
    {
        

        public BookListAppDbContext(DbContextOptions<BookListAppDbContext> options)
         : base(options)
        {
           
        }


      
        // Books
        public DbSet<Book> Books { get; set; }
        // Koordinators
        public DbSet<Koordinator> Koordinators { get; set; }
        // Teachers
        public DbSet<Teacher> Teachers { get; set; }
        // Courses
        public DbSet<Course> Courses { get; set; }
        // Classes
        public DbSet<Class> Classes { get; set; }

        // Educations
        public DbSet<Education> Educations { get; set; }

       



    }
}
