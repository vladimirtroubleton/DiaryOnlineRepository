using DiaryClassDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiaryClassDataLayer
{
    public class DiaryContext : DbContext
    {
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<ClassesNavigationModel> ClassesNavigation { get; set; }

        public DiaryContext(DbContextOptions<DiaryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
