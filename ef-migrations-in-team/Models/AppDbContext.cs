using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ef_migrations_in_team.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
