using Microsoft.EntityFrameworkCore;
using PWABlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PWABlazor.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
