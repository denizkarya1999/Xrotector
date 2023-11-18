using cis_476_project.Models.Vault_Models.ID;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class Vault
    {
        //Vault fields
        [Key]
        [Required]
        public Guid VaultId { get; set; }
        [Required]
        public string? Name { get; set;}
        [Required]
        public bool Lock { get; set;}
        public IList<CreditCard>? CreditCards { get; set; }
        public IList<Login>? LoginCredentials { get; set; }
        public IList<SecurityNote>? SecurityNotes { get; set; }
        public IList<Passport>? Passports { get; set; }
        public IList<SSN>? SSNs { get; set; }
        public IList<DriversLicense>? DriversLicenses { get; set; }
        public IList<LocalId>? localIDs { get; set; }
        [Required]
        public bool? Mask { get; set; }

        //Establish relations with User Account
        public Guid? UserId { get; set; }
        public UserAccount? UserAccount { get; set; }
    }
}
