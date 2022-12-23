using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Logicos {
        public static void Executar() {
            var executouTrabalho1 = false;
            var executouTrabalho2 = true;

            Console.WriteLine("Resultado: ");
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);

        }
    }
}


/**
 * Anotações:
 * 
 * Links para consultas:
 * https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/boolean-logical-operators
 * 
 *  - Algumas definições;
 *      => && Quando os dois operando forem "true", o resultado será "verdadeiro" quando diferentes sera
 *         "falso".
 *      => || Quando somente um dos dois retornar "true", o resultado da avaliação será "verdadeiro".
 *      => ^ Neste caso quando x || y será "true" se x ou y for avaliado como "verdadeiro", caso contrário
 *           resultado será "falso".
 *      => ! negação lógica ele inverte o resultado do operando.
 *      
 *      
 *  - Tipos de operandos:
 *      => Unário (somente um operando)
 *      => Binários (Operar em cima de dois operandos)
 *      => Ternário (Operar em cima de três operandos)
 * 
 * 
 * 
 * **/
