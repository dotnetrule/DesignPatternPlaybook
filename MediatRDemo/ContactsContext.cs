using Microsoft.EntityFrameworkCore;

namespace MediatRDemo
{
    public class ContactsContext : DbContext
    {

        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Steve", LastName = "1" },
                new Contact { Id = 2, FirstName = "Jack", LastName = "1" },
                new Contact { Id = 3, FirstName = "Kim", LastName = "1" });
        }
    }


}