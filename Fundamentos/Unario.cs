using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Unario {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            // Incremento
            numero1++;
            Console.WriteLine(numero1);
            // Decremento
            --numero1;
            Console.WriteLine(numero1);

           // Atenção!!!
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}

/**
 * Anotações;
 * 
 *  links para consultas:
 *  https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/arithmetic-operators
 * 
 * - Um operador unário possui um operador definido, ja o binário
 *   possui dois operandos definidos.
 *   
 * - Algumas definições:
 *      => Operadores unários (++/incremento), (--/decremento)...
 *      => Operador de incremento ++ incrementa seu operando 1; subdefinições:
 *          => Há duas formas de suporte desse operador (x++ Pos-fixado), (++x Pre-fixado).
 * - O que acontece nas linhas 25 a 28 é o processo de precedencia quando falamos
 *   em relação a ordem do operador, seguindo;
 *      => Quando for pos e pre-fixado ele irá executar antes a operação para depois comparar.
 *  
 * 
 * 
 * 
 * 
 * **/
