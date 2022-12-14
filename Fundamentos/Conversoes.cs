using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado); // Não ha perda de informações

            // Conversão explicita (Casting)
            double nota = 8.9;
            int notaTruncada = (int)nota; // Há perda de informações
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            // Converão de String para um inteiro (Parse)
            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Conversão de String para um inteiro (TryParse)
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);
            
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}



/**
 * Anotações:
 * 
 * - Algumas diferenças entre Parse e o Cast;
 *      => "Parse" somente quando queremos converte um objeto com um determinado
 *         tipo para outro. Quando não uma ligação entre eles Exemplo: Uma String
 *         para numerico.
 *      => Ja o operador Casting quando há uma ligação entre os operandos, neste caso
 *         quando temos dois tipos que estáo relacionados de alguma forma. Exemplo:
 *         "int" e "double" são tipos numericos.
 * 
 * 
 * 
 * **/