using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp.ProjectElements.Validators.StaticClasses
{
    static class ValidateNumber
    {
        //-----------------------
        // FUNCTIONS
        public static bool CheckIsNumber(string value, out string message)
        {
            int outputValue;
            if (!int.TryParse(value, out outputValue))
            {
                message = "Błędna wartość";
                return false;
            }
            message = string.Empty;
            return true;
        }

        public static bool CheckIsInRange(int value, int min, int max, out string message)
        {
            if (value < min || value > max)
            {
                message = "przekroczono zakres od " + min + " do " + max;
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
