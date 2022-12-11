using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Fundamentos {
    class Comentarios {
        public static void Executar() {
            Console.WriteLine("Código claro é sempre melhor!");
            // comentario de uma linha
            /// <summary
            /// 
            /// </summary
            /// 
            /**
             * 
             * Esse é um comentario
             * de multiplas linhas
             * 
             * **/
            Console.WriteLine("O C# tem o XML Comments");

        }

    }
}


/**
 *  Anotações;
 *      Link para consultas:
 *      https://pt.stackoverflow.com/questions/153813/existe-uma-forma-correta-de-comentar-um-trecho-de-c%C3%B3digo
 * 
 * - Cuidado com comentarios desnecessarios
 * - Comentarios podem ser divididos;
 *      => Uma linha
 *      => Multiplas linhas
 *      => XML (METADAS)
 * - Algumas regras para comentarios sao necessarios
 * - Nnumca comente muito sobre tao coisa, seja direto e definitivo.
 * 
 * 
 * 
 * **/
