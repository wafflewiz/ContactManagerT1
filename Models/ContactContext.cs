using Microsoft.EntityFrameworkCore;

namespace ContactManagerT1.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
        : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friends" },
                new Category { CategoryId = 2, Name = "Family" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Acquaintances" },
                new Category { CategoryId = 5, Name = "Clients" }
                );
 

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    CategoryId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-1234",
                    Email = "johndoe@example.com",
                    Organization = "Acme Corp",

                },
                new Contact
                {
                    Id = 2,
                    CategoryId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Phone = "555-5678",
                    Email = "janesmith@example.com",
                    Organization = "Tech Solutions"
                },
                new Contact
                {
                    Id = 3,
                    CategoryId = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    Phone = "555-8765",
                    Email = "mjohnson@example.com",
                    Organization = "Innovate Inc"
                }

            );
        }
    }
}
