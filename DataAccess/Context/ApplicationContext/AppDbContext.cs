using Core.Entities.Concrete;
using DataAccess.SeedData.EntitySeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context.ApplicationContext
{
    public class AppDbContext : DbContext
    {
        //Npgsql'nin tarih ve saat verilerini ele alış biçimini eski sürümlerle uyumlu hale getirmek için yazılmıştır.
        static AppDbContext()
        {
            AppContext.SetSwitch("Npqsql.EnableLegacyTimestampBehavior", true);
        }
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {
            
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CustomerManager> CustomerManagers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherSeedData());
            modelBuilder.ApplyConfiguration(new ClassroomSeedData());
            modelBuilder.ApplyConfiguration(new StudentSeedData());
            modelBuilder.ApplyConfiguration(new CustomerManegerSeedData());

            base.OnModelCreating(modelBuilder);
        }
    }
}
