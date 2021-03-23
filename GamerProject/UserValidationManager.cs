using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if ( gamer.BrithYear == 1999 && gamer.FirstName == "Emre" && gamer.lastName == "Kara"  && gamer.IdentityNumber == 15815793818)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
