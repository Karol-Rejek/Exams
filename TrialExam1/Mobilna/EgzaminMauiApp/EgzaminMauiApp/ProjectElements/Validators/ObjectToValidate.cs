using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgzaminMauiApp.ProjectElements.Validators.StaticClasses;

namespace EgzaminMauiApp.ProjectElements.Validators
{
    class ObjectToValidate : IValidate
    {
        //-----------------------
        // PROPERTIES & VARIABLES
        public string ObjectName { get; set; }
        public string Value { get; set; }

        public int ValueMinRange { get; set; }
        public int ValueMaxRange { get; set; }

        //-----------------------
        // FUNCTIONS
        public bool Validation(out string message)
        {
            if (!ValidateString.ValidateValueEmpty(Value, out message)
            || !ValidateNumber.CheckIsNumber(Value, out message)
                || !ValidateNumber.CheckIsInRange(int.Parse(Value), ValueMinRange, ValueMaxRange, out message))
            {
                message = ObjectName + message;
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
