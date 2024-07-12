using Core.Entities.UserEntities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class UserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            var admin = new AppUser
            {
                Id = Guid.Parse("60bb4000-b9c3-4326-90ab-cb36ed4630b1"),
                FirstName = "Yönetici",
                LastName = "Admin",
                BirthDate = new DateTime(2000, 01, 01),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@bilgeadam.com",
                NormalizedEmail = "ADMIN@BILGEADAM.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };
            var customerManager = new AppUser
            {
                Id = Guid.Parse("d1fc3486-c6fd-47df-963a-bf7805b11216"),
                FirstName = "Pelin",
                LastName = "Özer Serdar",
                BirthDate = new DateTime(1994, 05, 06),
                UserName = "pelin.ozerserdar",
                NormalizedUserName = "PELIN.OZERSERDAR",
                Email = "pelin.ozerserdar@bilgeadamakademi.com",
                NormalizedEmail = "PELIN.OZERSERDAR@BILGEADAMAKADEMI.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };
            var teacher = new AppUser
            {
                Id = Guid.Parse("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"),
                FirstName = "Sina Emre",
                LastName = "Bekar",
                BirthDate = new DateTime(1996, 01, 23),
                UserName = "sinaemre.bekar",
                NormalizedUserName = "SINAENMRE.BEKAR",
                Email = "sinaemre.bekar@bilgeadamakademi.com",
                NormalizedEmail = "SINAENMRE.BEKAR@BILGEADAMAKADEMI.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };
            var student1 = new AppUser
            {
                Id = Guid.Parse("676452dd-8a1c-4747-8252-9ba2642917ea"),
                FirstName = "Dicle",
                LastName = "Goya",
                BirthDate = new DateTime(1993, 04, 18),
                UserName = "dicle.goya",
                NormalizedUserName = "DICLE.GOYA",
                Email = "dicle.goya@bilgeadamakademi.com",
                NormalizedEmail = "DICLE.GOYA@BILGEADAMAKADEMI.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };
            var student2 = new AppUser
            {
                Id = Guid.Parse("f78a22b2-e756-485f-8729-88003bacf1ff"),
                FirstName = "İsmail",
                LastName = "Danışmaz",
                BirthDate = new DateTime(1990, 06, 10),
                UserName = "ismail.danismaz",
                NormalizedUserName = "ISMAIL.DANISMAZ",
                Email = "ismail.danismaz@bilgeadamakademi.com",
                NormalizedEmail = "ISMAIL.DANISMAZ@BILGEADAMAKADEMI.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            builder.HasData(admin, customerManager, teacher, student1, student2);
        }
    }
}
