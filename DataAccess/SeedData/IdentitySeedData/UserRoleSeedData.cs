﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData.IdentitySeedData
{
    public class UserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "52ff41a6-5f72-4cef-9300-64c156772f2c",
                        UserId = "60bb4000-b9c3-4326-90ab-cb36ed4630b1"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "c846cec9-78f6-4ac8-b353-f30f856affc8",
                        UserId = "d1fc3486-c6fd-47df-963a-bf7805b11216"
                    },
                     new IdentityUserRole<string>
                     {
                         RoleId = "e9c75c3c-40fb-4c15-a960-504e1099ac2f",
                         UserId = "2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"
                     },
                     new IdentityUserRole<string>
                     {
                         RoleId = "78521ce1-a9e3-47b9-9426-5ad7e669df26",
                         UserId = "676452dd-8a1c-4747-8252-9ba2642917ea"
                     },
                     new IdentityUserRole<string>
                     {
                         RoleId = "78521ce1-a9e3-47b9-9426-5ad7e669df26",
                         UserId = "f78a22b2-e756-485f-8729-88003bacf1ff"
                     }
                );
        }
    }
}