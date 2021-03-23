using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("kayıt Başarısız, kullanıcı dğrulaması başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi.");
        }
    }
}
