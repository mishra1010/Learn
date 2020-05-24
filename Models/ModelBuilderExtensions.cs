using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
              new Employee
              {
                  Id = 1,
                  Name = "Danny",
                  Department = Dept.IT,
                  Email = "x@y.com"
              },
              new Employee
              {
                  Id = 2,
                  Name = "Ted",
                  Department = Dept.HR,
                  Email = "T@I.com"
              }
            );
        }
    }
}
