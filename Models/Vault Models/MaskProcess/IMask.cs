﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_476_project.Models.Vault_Models
{
    public interface IMask
    {
        public bool MaskOn { get; set; }
        public bool MaskOff { get; set; }
    }
}
