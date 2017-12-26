using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCsharp._01
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine(
                $"Declared Type:{total.GetType().Name},Value:{total}");
            Console.ReadLine();
        }
        private static double GetMagicNumber()
        {
            return 1;
        }
    }
}
