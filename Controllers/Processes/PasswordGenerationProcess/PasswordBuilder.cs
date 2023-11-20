using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrocter.Controllers.Processes.PasswordGenerationProcess
{
    public abstract class PasswordBuilder
    {
        public abstract void setComplexityRank();
        public abstract void setLength();
        public abstract void generatePassword();
        public abstract string GetPassword();
    }
}
