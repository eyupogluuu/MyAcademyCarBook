using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.EntityFramework;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyAcademyCarBook.DataAccessLayer.Concrete
{
	public class CarBookContext :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2PU1K7L\\SQLEXPRESS; initial catalog=CarBookDB; integrated security=true");
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<CarStatus> carStatuses { get; set; }
        public DbSet<CarCategory> carCategories { get; set; }
        public DbSet<Price> prices { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<HowItWork> howItWorks { get; set; }
        public DbSet<CarDetail> carDetails { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<CommunucationInfo> communucationInfos { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
    }
}
