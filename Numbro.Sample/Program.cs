using System;

namespace Numbro.Sample {
    internal class Program {
        private static void Main() {
            string input;
            do {
                input = Console.ReadLine ();
                int number;
                Console.WriteLine (int.TryParse (input, out number)
                    ? number.ToWords ()
                    : "not a valid number");
            } while (!string.IsNullOrWhiteSpace (input));

            Console.ReadLine ();
        }
    }
}