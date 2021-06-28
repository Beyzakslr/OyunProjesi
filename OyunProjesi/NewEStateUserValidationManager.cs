using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjesi
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
