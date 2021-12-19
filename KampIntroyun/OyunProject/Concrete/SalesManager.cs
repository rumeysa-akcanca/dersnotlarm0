using OyunProject.Abstract;
using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Concrete
{
   public class SalesManager
    {
        public void BuyGame(Member member,Games game)
        {
            Console.WriteLine($"{game.Name} adlı oyunu {member.FirstName+""+member.LastName}" +
                $" adlı kullanıcıdan satın aldınız.");
        }
    }
}
