using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using LayeredArchtitecture.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchtitecture.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true;");

        }

       // public DbSet<> Type { get; set; }
       public DbSet<OperationClaim> OperationClaims { get; set; }
       public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
       public DbSet<User> Users { get; set; }

    }
}
