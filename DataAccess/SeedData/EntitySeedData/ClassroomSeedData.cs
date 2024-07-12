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
    public class ClassroomSeedData : IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.HasData
                (
                    new ClassRoom
                    {
                        Id = Guid.Parse("50162998-279b-41b8-a2c2-7e5e40315498"),
                        ClassroomName = "Yzl-8150",
                        Description = "320 saat .NET Full Stack Yazılım Uzmanlığı Eğitimi",
                        TeacherId = Guid.Parse("2e57881d-cb72-4c88-b22e-a0f3dae265d6")
                    }
                );
        }
    }
}
