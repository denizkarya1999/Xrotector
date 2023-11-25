using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models;

namespace Xrocter.Controllers.Processes.MaskProcess
{
    public class MaskProxy : IMask
    {
        private Mask RealMask;
        private bool Authorization;

        public MaskProxy(bool authorization)
        {
            this.RealMask = new Mask();
            this.Authorization = authorization;
        }

        public bool IsMasked
        {
            get
            {
                if (Authorization)
                {
                    return RealMask.IsMasked;
                }
                else
                {
                    // Handle authentication failure
                    return false;
                }
            }
            set
            {
                if (Authorization)
                {
                    RealMask.IsMasked = value;
                }
                else
                {
                    // Handle authentication failure
                }
            }
        }
    }
}