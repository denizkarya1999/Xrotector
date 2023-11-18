using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models.Vault_Models.ID
{
    public class LocalId : Id
    {
        //LocalId fields
        [Required]
        public string? LocalIdNumber { get; set; }
        [Required]
        public string? LocalAuthority { get; set; }
    }
}
