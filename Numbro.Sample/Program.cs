using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbro.Sample {
    class Program {
        static void Main(string[] args)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine(number.ToWords());
            Console.ReadLine();
        }
    }
}
