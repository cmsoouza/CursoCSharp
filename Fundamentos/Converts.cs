using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Converts {
        public static void Executar() {
            int inteiro = Convert.ToInt32("100");
            Console.WriteLine(inteiro);
        }
    }
}

/**
 * Anotações:
 * 
 * Links para consultas:
 * https://learn.microsoft.com/pt-br/dotnet/api/system.convert?view=net-7.0
 * 
 * - Similar ao Parse ele permite converter varios tipos
 * - Devemos informar o tipo na chamada da conversão.
 * 
 * 
 * 
 * 
 * **/
