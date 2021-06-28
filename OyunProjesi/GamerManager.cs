using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjesi
{
   

    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Oyuncu Kayıt Edildi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız oldu. Kayıt olunamadı!");
            }
             
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncı Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
