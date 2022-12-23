using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Atribuição {
        public static void Executar() {
            // 1° Exemplo
            int x = 0; // Atribuição
            x += 5; // x = x + 5
            x -= 6; // x = x - 6
            x *= 10; // x = x * 10
            x /= 2; // x = x / 2
            Console.WriteLine(x);

            // 2° Exemplo
            var num1 = 7;
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2
            Console.WriteLine(num1);

            //3° Exemplo Usando Atribuição por valor (Operadores de incrementos e decremento)
            int a = 1;
            int b = a;

            a++; // a = a + 1 (Incremento)
            b--; // b = b - 1 (Decremento)
            Console.WriteLine($"{a} {b}");

            // 4° Exemplo de Atribuição por referencia
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Cristian";

            dynamic d = c;
            d.nome = "Kassia";
            Console.WriteLine(c.nome);

        }
    }
}

/**
 * Anotações;
 * 
 * Link para consultas;
 * https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators
 * 
 *   Definições;
 *     => Ainda no 3° exemplo temos o exemplo de incremento/decremento na
 *        operação interpolando dentro do Console().
 *     => No 4° Exemplo operamos as variaveis com o metodo de atribuição por
 *        por referencia. Isso quer dizer as variaveis compartilham o mesmo
 *        valor.
 *     => A sentença new System.Dynamic.ExpandoObject(), cria uma nova estância
 *        da classe "ExpandoObject".
 * 
 * 
 * 
 * **/
