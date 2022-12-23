using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Numbers {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal
            Console.WriteLine(valor.ToString("C")); // valor monetário
            Console.WriteLine(valor.ToString("P")); // Percentual
            Console.WriteLine(valor.ToString("#.##")); // Tipo especifico

            // Formatação especifica regional
            CultureInfo cultura = new CultureInfo("pt-BR"); // en-US
            Console.WriteLine(valor.ToString("C3", cultura));

            // Preencimento de zeros a esquerda
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            

        }
    }
}


/**
 * anotações;
 * 
 * Links para consultas;
 * https://learn.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings
 * 
 * 
 * 
 * **/
