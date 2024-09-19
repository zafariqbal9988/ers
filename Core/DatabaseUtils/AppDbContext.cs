using System;
using System.Collections.Generic;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.DatabaseUtils
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Addclass> Addclasss { get; set; }

        public virtual DbSet<Specialist> Specialists { get; set; }

        public virtual DbSet<TestType> TestTypes { get; set; }

        public virtual DbSet<City> Citys { get; set; }

        public virtual DbSet<Nationality> Nationality { get; set; }

        public virtual DbSet<CaseForms> CaseForms { get; set; }

        public virtual DbSet<MonitoringList> MonitoringLists { get; set; }

        public virtual DbSet<Documents> Documents { get; set; }

        public virtual DbSet<TestReport> TestReports { get; set; }

    }
}



