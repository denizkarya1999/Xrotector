using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Models
{
    public class SecurityQuestion
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }

        //Establish relations with UserAccount
        public Guid UserAccountId { get; set; }
        public UserAccount? UserAccount { get; set; }
    }
}
