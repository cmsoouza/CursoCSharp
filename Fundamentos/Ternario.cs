using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Ternario {
        public static void Executar() {
            var nota = 6.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }

    }
}

/**
 * Anotações;
 * 
 *  Links para consultas:
 *  https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator
 * 
 * - Algumas definições importantes:
 *      => Podemos ter varias condições dentro da sentença da condição ternária antes do resultado
 *      => Precisamos tomar cuidado com a inferencia de valores para nao interferir no resultado
 *         da condição.
 * 
 * 
 * **/
