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
    public class RoleSeedData : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            var admin = new IdentityRole<Guid>
            {
                Id= Guid.Parse("52ff41a6-5f72-4cef-9300-64c156772f2c"),
                Name = "admin",
                NormalizedName = "ADMIN"
            };
            var customerManager = new IdentityRole<Guid>
            {
                Id = Guid.Parse("c846cec9-78f6-4ac8-b353-f30f856affc8"),
                Name = "customarManager",
                NormalizedName = "CUSTOMERMANAGER"  
            };
            var teacher = new IdentityRole<Guid>
            {
                Id = Guid.Parse("e9c75c3c-40fb-4c15-a960-504e1099ac2f"),
                Name = "teacher",
                NormalizedName = "TEACHER"
            };
            var student = new IdentityRole<Guid>
            {
                Id = Guid.Parse("78521ce1-a9e3-47b9-9426-5ad7e669df26"),
                Name = "student",
                NormalizedName = "STUDENT"
            };
            builder.HasData(admin, customerManager, teacher,student);

        }
    }
}
