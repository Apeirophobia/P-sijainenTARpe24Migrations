using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
           : base(options) { }
            public DbSet<Employee> Employee {get; set;}
            public DbSet<Absense> Absense {get; set;}
            public DbSet<Child> Child {get; set;}
            public DbSet<ChildGroupHistory> ChildGroupHistory {get; set;}
            public DbSet<Group> Group {get; set;}
            public DbSet<JobTitle> JobTitle {get; set;}
            public DbSet<Menu> Menu {get; set;}
            public DbSet<Queue> Queue {get; set;}
        

    }
   
}
