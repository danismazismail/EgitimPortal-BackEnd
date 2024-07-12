using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.IdentityContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LoginCount = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("52ff41a6-5f72-4cef-9300-64c156772f2c"), null, "admin", "ADMIN" },
                    { new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26"), null, "student", "STUDENT" },
                    { new Guid("c846cec9-78f6-4ac8-b353-f30f856affc8"), null, "customarManager", "CUSTOMERMANAGER" },
                    { new Guid("e9c75c3c-40fb-4c15-a960-504e1099ac2f"), null, "teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "LoginCount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"), 0, new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "8debb37a-e8db-4f8b-b698-ed8a71884823", new DateTime(2024, 7, 12, 18, 10, 37, 907, DateTimeKind.Local).AddTicks(1499), null, "sinaemre.bekar@bilgeadamakademi.com", false, "Sina Emre", "Bekar", false, null, 0, "SINAENMRE.BEKAR@BILGEADAMAKADEMI.COM", "SINAENMRE.BEKAR", "AQAAAAIAAYagAAAAEEmuZvBfzNL83QsOo4pSpKSWwUDjUHVph5V68XG+rqPFTsaRg1rwY/EBG6jd7OgU3A==", null, false, null, 1, false, null, "sinaemre.bekar" },
                    { new Guid("60bb4000-b9c3-4326-90ab-cb36ed4630b1"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cb3efab5-0e26-4f93-9851-d56dc880e432", new DateTime(2024, 7, 12, 18, 10, 37, 700, DateTimeKind.Local).AddTicks(4389), null, "admin@bilgeadam.com", false, "Yönetici", "Admin", false, null, 0, "ADMIN@BILGEADAM.COM", "ADMIN", "AQAAAAIAAYagAAAAEEJqWAjY/nw736yMfMPoDkR/fDqL40Bec3QFIIXfEQF0a/p58ITFAfrbnCkq9YbdVw==", null, false, null, 1, false, null, "admin" },
                    { new Guid("676452dd-8a1c-4747-8252-9ba2642917ea"), 0, new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "f07ca0fd-7f09-486e-970b-73a3451b7704", new DateTime(2024, 7, 12, 18, 10, 38, 6, DateTimeKind.Local).AddTicks(6335), null, "dicle.goya@bilgeadamakademi.com", false, "Dicle", "Goya", false, null, 0, "DICLE.GOYA@BILGEADAMAKADEMI.COM", "DICLE.GOYA", "AQAAAAIAAYagAAAAEK4u6pSA0EnLqsn/fchMN//P3DgmQy1EDiqhfd9FvXk3wAB5VzHp6RDbo1U6VqPBdg==", null, false, null, 1, false, null, "dicle.goya" },
                    { new Guid("d1fc3486-c6fd-47df-963a-bf7805b11216"), 0, new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "7032109c-bed4-4b08-8394-b7c68cf3eb42", new DateTime(2024, 7, 12, 18, 10, 37, 812, DateTimeKind.Local).AddTicks(2632), null, "pelin.ozerserdar@bilgeadamakademi.com", false, "Pelin", "Özer Serdar", false, null, 0, "PELIN.OZERSERDAR@BILGEADAMAKADEMI.COM", "PELIN.OZERSERDAR", "AQAAAAIAAYagAAAAEILu1tR6QTA/OCTGwxgVTp8l+R7zwWkSwC9xDUb89qe7SFVWzx2JQEPH88PMMTx1qQ==", null, false, null, 1, false, null, "pelin.ozerserdar" },
                    { new Guid("f78a22b2-e756-485f-8729-88003bacf1ff"), 0, new DateTime(1990, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "b16c3ca5-0bbc-4050-8786-b0455480f526", new DateTime(2024, 7, 12, 18, 10, 38, 105, DateTimeKind.Local).AddTicks(9107), null, "ismail.danismaz@bilgeadamakademi.com", false, "İsmail", "Danışmaz", false, null, 0, "ISMAIL.DANISMAZ@BILGEADAMAKADEMI.COM", "ISMAIL.DANISMAZ", "AQAAAAIAAYagAAAAEHs0SKvxOVP0wgLFobc6ZsFHGsV7zYzUvMkNg9SVH0hS7oMoRGaNeVIGTbbnIwAt+Q==", null, false, null, 1, false, null, "ismail.danismaz" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9c75c3c-40fb-4c15-a960-504e1099ac2f"), new Guid("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1") },
                    { new Guid("52ff41a6-5f72-4cef-9300-64c156772f2c"), new Guid("60bb4000-b9c3-4326-90ab-cb36ed4630b1") },
                    { new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26"), new Guid("676452dd-8a1c-4747-8252-9ba2642917ea") },
                    { new Guid("c846cec9-78f6-4ac8-b353-f30f856affc8"), new Guid("d1fc3486-c6fd-47df-963a-bf7805b11216") },
                    { new Guid("78521ce1-a9e3-47b9-9426-5ad7e669df26"), new Guid("f78a22b2-e756-485f-8729-88003bacf1ff") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
