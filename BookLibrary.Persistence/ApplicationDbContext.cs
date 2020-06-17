using BookLibrary.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Persistence
{
    public class ApplicationDbContext : IdentityDbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }
            public DbSet<BookManagement> BookManagement { get; set; }
             public DbSet<BookBorrowers> BookBorrowers { get; set; }

             public DbSet<Catalogue> Catalogue { get; set; }
    
        }
    }

