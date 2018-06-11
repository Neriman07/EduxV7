using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduxV7.Repo
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<EduxV7.Data.Product> Products { get; set; }// db seti ekledik
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}