using Xrocter.Models.Vault_Models.ID;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Xrocter.Models
{
    public class UserAccount
    {
        //User Account fields
        [Key]
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public ICollection<SecurityQuestion>? SecurityQuestions { get; set; }

        //Establish relations with Vault
        public Guid? VaultId { get; set; }
        public Vault? Vault { get; set; }
    }
}
