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
    public class CustomerManegerSeedData : IEntityTypeConfiguration<CustomerManager>
    {
        public void Configure(EntityTypeBuilder<CustomerManager> builder)
        {
            builder.HasData
                (
                    new CustomerManager
                    {
                        Id= Guid.Parse("5b18130c-a388-4e1b-97dd-6b1eab4c60ff"),
                        FirstName = "Pelin",
                        LastName = "Özer Serdar",
                        Email = "pelin.ozerserdar@bilgeadam.com",
                        BirthDate = new DateTime(1994,05,06),
                        HireDate = new DateTime(2023,06,06),
                        AppUserId = Guid.Parse("d1fc3486-c6fd-47df-963a-bf7805b11216")
                    }
                );
        }
    }
}
