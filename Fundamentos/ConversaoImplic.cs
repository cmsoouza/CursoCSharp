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
