using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slug_Fest__basics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter ryu = new Fighter();
            char dum;
            while (true)
            {
                try
                {
                    dum = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    ryu.Decision(dum);
                }
                catch (FormatException)
                {
                }
            }
            ryu.Combo();
            Console.ReadKey();
        }
    }
}
