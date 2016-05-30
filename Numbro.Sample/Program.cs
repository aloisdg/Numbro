using System;

namespace Numbro.Sample {
    internal class Program {
        private static void Main() {
            for (var input = Console.ReadLine (); !string.IsNullOrWhiteSpace (input); input = Console.ReadLine ()) {
                int number;
                Console.WriteLine (int.TryParse (input, out number)
                       ? number.ToWords ()
                    : "not a valid number");
            }

            Console.ReadLine ();
        }
    }
}