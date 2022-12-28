using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Net7 {
    internal class ListPatterns {
        public static void Executar() {
            int[] arr1 = { 1, 2, 10 };
            int[] arr2 = { 1, 2, 5, 10 };
            int[] arr3 = { 1, 2, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(CheckSwitch(arr1));
            Console.WriteLine(CheckSwitch(arr2));
            Console.WriteLine(CheckSwitch(arr3));

            static int CheckSwitch(int[] values)
                => values switch {
                    [1, 2, .., 10] => 1,
                    [1, 2] => 2,
                    [1, _] => 3,
                    [1, ..] => 4,
                    [..] => 50
                };
        }
    }
}
