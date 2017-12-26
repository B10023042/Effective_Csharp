using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCsharp._01
{
    class Number
    {
        void Define()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine(total);
        }
        private static int GetMagicNumber()
        {
            return 1;
        }
    }
}
