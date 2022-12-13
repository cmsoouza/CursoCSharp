using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ConversaoImplic {
        public static void Executar() {

            float valor = 25.8f;
            int outro = 25;

            valor = outro; // Conversão Implicita
            
            Console.WriteLine(valor);
        }
    }
}


/**
 * 
 * Anotações:
 * 
 * - Conversão implicita ocorre quando precisamos transformar um tipo x para tipo y.
 * - Algumas definições:
 *      => Podem ser executadas com passagem de dados
 *      => Seus tipos sao compativeis
 * - Neste caso o numero inteiro pode receber o numero real, mais ao contrario nao aceitaria.
 * 
 * 
 * 
 * 
 * **/

