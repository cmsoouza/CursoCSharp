using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ConversaoExpl {
        public static void Executar() {

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; //Conversao Explicita tipo Casting
            
            Console.WriteLine(inteiroSemSinal);    
        }
    }
}

/**
 * Anotações:
 * 
 * - Algumas definições:
 *    => Ocorre quando os tipos não são compatíveis
 *    => É dado pelo uso do tipo entre parenteses antes da atribuição
 *    => Se o tipo abaixo foi negativo nao podemos declarar a conversão implicita.
 * 
 * 
 * 
 * **/
