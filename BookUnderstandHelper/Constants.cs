using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUnderstandHelper
{
    class Constants
    {
        private const string mySeparators = " \n\t!?@#$\\/%^&*()<>,.{}[]\"";
        public static char[] separators
        {
            get { return mySeparators.ToCharArray(); }
        }
    }
}
