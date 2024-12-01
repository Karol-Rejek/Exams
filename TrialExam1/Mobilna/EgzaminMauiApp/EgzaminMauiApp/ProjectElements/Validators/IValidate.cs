using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp.ProjectElements.Validators
{
    internal interface IValidate
    {
        bool Validation(out string message);
    }
}
