﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.MaskProcess
{
    public interface IMask
    {
        public bool MaskOn { get; set; }
        public bool MaskOff { get; set; }
    }
}