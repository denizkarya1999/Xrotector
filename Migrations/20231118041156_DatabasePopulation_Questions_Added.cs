using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cis_476_project.Migrations
{
    public partial class DatabasePopulation_Questions_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Login_Credentails",
                keyColumn: "LoginId",
                keyValue: new Guid("175eb1dc-62d0-481a-9528-50fed7f0c271"));

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id_key",
                keyValue: new Guid("e0f06fdd-0263-4900-85c5-120a2e663045"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "UserId",
                keyValue: new Guid("49563db6-e780-44f2-ada6-f8be2e9eb834"));

            migrationBuilder.DeleteData(
                table: "Vaults",
                keyColumn: "VaultId",
                keyValue: new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999"));

            migrationBuilder.CreateTable(
                name: "SecurityQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecurityQuestions_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vaults",
                columns: new[] { "VaultId", "Lock", "Mask", "Name", "UserId" },
                values: new object[] { new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da"), false, false, "Deniz`s Vault", new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da") });

            migrationBuilder.InsertData(
                table: "Login_Credentails",
                columns: new[] { "LoginId", "Password", "URL", "Username", "VaultId" },
                values: new object[] { new Guid("80c5cbac-77cb-43cb-9742-323e23269aee"), "Karya99DA", "www.denizkaryaacikbas.com", "denizkarya1999", new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da") });

            migrationBuilder.InsertData(
                table: "Passports",
                columns: new[] { "Id_key", "Country_of_Issuance", "ExpiryDate", "Id_Name", "IssuanceDate", "PassportNumber", "VaultId" },
                values: new object[] { new Guid("aa7740bf-00b4-401d-8d76-4c70b84785bb"), "Turkey", new DateTime(2033, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz`s Passport", new DateTime(2023, 11, 17, 23, 11, 56, 231, DateTimeKind.Local).AddTicks(7450), "U1232232", new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da") });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserId", "Email", "Name", "Password", "Surname", "VaultId" },
                values: new object[] { new Guid("07651a69-b24a-416e-abdf-d944a18c72df"), "dacikbas@umich.edu", "Deniz", "Karya99DA", "Acikbas", new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da") });

            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "Id", "Answer", "Question", "UserAccountId" },
                values: new object[] { new Guid("3cd05b5f-e408-4e86-a38c-9a107f749ba5"), "Zuhtupasha", "What was the first school you went to?", new Guid("07651a69-b24a-416e-abdf-d944a18c72df") });

            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "Id", "Answer", "Question", "UserAccountId" },
                values: new object[] { new Guid("bb69d521-54ad-43c5-801b-82ce093485ba"), "United Kingdom", "What was the first country you have ever visited?", new Guid("07651a69-b24a-416e-abdf-d944a18c72df") });

            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "Id", "Answer", "Question", "UserAccountId" },
                values: new object[] { new Guid("fa3c4f57-1758-4c81-8e62-989889522402"), "Tahrish", "What was the name of your first pet?", new Guid("07651a69-b24a-416e-abdf-d944a18c72df") });

            migrationBuilder.CreateIndex(
                name: "IX_SecurityQuestions_UserAccountId",
                table: "SecurityQuestions",
                column: "UserAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecurityQuestions");

            migrationBuilder.DeleteData(
                table: "Login_Credentails",
                keyColumn: "LoginId",
                keyValue: new Guid("80c5cbac-77cb-43cb-9742-323e23269aee"));

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id_key",
                keyValue: new Guid("aa7740bf-00b4-401d-8d76-4c70b84785bb"));

            migrationBuilder.DeleteData(
                table: "UserAccounts",
                keyColumn: "UserId",
                keyValue: new Guid("07651a69-b24a-416e-abdf-d944a18c72df"));

            migrationBuilder.DeleteData(
                table: "Vaults",
                keyColumn: "VaultId",
                keyValue: new Guid("c5791f59-1979-4f92-89d4-0bcb203fd9da"));

            migrationBuilder.InsertData(
                table: "Vaults",
                columns: new[] { "VaultId", "Lock", "Mask", "Name", "UserId" },
                values: new object[] { new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999"), false, false, "Deniz`s Vault", new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999") });

            migrationBuilder.InsertData(
                table: "Login_Credentails",
                columns: new[] { "LoginId", "Password", "URL", "Username", "VaultId" },
                values: new object[] { new Guid("175eb1dc-62d0-481a-9528-50fed7f0c271"), "Karya99DA", "www.denizkaryaacikbas.com", "denizkarya1999", new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999") });

            migrationBuilder.InsertData(
                table: "Passports",
                columns: new[] { "Id_key", "Country_of_Issuance", "ExpiryDate", "Id_Name", "IssuanceDate", "PassportNumber", "VaultId" },
                values: new object[] { new Guid("e0f06fdd-0263-4900-85c5-120a2e663045"), "Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz`s Passport", new DateTime(2023, 11, 17, 22, 23, 20, 360, DateTimeKind.Local).AddTicks(3049), "U1232232", new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999") });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "UserId", "Email", "Name", "Password", "Surname", "VaultId" },
                values: new object[] { new Guid("49563db6-e780-44f2-ada6-f8be2e9eb834"), "dacikbas@umich.edu", "Deniz", "Karya99DA", "Acikbas", new Guid("a03669c9-8126-48ae-a876-0f5bd69bb999") });
        }
    }
}
