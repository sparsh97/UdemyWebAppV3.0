using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UdemyWeb.Models;

namespace UdemyWeb.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(" Server = (localdb)\\mssqllocaldb; Database =Data1; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 1, CategoryName = "WebDevlopment"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 2, CategoryName = "Bussiness"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 3, CategoryName = "Game Design"});

            //seed pies

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                CourseName = "Learn HTML5 Programming From Scratch",
                Price = 15.95M,
                CourseDescription = "A Complete HTML5 Programming Course for Beginners",
                CategoryId = 1,
                ImageUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
                ImageThumbnailUrl = "https://www.redbridgenet.com/wp-content/uploads/html5.png",
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 2,
                CourseName = "CSS - The Complete Guide 2020 (incl. Flexbox, Grid & Sass)",
                Price = 19.95M,
                CourseDescription = "Learn CSS for the first time or brush up your CSS skills and dive in even deeper. EVERY web developer has to know CSS. CSS - short for Cascading Style Sheets - is a programming language you use to turn your raw HTML pages into real beautiful websites.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 3,
                CourseName = "Modern JavaScript (from Novice to Ninja)",
                Price = 18.95M,
                CourseDescription = "Create awesome JavaScript driven web apps with modern JavaScript from the very beginning right through to ninja-level. In this course I'll be teaching you my absolute favourite language (JavaScript!) from the very beginning, right through to creating fully-fledged, dynamic & interactive web experiences.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });
            

        }

        
    }
}
