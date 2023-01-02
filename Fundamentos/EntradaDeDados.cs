using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class EntradaDeDados {
        public static void Executar() {
            
            string frase = Console.ReadLine();
            
            Console.WriteLine("Qual sabor de sorvete voçê gosta? " + frase);
        }
    }
}


/**
 * Anotações:
 * 
 * - Em definição o comando Readiline() é quando realizamos a entrada de dados
 *   podemos operar realizando algum tipo de concatenação.
 * 
 * 
 * **/
