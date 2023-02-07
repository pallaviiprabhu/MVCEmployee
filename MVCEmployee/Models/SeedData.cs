using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCEmployee.Data;
using System;
using System.Linq;

namespace MVCEmployee.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MVCEmployeeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MVCEmployeeContext>>()))
        {
            // Look for any movies.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }
            context.Employee.AddRange(
                new Employee
                {
                    Name = "Emma",
                    Email = "emma@gmail.com",
                    EmployeeId = 1015345,
                    ContactNo = 4567389,
                    Age = 21,
                    Department = "IFS",
                    JoinDate= DateTime.Parse("2023-1-16"),
                    Salary= 35000
                },
                new Employee
                {
                    Name = "Amy",
                    Email = "amy@gmail.com",
                    EmployeeId = 1015337,
                    ContactNo = 45674569,
                    Age = 22,
                    Department = "Advisory",
                    JoinDate = DateTime.Parse("2023-1-16"),
                    Salary = 40000
                },
                new Employee
                {
                    Name = "Jane",
                    Email = "jane@gmail.com",
                    EmployeeId = 1025337,
                    ContactNo = 41224569,
                    Age = 23,
                    Department = "Tax",
                    JoinDate = DateTime.Parse("2023-1-21"),
                    Salary = 40000
                },
                new Employee
                {
                    Name = "April",
                    Email = "april@gmail.com",
                    EmployeeId = 1067337,
                    ContactNo = 82224569,
                    Age = 21,
                    Department = "Audit",
                    JoinDate = DateTime.Parse("2023-1-27"),
                    Salary = 35000
                }
            );
            context.SaveChanges();
        }
    }
}