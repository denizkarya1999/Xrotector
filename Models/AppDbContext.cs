using Xrocter.Models.Vault_Models.ID;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xrocter.Vault_Models.ID;

namespace Xrocter.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //Create datasets
        public DbSet<UserAccount>? UserAccounts { get; set; }
        public DbSet<SecurityQuestion>? SecurityQuestions { get; set; }
        public DbSet<Vault>? Vaults { get; set; }

        // Vault related datasets
        public DbSet<SecurityNote>? SecurityNotes { get; set; }
        public DbSet<Login>? Login_Credentails { get; set; }
        public DbSet<CreditCard>? CreditCards { get; set; }

        // Id related datasets
        public DbSet<DriversLicense>? DriversLicenses { get; set; }
        public DbSet<LocalId>? LocalIds { get; set; }
        public DbSet<Passport>? Passports { get; set; }
        public DbSet<SSN>? SSNs { get; set; }

        //Make connections and seed the data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Associate UserAccount with Vault (One to one)
            modelBuilder.Entity<UserAccount>()
                .HasOne(user => user.Vault)
                .WithOne(vault => vault.UserAccount)
                .HasForeignKey<Vault>(vault => vault.UserId)
                .IsRequired();

            // Associate Vault with UserAccount (One to one)
            modelBuilder.Entity<Vault>()
                .HasOne(vault => vault.UserAccount)
                .WithOne(user => user.Vault)
                .HasForeignKey<UserAccount>(user => user.VaultId)
                .IsRequired();

            // Associate Vault with Login (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.LoginCredentials)
                .WithOne(login => login.Vault)
                .HasForeignKey(login => login.VaultId)
                .IsRequired();

            // Associate Vault with CreditCard (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.CreditCards)
                .WithOne(CreditCard => CreditCard.Vault)
                .HasForeignKey(CreditCard => CreditCard.VaultId)
                .IsRequired();

            // Associate Vault with SecurityNote (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.SecurityNotes)
                .WithOne(securityNote => securityNote.Vault)
                .HasForeignKey(securityNote => securityNote.VaultId)
                .IsRequired();

            // Associate Vault with Passport (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.Passports)
                .WithOne(Passport => Passport.Vault)
                .HasForeignKey(Passport => Passport.VaultId)
                .IsRequired();

            // Associate Vault with SSN (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.SSNs)
                .WithOne(SSN => SSN.Vault)
                .HasForeignKey(SSN => SSN.VaultId)
                .IsRequired();

            // Associate Vault with LocalID (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.localIDs)
                .WithOne(LocalId => LocalId.Vault)
                .HasForeignKey(LocalId => LocalId.VaultId)
                .IsRequired();

            // Associate Vault with Drivers License (One to Many)
            modelBuilder.Entity<Vault>()
                .HasMany(vault => vault.DriversLicenses)
                .WithOne(license => license.Vault)
                .HasForeignKey(license => license.VaultId)
                .IsRequired();

            // Associate SecurityNote with Vault (One to Many)
            modelBuilder.Entity<SecurityNote>()
                .HasOne(securityNote => securityNote.Vault)
                .WithMany(vault => vault.SecurityNotes)
                .HasForeignKey(securityNote => securityNote.VaultId)
                .IsRequired();

            // Associate Login with Vault (One to Many)
            modelBuilder.Entity<Login>()
                .HasOne(login => login.Vault)
                .WithMany(vault => vault.LoginCredentials)
                .HasForeignKey(login => login.VaultId)
                .IsRequired();

            // Associate CreditCard with Vault (One to Many)
            modelBuilder.Entity<CreditCard>()
                .HasOne(CreditCard => CreditCard.Vault)
                .WithMany(vault => vault.CreditCards)
                .HasForeignKey(CreditCard => CreditCard.VaultId)
                .IsRequired();

            // Associate DriversLicense with Vault (One to Many)
            modelBuilder.Entity<DriversLicense>()
                .HasOne(DriversLicense => DriversLicense.Vault)
                .WithMany(vault => vault.DriversLicenses)
                .HasForeignKey(DriversLicenses => DriversLicenses.VaultId)
                .IsRequired();

            // Associate LocalID with Vault (One to Many)
            modelBuilder.Entity<LocalId>()
                .HasOne(LocalId => LocalId.Vault)
                .WithMany(vault => vault.localIDs)
                .HasForeignKey(LocalId => LocalId.VaultId)
                .IsRequired();

            // Associate Passport with Vault (One to Many)
            modelBuilder.Entity<Passport>()
                .HasOne(Passport => Passport.Vault)
                .WithMany(vault => vault.Passports)
                .HasForeignKey(Passport => Passport.VaultId)
                .IsRequired();

            // Associate Passport with SSN (One to Many)
            modelBuilder.Entity<SSN>()
                .HasOne(SSN => SSN.Vault)
                .WithMany(vault => vault.SSNs)
                .HasForeignKey(SSN => SSN.VaultId)
                .IsRequired();

            // Associate SecurityQuestion with UserAccount (One to Many)
            modelBuilder.Entity<UserAccount>()
                .HasMany(user => user.SecurityQuestions)
                .WithOne(question => question.UserAccount)
                .HasForeignKey(question => question.UserAccountId)
                .IsRequired();

            //Generate Guids for tables
            Guid denizUAID = Guid.NewGuid();
            Guid denizVAID = Guid.NewGuid();
            Guid denizPassportID = Guid.NewGuid();
            Guid denizLoginID = Guid.NewGuid();

            // Populate the table - Deniz Acikbas
            Passport denizPassport = new Passport() {
                Id_key = denizPassportID,
                Id_Name = "Deniz`s Passport",
                PassportNumber = "U1232232",
                Country_of_Issuance = "Turkey",
                IssuanceDate = DateTime.Now,
                ExpiryDate = new DateTime(2033, 12, 6),
                VaultId = denizVAID
            };

            Login denizLogin = new Login() {
                LoginId = denizLoginID,
                Username = "denizkarya1999",
                Password = "Karya99DA",
                URL = "www.denizkaryaacikbas.com",
                VaultId = denizVAID
            };

            Vault denizVault = new Vault() {
                VaultId = denizVAID,
                Name = "Deniz`s Vault",
                Lock = false,
                Mask = false,
                UserId = denizVAID
            };

            UserAccount deniz = new UserAccount() {
                UserId = denizUAID,
                Name = "Deniz",
                Surname = "Acikbas",
                Email = "dacikbas@umich.edu",
                Password = "Karya99DA",
                VaultId = denizVAID
            };

            // Add security questions and answers to the user account - Deniz Acikbas
            modelBuilder.Entity<SecurityQuestion>().HasData(
                new SecurityQuestion { Id = Guid.NewGuid(), Question = "What was the first school you went to?", Answer = "Zuhtupasha", UserAccountId = denizUAID },
                new SecurityQuestion { Id = Guid.NewGuid(), Question = "What was the first country you have ever visited?", Answer = "United Kingdom", UserAccountId = denizUAID },
                new SecurityQuestion { Id = Guid.NewGuid(), Question = "What was the name of your first pet?", Answer = "Tahrish", UserAccountId = denizUAID }
            );

            // Add passport and login credentials to vault - Deniz Acikbas
            denizVault.LoginCredentials?.Add(denizLogin);
            denizVault.Passports?.Add(denizPassport);

            //Add them into their datasets - Deniz Acikbas
            modelBuilder.Entity<UserAccount>().HasData(deniz);
            modelBuilder.Entity<Vault>().HasData(denizVault);
            modelBuilder.Entity<Passport>().HasData(denizPassport);
            modelBuilder.Entity<Login>().HasData(denizLogin);
        }
    }
}
