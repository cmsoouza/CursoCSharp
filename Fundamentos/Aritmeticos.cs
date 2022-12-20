using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Aritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0; //inferencia tipo double
            var impostos = 355;
            var desconto = 0.1;

            //int total = (int) preco + impostos; Conversão Explic. (Casting)
            double total = preco + impostos;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Math é metodo para operações com pontencia
            Console.WriteLine($"IMC é {imc}.");

            // Numero Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}


/**
 * Anotações:
 * 
 * Links para consultas:
 * https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators
 * 
 * - Algumas definições;
 *      => Quando realizamos a inferencia de tipos double para int teremos
 *         que realizar operação explicita (Casting), isso so ocorre quando
 *         os tipos não são compativeis.
 *      => Como ocorre em operações na matematica a multiplicação possui precedência
 *         em cima de outras operações, sem necessidade ate mesmmo de não colocarmos
 *         os parenteses.
 * 
 * 
 * 
 * 
 * 
 * **/
