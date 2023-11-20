using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.PasswordGenerationProcess
{
    public class PasswordMaster
    {
        public void generatePassword(PasswordBuilder passwordBuilder)
        {
            passwordBuilder.setComplexityRank();
            passwordBuilder.setLength();
            passwordBuilder.generatePassword();
        }
    }
}
