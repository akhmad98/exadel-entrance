using Microsoft.EntityFrameworkCore;
using BookManagement.DAL.Data;
using BookManagement.DAL.Maps;

namespace BookManagement.BLL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UsersMap(modelBuilder.Entity<Users>);
            new BooksMap(modelBuilder.Entity<Books>);
        }
    }
}
