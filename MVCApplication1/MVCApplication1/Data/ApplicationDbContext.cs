using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCApplication1.Models;

namespace MVCApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCApplication1.Models.Song> Songs { get; set; }
        public DbSet<MVCApplication1.Models.Music> Music { get; set; }
        public DbSet<MVCApplication1.Models.Customers> Customers { get; set; }
    }
}
