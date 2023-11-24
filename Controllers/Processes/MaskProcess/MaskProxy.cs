using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Xrocter.Controllers.Processes.MaskProcess
{
    public class MaskProxy : IMask
    {
        private Mask realMask;
        private UserAccount user;

        public MaskProxy(UserAccount user)
        {
            this.realMask = new Mask();
            this.user = user;
        }

        public bool IsMasked
        {
            get
            {
                if (user.IsAuthorized())
                {
                    return realMask.IsMasked;
                }
                else
                {
                    // Handle authentication failure
                    return false;
                }
            }
            set
            {
                if (user.IsAuthorized())
                {
                    realMask.IsMasked = value;
                }
                else
                {
                    // Handle authentication failure
                }
            }
        }
    }
}
