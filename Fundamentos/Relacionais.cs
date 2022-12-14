using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Relacionais {
        public static void Executar() {

            // 1° Exemplo (Envolvendo interpolações)
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.00);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); 
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); 

            // 2° Exemplo (Mais Simples)
            Console.WriteLine("2° Exemplo, Operações Mais Simples: ");
            int x = 25;
            Console.WriteLine(x == 0); // Igual
            Console.WriteLine(x > 0); // Maior que
            Console.WriteLine(x < 0); // Menor que
            Console.WriteLine(x >= 0); // Maior ou igual
            Console.WriteLine(x <= 0); // Menor ou igual
            Console.WriteLine(x != 0); // Diferente
        }
    }
}

/**
 * Anotações:
 * 
 * Links para consultas:
 * https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/comparison-operators
 * 
 * - Podemos comparar qualquer tipo de dado, que dados são esses;
 *      => Numbers
 *      => Strings
 *      => Bytes
 * - A comparação sempre retorna True/False
 * 
 * 
 * 
 * 
 * **/
