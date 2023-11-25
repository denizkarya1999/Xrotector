using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.MaskProcess
{
    public class Mask : IMask
    {
        public bool IsMasked { get; set; }

        public Mask()
        {
            IsMasked = true; // Initialize the mask to on by default
        }
    }
}