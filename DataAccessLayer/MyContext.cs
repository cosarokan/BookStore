using EntityLayer.Entities;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {

        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
    }
}
