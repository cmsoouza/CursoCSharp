using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpx.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Interpolação
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Usando variaveis para interpolação
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);
            
            // Usando o $ para interpolar os indices
            Console.WriteLine($"A marca {marca} é legal!");

            // Interpolação operando em operações aritmeticas
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
