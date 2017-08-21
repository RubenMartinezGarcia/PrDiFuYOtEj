using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var H = 0;
            var M = 0;
            var S = 0;
            while (H < 24)
            {
                S += 1;
                if (S == 60)
                {
                    S = 0;
                    M += 1;
                }
                if (M == 60)
                {
                    M = 0;
                    H += 1;
                }
                if (H == 24)
                {
                    H = 0;
                    Console.ReadLine();
                }
                Console.WriteLine("La hora actual es: " + H + ":" + M + ":" + S);
            }
        }
    }
}
