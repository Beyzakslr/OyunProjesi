using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjesi
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}
