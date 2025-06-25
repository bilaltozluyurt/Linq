using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linqpractices.Entities;
using Microsoft.EntityFrameworkCore;


namespace linqpractices.DbOperations
{
    internal class LinqDbContext : DbContext
    {
       public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
        }
    }
}
