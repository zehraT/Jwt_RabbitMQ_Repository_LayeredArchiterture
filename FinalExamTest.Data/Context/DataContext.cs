using FinalExamTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamTest.Data.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
