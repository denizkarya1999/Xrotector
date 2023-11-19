using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.AuthenticationProcess
{
    public class Authenticator
    {
        // Create a login session
        private static Authenticator loginSession;

        //Constructor
        protected Authenticator()
        {

        }

        //Method to generate a login session
        public static Authenticator generateLoginSession()
        {
            //If no login session has been generated generate one
            if (loginSession == null)
            {
                loginSession = new Authenticator();
            }

            return loginSession;
        }
    }
}
