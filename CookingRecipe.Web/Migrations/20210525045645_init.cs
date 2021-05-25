using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingRecipe.Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    InstructionId = table.Column<Guid>(nullable: true),
                    IngredientId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    LoginStatus = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    LoginRetries = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CookingId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Cookings_CookingId",
                        column: x => x.CookingId,
                        principalTable: "Cookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CookingId = table.Column<Guid>(nullable: true),
                    Step = table.Column<string>(nullable: true),
                    TotalStep = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_Cookings_CookingId",
                        column: x => x.CookingId,
                        principalTable: "Cookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cookings",
                columns: new[] { "Id", "CreatedAt", "IngredientId", "InstructionId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7194), null, null, "Adobong Baboy", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7197) },
                    { new Guid("0339bd26-b895-4471-8052-ab2ffe29be98"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7405), null, null, "Paksiw Isda", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7406) },
                    { new Guid("6b7a50e7-a90e-4be6-a869-c33084c02bfe"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7391), null, null, "Beef Bulalo", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7392) },
                    { new Guid("6cc73fbb-39a4-4df2-9390-9e678409d30e"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7384), null, null, "Ginataang Langka", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7385) },
                    { new Guid("b6e97a13-c953-46b3-afe2-4d709e722e3b"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7378), null, null, "Pork Bistek", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7379) },
                    { new Guid("1ff74660-f576-4fbf-8691-fe8e28358a64"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7370), null, null, "Chop Suey", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7371) },
                    { new Guid("16aa5e0c-886e-4807-b1de-13942600ce23"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7312), null, null, "Bicol Express", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7313) },
                    { new Guid("96405bf3-5174-4596-9fb1-b45225cee1c9"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7397), null, null, "Achara", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7398) },
                    { new Guid("b2fdf377-576b-4f61-822f-c847cc0b7515"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7300), null, null, "Sisig", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7301) },
                    { new Guid("49d33a16-2cc2-41af-8a35-568f08bcd904"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7293), null, null, "Dinuguan", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7294) },
                    { new Guid("5d15a152-4a5f-4c49-925c-92ff2cabac4e"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7280), null, null, "Afritada", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7280) },
                    { new Guid("daf66e9e-f51c-41f6-bde7-196022b00bdb"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7273), null, null, "Sinigang Baboy", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7274) },
                    { new Guid("04a8beb5-d3fc-4cab-9f2e-78ee68fb2555"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7265), null, null, "Sinigang Isda", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7267) },
                    { new Guid("765d31e6-e9cb-4f11-a9be-4b38518db304"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7257), null, null, "Tinolang Manok", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7258) },
                    { new Guid("f17f738d-376c-403e-a503-fc8837dbddfc"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7306), null, null, "Daing", new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(7307) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "Role", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("8436f69d-200e-4ef9-81bd-46038f11d644"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5197), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5198), new Guid("1e5a951c-ae94-42dd-b01b-62460c556408") },
                    { new Guid("87abcfc2-60f1-4632-9e06-bc363d57b88b"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5209), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5210), new Guid("7f5c0d24-0d38-48b4-a5b7-bd6b5e3bbe22") },
                    { new Guid("9cc6bada-f43f-47e2-b8e6-462f97f0a9ed"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5219), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5220), new Guid("385fd1f1-82a6-4eb8-826f-89d8873bcdb1") },
                    { new Guid("bd436a4b-dac7-43c7-bd5d-1a434da9a99c"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5232), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5233), new Guid("a09573f5-62b9-4548-b153-4d2eac8ef29e") },
                    { new Guid("ec54e10c-21eb-4509-8d13-23edcc6b494d"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5242), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5243), new Guid("984797ad-c1c8-4d36-a527-80e41dd6592e") },
                    { new Guid("f72a76a3-bd79-4c36-a454-2dfc8077cdc1"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5275), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5277), new Guid("e358f015-6a5f-4a20-8718-513a23fef0fd") },
                    { new Guid("b95ac303-abac-43cd-801d-02bd480c231b"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5263), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5265), new Guid("f178c3cb-db20-436d-a2e2-36d34772dba8") },
                    { new Guid("5acf73f4-d64e-4a58-9762-f42067d43fa6"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5284), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5286), new Guid("b36f7f45-1b05-4905-9a66-8183809ff8c8") },
                    { new Guid("5d56eb33-d5d2-4bdc-9a06-7e07f1b32f30"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5295), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5296), new Guid("83349c71-bbe2-4c2d-a9a5-3d555a00305c") },
                    { new Guid("f5cd2ec2-8f70-4c06-917b-188a245e61ff"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5153), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5155), new Guid("62fb0427-e259-4874-b904-5f5d4d6c4b9e") },
                    { new Guid("82400738-a126-4341-a8bc-dd38409174d8"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5252), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5254), new Guid("e5037a48-8f1e-4811-8d51-72cef2238ce3") },
                    { new Guid("880e8918-8e8f-488b-9ffc-bd06285881dc"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(4587), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(4590), new Guid("24551e81-1887-4288-89f4-7d4d433120fa") },
                    { new Guid("faf2ed2d-370e-48cc-aa57-cdee56d72fdb"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5313), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5314), new Guid("9c304fab-d362-483c-be13-885381731ba8") },
                    { new Guid("dc49b9f8-254d-4bca-82db-a4aff22287c8"), new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5305), 1, new DateTime(2021, 5, 25, 4, 56, 44, 774, DateTimeKind.Utc).AddTicks(5306), new Guid("634e0321-5f02-458b-a2b8-7bd07bc86672") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "EmailAddress", "FirstName", "FullName", "Gender", "LastName", "LoginRetries", "LoginStatus", "Password", "PhoneNumber", "Surname", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("634e0321-5f02-458b-a2b8-7bd07bc86672"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 681, DateTimeKind.Utc).AddTicks(5799), "Christian@gmail.com", "Christian", "Christian Cruz", 0, "Cruz", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Christian09", new DateTime(2021, 5, 25, 4, 56, 44, 681, DateTimeKind.Utc).AddTicks(5817) },
                    { new Guid("83349c71-bbe2-4c2d-a9a5-3d555a00305c"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 592, DateTimeKind.Utc).AddTicks(9633), "Jake@gmail.com", "Jake Renzo", "Jake Renzo Carlos", 0, "Carlos", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Jake08", new DateTime(2021, 5, 25, 4, 56, 44, 592, DateTimeKind.Utc).AddTicks(9713) },
                    { new Guid("41494e0e-cde7-46de-897c-a8369fba5ba9"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 505, DateTimeKind.Utc).AddTicks(5015), "Elmo@gmail.com", "Elmo", "Elmo Cahilo", 0, "Cahilo", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Elmo07", new DateTime(2021, 5, 25, 4, 56, 44, 505, DateTimeKind.Utc).AddTicks(5065) },
                    { new Guid("b36f7f45-1b05-4905-9a66-8183809ff8c8"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 414, DateTimeKind.Utc).AddTicks(3254), "Jhon@gmail.com", "Jhon Cedric", "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", 0, "Romano", 0, 0, "123456789", "123456789", "Jhon06", new DateTime(2021, 5, 25, 4, 56, 44, 414, DateTimeKind.Utc).AddTicks(3303) },
                    { new Guid("e358f015-6a5f-4a20-8718-513a23fef0fd"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 314, DateTimeKind.Utc).AddTicks(6989), "Reniel@gmail.com", "Reniel ", "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", 0, "David", 0, 0, "123456789", "123456789", "Reniel04", new DateTime(2021, 5, 25, 4, 56, 44, 314, DateTimeKind.Utc).AddTicks(7043) },
                    { new Guid("f178c3cb-db20-436d-a2e2-36d34772dba8"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 228, DateTimeKind.Utc).AddTicks(343), "Wesley@gmail.com", "Wesley", "Wesley SA", 0, "SA", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Wesley03", new DateTime(2021, 5, 25, 4, 56, 44, 228, DateTimeKind.Utc).AddTicks(391) },
                    { new Guid("984797ad-c1c8-4d36-a527-80e41dd6592e"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 50, DateTimeKind.Utc).AddTicks(5510), "larich@gmail.com", "Larich", "Larich Morales", 1, "Morales", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Larich01", new DateTime(2021, 5, 25, 4, 56, 44, 50, DateTimeKind.Utc).AddTicks(5562) },
                    { new Guid("a09573f5-62b9-4548-b153-4d2eac8ef29e"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 43, 954, DateTimeKind.Utc).AddTicks(8352), "Luisa@gmail.com", "Luisa", "Luisa Kathrina Reyes", 1, "Reyes", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "LuisaKath", new DateTime(2021, 5, 25, 4, 56, 43, 954, DateTimeKind.Utc).AddTicks(8403) },
                    { new Guid("385fd1f1-82a6-4eb8-826f-89d8873bcdb1"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 43, 865, DateTimeKind.Utc).AddTicks(6314), "Allan@gmail.com", "Allan", "Allan Chavez", 0, "Chavez", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Allan", new DateTime(2021, 5, 25, 4, 56, 43, 865, DateTimeKind.Utc).AddTicks(6334) },
                    { new Guid("62fb0427-e259-4874-b904-5f5d4d6c4b9e"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 43, 778, DateTimeKind.Utc).AddTicks(3510), "Xyrille@gmail.com", "Xyrille", "Xyrille Mamalateo", 1, "Mamalateo", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "XyAnn", new DateTime(2021, 5, 25, 4, 56, 43, 778, DateTimeKind.Utc).AddTicks(3531) },
                    { new Guid("24551e81-1887-4288-89f4-7d4d433120fa"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 43, 691, DateTimeKind.Utc).AddTicks(8888), "cdbcasupanan@gmail.com", "Cd", "CD Casupanan", 0, "Casupanan", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "cdbcasupanan", new DateTime(2021, 5, 25, 4, 56, 43, 691, DateTimeKind.Utc).AddTicks(8924) },
                    { new Guid("9c304fab-d362-483c-be13-885381731ba8"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 771, DateTimeKind.Utc).AddTicks(9970), "mama@gmail.com", "MAMA", "MAMA KO", 1, "KO", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "MAMA00", new DateTime(2021, 5, 25, 4, 56, 44, 771, DateTimeKind.Utc).AddTicks(9990) },
                    { new Guid("e5037a48-8f1e-4811-8d51-72cef2238ce3"), "Dinalupihan", new DateTime(2021, 5, 25, 4, 56, 44, 141, DateTimeKind.Utc).AddTicks(4430), "jane@gmail.com", "Jane", "Jane Ticar", 1, "Ticar", 0, 0, "$2b$10$zsNJKcoYMCWUZc156h8pfOcHUAQZ.msqshCQFRtsF9p39dcxn6cqu", "123456789", "Jane02", new DateTime(2021, 5, 25, 4, 56, 44, 141, DateTimeKind.Utc).AddTicks(4499) }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CookingId", "CreatedAt", "Name", "Quantity", "UnitCost", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("ca25c528-627b-4b80-9b91-02d06afc3c55"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(410), "Chicken Thighs", 1, 50m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(413) },
                    { new Guid("8c63a87f-f380-48fb-860f-c77e82ee338c"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(573), "Bay leaves", 4, 3m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(574) },
                    { new Guid("e1145858-0470-413d-99bc-a2507365f52f"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(564), "Peppercorns", 1, 5m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(565) },
                    { new Guid("48ba0fda-bceb-44eb-92c0-80b7460e7339"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(554), "Soy sauce", 1, 7m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(555) },
                    { new Guid("646c08f6-fd0e-4eb2-8b97-21039f8f87eb"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(582), "Green onion", 1, 10m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(583) },
                    { new Guid("eeb8ba33-56c5-401a-967e-d3a9721dcd2a"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(530), "Garlic", 5, 10m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(531) },
                    { new Guid("711b6d5a-19a3-44c8-81d9-8cb361fc01d3"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(521), "Onion", 2, 10m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(522) },
                    { new Guid("0b483fb6-f736-4baa-ab3c-d8f2a1e163c7"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(509), "Vegetable Oil", 1, 35m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(511) },
                    { new Guid("e489d772-baa5-4e5b-ae96-60e49b0ce3f2"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(541), "Vinegar", 1, 7m, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(542) }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "CookingId", "CreatedAt", "Step", "Time", "TotalStep", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d8baa664-dafe-45e5-b234-724c80810dec"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3248), "7th Step : Add the soy sauce and vinegar then add peppercorns, bay leaves and green onion then add a half water of cup", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3249) },
                    { new Guid("b2152e67-b875-4a9d-a5ee-662b73ea6caf"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3118), "1st step : Chop and clean the ingredients and wash it", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3121) },
                    { new Guid("7740c040-9f5e-4bd8-ae72-d2a6f634ab99"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3197), "2nd step : Prepare the ingredients", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3199) },
                    { new Guid("414ee824-29f6-4679-b43b-7f70e9f00f2a"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3210), "3rd Step : Now the is ingredients is ready we proceed to cook the dish!", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3211) },
                    { new Guid("9c4c3bb7-1cf5-4cbe-9ebb-d83555f88426"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3219), "4th Step : Light up the stove and  heat the pan just slight ", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3220) },
                    { new Guid("95466927-2a0b-4594-8f6a-76d4504e5b84"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3228), "5th Step : Put the vegetable oil and heat it just slight and put the onions and garlic first.", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3229) },
                    { new Guid("75a015df-929d-4bda-bc7f-dbd78b3860b5"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3240), "6th Step : When the onions and garlics are smells good or the color is brown then just put the chicken thighs and cook it for 10mns to 15mns", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3241) },
                    { new Guid("63db5447-986e-4136-b81f-afa50230d24f"), new Guid("8b578d2c-8819-4c50-bf9a-ab33cd6a1ea4"), new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3258), "8th Step : Wait for 10 to 15mns to cook the adobo and then check your dish if the dish is yummy else just add more soy sauce and salt base on the your taste of food and were done! Thank you for following our cooking recipe.", "", 0, new DateTime(2021, 5, 25, 4, 56, 44, 775, DateTimeKind.Utc).AddTicks(3259) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CookingId",
                table: "Ingredients",
                column: "CookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_CookingId",
                table: "Instructions",
                column: "CookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cookings");
        }
    }
}
