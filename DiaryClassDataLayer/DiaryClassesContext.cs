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
        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<RatingModel> Ratings { get; set; }
        public DbSet<InformationModel> Info { get; set; }

        public DiaryContext(DbContextOptions<DiaryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SubjectModel subject = new SubjectModel { Id = 1, SubjectName = "Математика" };
            SubjectModel subject1 = new SubjectModel { Id = 2, SubjectName = "Русский язык" };
            modelBuilder.Entity<SubjectModel>().HasData(new SubjectModel[] { subject, subject1 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
