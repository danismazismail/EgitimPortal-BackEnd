using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData.EntitySeedData
{
    public class StudentSeedData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (
                    new Student
                    {
                        Id = Guid.Parse("7b0de540-cc70-46bd-9ec2-235279e9129e"),
                        FirstName = "Dicle",
                        LastName = "Göya",
                        BirthDate = new DateTime(1993, 04, 18),
                        Email = "dicle.goya@bilgeadam.com",
                        ClassroomID = Guid.Parse("50162998-279b-41b8-a2c2-7e5e40315498"),
                        AppUserId = Guid.Parse("676452dd-8a1c-4747-8252-9ba2642917ea")
                    },
                    new Student
                    {
                        Id = Guid.Parse("1a1a8b40-ff70-46bd-9ec2-235279e9129e"),
                        FirstName = "İsmail",
                        LastName = "Danışmaz",
                        BirthDate = new DateTime(1995, 06, 15),
                        Email = "ismail.danismaz@bilgeadam.com",
                        ClassroomID = Guid.Parse("50162998-279b-41b8-a2c2-7e5e40315498"),
                        AppUserId = Guid.Parse("f78a22b2-e756-485f-8729-88003bacf1ff")
                    }
                );
        }
    }
}