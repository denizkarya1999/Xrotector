using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Models.Vault_Models.ID
{
    public class SSN : Id
    {
        //SSN fields
        [Required]
        public int? SSNNumber { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set;}
        [Required]
        public string? Type { get; set; }
    }
}
