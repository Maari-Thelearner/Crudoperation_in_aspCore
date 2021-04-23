using System;
using Microsoft.EntityFrameworkCore;
using Kadavule.Models;

namespace Kadavule.data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> tb1_Student { get; set; }

    }
}
