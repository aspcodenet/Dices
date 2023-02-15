using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices
{
    internal class App
    {
        public string GetTwoOfSameString(int tal)
        {
            if (tal == 1)
                return "ettor";
            else if (tal == 2)
                return "tvåor";
            else if (tal == 3)
                return "treor";
            else if (tal == 4)
                return "fyror";
            else if (tal == 5)
                return "femmor";
            else if (tal == 6)
                return "sexor";
            else
                return null;
        }
        public void Run()
        {
            var random = new Random();
            var tal1 = random.Next(1, 7);
            var tal2 = random.Next(1, 7);

            if (tal1 == tal2)
            {
                var twoOfSame = GetTwoOfSameString(tal1);

                Console.WriteLine($"Du fick två {twoOfSame}");
            }
            else
            {

            }

        }
    }
}
