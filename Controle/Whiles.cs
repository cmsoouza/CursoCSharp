using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class Whiles {
        public static void Executar() {
            // 1° Incremento abaixo
            // Conta de 0 a 5
            // Exibi de 0 a 5 na tela
            int valor = 0;
            while (valor <= 5) {
                Console.WriteLine(valor);
                valor++; 
            }
            // 2° Incremento Acima do console
            // Conta de 0 a 5
            // Exibi de 1 a 6 na tela
            valor= 0;
            while (valor <= 5) {
                valor++;
                Console.WriteLine(valor);
            }

            // 3° Exemplo utilizando contagem infinita
            int valor2 = 0;
            // Infinito
            while(true) { // True nunca será false kkk
                valor2++;
                //Console.WriteLine(valor);
            }

        }
    }
}

/**
 * Anotações:
 * 
 * - While é usado quando não sabemos exatamente quantas interações serão feitas
 * - Posição do incremento na tela;
 *      => Acima do console exibe de 1 a 6
 *      => Abaixo do console exibe de 0 a 5
 * - Tradução "Enquanto", ou seja, enquanto uma condição for verdadeira...
 * - Definido pela palavra "while"
 * - Exige apenas uma condição
 * - Checa a condição ANTES de executar
 * - Caso nao haja incremento no valor o mesmo irá executar o loop infinitavamente
 * 
 * 
 * 
 * **/
