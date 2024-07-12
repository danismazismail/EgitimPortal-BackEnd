using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.EntitySeedData
{
    public class TeacherSeedData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
                (
                    new Teacher
                    {
                        Id = Guid.Parse("2e57881d-cb72-4c88-b22e-a0f3dae265d6"),
                        FirstName = "Sina Emre",
                        LastName = "Bekar",
                        BirthDate = new DateTime(1996, 01, 23),
                        Email = "sinaemre.bekar@bilgeadam.com",
                        AppUserId = Guid.Parse("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1")
                    }
                );
        }
    }
}
