using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                DoğumYılları = 1999,
                Adı = "Beyza",
                Soyadı = "Kesler",
                IdentityNumber = 123456
                
            });
            Console.ReadLine();
        }
    }
}
