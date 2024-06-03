using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Errors
{
    public class FormatInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an incorrectly formatted input. This fired an error!";
        }
    }
}
