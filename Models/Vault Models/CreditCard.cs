using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class CreditCard
    {
        //Credit Card fields
        [Key]
        [Required]
        public Guid CardNumber { get; set; }
        [Required]
        public string? CardType { get; set; }
        [Required]
        public int? CVV { get; set; }
        [Required]
        public DateTime? IssueDate { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set;}

        //Establish relations with Credit Card
        public Guid VaultId { get; set; }
        public Vault? Vault { get; set; }
    }
}
