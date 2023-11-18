using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class SecurityNote
    {
        //Security Note fields
        [Key]
        [Required]
        public Guid SecurityNoteId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }

        //Establish relations with Vault
        public Guid VaultId { get; set; }
        public Vault? Vault { get; set; }
    }
}
