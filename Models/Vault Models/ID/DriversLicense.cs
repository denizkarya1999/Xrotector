using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models.Vault_Models.ID
{
    public class DriversLicense : Id
    {
        [Required]
        public string? LicenseId { get; set; }
        [Required]
        public string? AuthorityName { get; set; }
        [Required]
        public DateTime? IssuanceDate { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set; }
    }
}
