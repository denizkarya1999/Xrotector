using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cis_476_project.Migrations
{
    public partial class DatabasePopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaults",
                columns: table => new
                {
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lock = table.Column<bool>(type: "bit", nullable: false),
                    Mask = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaults", x => x.VaultId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CardNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CardNumber);
                    table.ForeignKey(
                        name: "FK_CreditCards_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriversLicenses",
                columns: table => new
                {
                    Id_key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversLicenses", x => x.Id_key);
                    table.ForeignKey(
                        name: "FK_DriversLicenses_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalIds",
                columns: table => new
                {
                    Id_key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalIds", x => x.Id_key);
                    table.ForeignKey(
                        name: "FK_LocalIds_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Login_Credentails",
                columns: table => new
                {
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login_Credentails", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_Login_Credentails_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id_key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country_of_Issuance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id_key);
                    table.ForeignKey(
                        name: "FK_Passports_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecurityNotes",
                columns: table => new
                {
                    SecurityNoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityNotes", x => x.SecurityNoteId);
                    table.ForeignKey(
                        name: "FK_SecurityNotes_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSNs",
                columns: table => new
                {
                    Id_key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SSNNumber = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSNs", x => x.Id_key);
                    table.ForeignKey(
                        name: "FK_SSNs_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserAccounts_Vaults_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vaults",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_VaultId",
                table: "CreditCards",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_DriversLicenses_VaultId",
                table: "DriversLicenses",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalIds_VaultId",
                table: "LocalIds",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Credentails_VaultId",
                table: "Login_Credentails",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_VaultId",
                table: "Passports",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityNotes_VaultId",
                table: "SecurityNotes",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_SSNs_VaultId",
                table: "SSNs",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_VaultId",
                table: "UserAccounts",
                column: "VaultId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "DriversLicenses");

            migrationBuilder.DropTable(
                name: "LocalIds");

            migrationBuilder.DropTable(
                name: "Login_Credentails");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "SecurityNotes");

            migrationBuilder.DropTable(
                name: "SSNs");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Vaults");
        }
    }
}
