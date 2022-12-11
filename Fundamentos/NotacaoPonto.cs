using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "ola".ToUpper().Insert(3, " word!").Replace("Word!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            

        }
    }
}


/**
 * Anotações:
 * 
 *      Links para consultas:
 *      https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/null
 * 
 * - Usando a notação "." poderemos acessar a propriedade de cada metodo
 *   dentro da string.
 * 
 * 
 * **/
