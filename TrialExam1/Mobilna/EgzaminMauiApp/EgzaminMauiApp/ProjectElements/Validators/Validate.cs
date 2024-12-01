using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp.ProjectElements.Validators
{
    class Validate
    {
        //-----------------------
        // FUNCTIONS
        public bool Validation(List<IValidate> toValidate, out string message)
        {
            foreach (var item in toValidate)
            {
                if (!item.Validation(out message))
                {
                    return false;
                }
            }

            message = string.Empty;
            return true;
        }

    }
}
