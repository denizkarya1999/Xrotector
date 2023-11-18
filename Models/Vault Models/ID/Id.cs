using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class Id
    {
        //Id fields
        [Key]
        [Required]
        public Guid Id_key { get; set; }
        [Required]
        public string? Id_Name { get; set; }

        //Establish relations with Vault
        public Guid VaultId { get; set; }
        public Vault? Vault { get; set; }
    }
}
