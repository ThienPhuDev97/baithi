using BaiThi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiThi2.DataConnect
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EmployeeEntity")
        {

        }
        public DbSet<Employee> Categories { get; set; }
    }
}