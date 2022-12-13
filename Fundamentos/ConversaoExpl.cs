using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ConversaoExpl {
        public static void Executar() {

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; //Conversao Explicita
            
            Console.WriteLine(inteiroSemSinal);    
        }
    }
}

/**
 * 
 * - Ocorre quando seus tipos não sao compativeis
 * - É dado pelo uso do tipo entre parenteses antes da atribuição.
 * 
 * 
 * 
 * 
 * **/
