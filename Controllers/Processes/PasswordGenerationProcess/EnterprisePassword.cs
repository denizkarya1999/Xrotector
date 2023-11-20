using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrocter.Models.Vault_Models.ID;

namespace Xrocter.Controllers.Processes.PasswordGenerationProcess
{
    public class EnterprisePassword : PasswordBuilder
    {
        private StrongPassword strongPassword = new StrongPassword();
        public override void setComplexityRank()
        {
            strongPassword.complexityRank = 2;
        }

        public override void setLength()
        {
            strongPassword.length = 8 * strongPassword.complexityRank;
        }

        public override void generatePassword()
        {
            // Make a string builder object
            StringBuilder processPassword = new StringBuilder(strongPassword.length);

            //Generate instances for the password
            string charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";
            Random random = new Random();

            // Append password
            for (int i = 0; i < processPassword.Length; i++)
            {
                processPassword.Append(charSet[random.Next(0, charSet.Length)]);
            }

            // Transform raw part into a string
            string processedPassword = processPassword.ToString();

            //Assign the new password
            strongPassword.password = processedPassword;
        }

        public override string GetPassword()
        {
            return strongPassword.password;
        }
    }
}
