using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Context.ApplicationContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Course = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClassroomName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRooms_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Exam1 = table.Column<double>(type: "double precision", nullable: true),
                    Exam2 = table.Column<double>(type: "double precision", nullable: true),
                    ProjectExam = table.Column<double>(type: "double precision", nullable: true),
                    ProjectPath = table.Column<string>(type: "text", nullable: true),
                    ProjectName = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ClassroomID = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_ClassRooms_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "ClassRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CustomerManagers",
                columns: new[] { "Id", "AppUserId", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "HireDate", "LastName", "Status", "UpdatedDate" },
                values: new object[] { new Guid("5b18130c-a388-4e1b-97dd-6b1eab4c60ff"), new Guid("d1fc3486-c6fd-47df-963a-bf7805b11216"), new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 17, 56, 48, 333, DateTimeKind.Local).AddTicks(7393), null, "pelin.ozerserdar@bilgeadam.com", "Pelin", new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Özer Serdar", 1, null });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "AppUserId", "BirthDate", "Course", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[] { new Guid("2e57881d-cb72-4c88-b22e-a0f3dae265d6"), new Guid("2b72352f-a6c3-4b5f-8677-cb5fcaec34b1"), new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2024, 7, 12, 17, 56, 48, 333, DateTimeKind.Local).AddTicks(6742), null, "sinaemre.bekar@bilgeadam.com", "Sina Emre", "Bekar", 1, null });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassroomName", "CreatedDate", "DeletedDate", "Description", "Status", "TeacherId", "UpdatedDate" },
                values: new object[] { new Guid("50162998-279b-41b8-a2c2-7e5e40315498"), "Yzl-8150", new DateTime(2024, 7, 12, 17, 56, 48, 333, DateTimeKind.Local).AddTicks(7065), null, "320 saat .NET Full Stack Yazılım Uzmanlığı Eğitimi", 1, new Guid("2e57881d-cb72-4c88-b22e-a0f3dae265d6"), null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AppUserId", "BirthDate", "ClassroomID", "CreatedDate", "DeletedDate", "Email", "Exam1", "Exam2", "FirstName", "ImagePath", "LastName", "ProjectExam", "ProjectName", "ProjectPath", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1a1a8b40-ff70-46bd-9ec2-235279e9129e"), new Guid("f78a22b2-e756-485f-8729-88003bacf1ff"), new DateTime(1995, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50162998-279b-41b8-a2c2-7e5e40315498"), new DateTime(2024, 7, 12, 17, 56, 48, 333, DateTimeKind.Local).AddTicks(7251), null, "ismail.danismaz@bilgeadam.com", null, null, "İsmail", null, "Danışmaz", null, null, null, 1, null },
                    { new Guid("7b0de540-cc70-46bd-9ec2-235279e9129e"), new Guid("676452dd-8a1c-4747-8252-9ba2642917ea"), new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50162998-279b-41b8-a2c2-7e5e40315498"), new DateTime(2024, 7, 12, 17, 56, 48, 333, DateTimeKind.Local).AddTicks(7244), null, "dicle.goya@bilgeadam.com", null, null, "Dicle", null, "Göya", null, null, null, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_TeacherId",
                table: "ClassRooms",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomID",
                table: "Students",
                column: "ClassroomID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerManagers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
