using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class doWhiles {

        public static void Executar() {
            int valor = 0;

            do {
                Console.WriteLine(valor);
                valor++;
            } while (valor < 5);
        }

    }
}

/**
 * Anotações:
 * 
 * - Sua tradução é "faça".
 * - Definido pela palavra do/while, sempre os dois vao andar juntos como condição
 * - Checar a condição "DEPOIS" de executada.
 * 
 * **/
