using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class Login
    {
        //Login fields
        [Key]
        [Required]
        public Guid LoginId { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? URL { get; set; }

        //Establish relations with Vault
        public Guid VaultId { get; set; }
        public Vault? Vault { get; set; }
    }
}
