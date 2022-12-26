using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class Estruturaif {
        public static void Executar() {
            // 1° Exemplo
            int idade = 18;
            int maioridade = 21;
            int idadeMaxima = 65;

            if (idade >= maioridade && idade < idadeMaxima) {
                Console.WriteLine("É Diferente");
            } else {
                Console.WriteLine("É igual");
            }
            Console.WriteLine("Finalizou o programa!!!");


            // 2° Exemplo
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada= Console.ReadLine();

            //if(entrada == "S" || entrada == "s")
            //    bomComportamento= true;

            //bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s"; // Sentença mais simplificada

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
        }

    }
}

/**
 * Anotações:
 * 
 * - Quando possuimos mais de uma linha de codigo temos que colocar
 *   as chaves. O que pode ocorre na linha '33/24
 *   
 * - Algumas nuancias que pode acontecer é declarar um ";" dentro de um
 *   bloco if. Pois ele ";" é uma sentença vazia é pode quebrar o codigo.
 *   (cenário pode ocorre no bloco if entre as linhas '40/42)
 *   
 * - Quando queremos comparar e analisar se realmente a variavel é verdadeiro
 *   ou falso, podemos usar o operador de ("!")negação logica sem a necessidade de 
 *   declarar implicitamente "true/false". O que ocorre na linha '36.
 * 
 * **/
