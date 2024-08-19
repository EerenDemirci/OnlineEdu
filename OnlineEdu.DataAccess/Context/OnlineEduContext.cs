using System;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.Entity.Entities;
using Microsoft.Extensions.Configuration;

namespace OnlineEdu.DataAccess.Context;

public class OnlineEduContext: DbContext
{
    public OnlineEduContext(DbContextOptions options): base(options)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var conf = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            string stringUrl = conf.GetConnectionString("local");
            optionsBuilder.UseSqlServer(stringUrl);
        }
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Course> Courses   { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<Massage> Massages { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Subscriber> Subscribers { get; set; }
    public DbSet<Testimonial> Testimonials  { get; set; }
}
