﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ContactManagerT1.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
        : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*            ***This will be the method for generating Friend Category***
 *            modelBuilder.Entity<Category>().HasData();
 *            
*/            
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-1234",
                    Email = "johndoe@example.com",
                    Organization = "Acme Corp"
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Phone = "555-5678",
                    Email = "janesmith@example.com",
                    Organization = "Tech Solutions"
                },
                new Contact
                {
                    ContactId = 3,
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
