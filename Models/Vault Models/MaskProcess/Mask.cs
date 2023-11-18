using cis_476_project.Models.Vault_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models
{
    public class Mask : IMask
    {
        public bool mask;

        public Mask() { }
        public bool MaskOn { get; set; }
        public bool MaskOff { get; set; }
    }
}
