using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class Fors {
        public static void Executar() {
            // 1° Exemplo (Decremental)
            for (int i = 5; i > 0; i--) {
                Console.WriteLine(i);
            }
            // 2° Exemplo (Incremental)
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }
            // 3° Exemplo (Usando <= e >=
            for (var i = 0; i <= 5; i++) {
                Console.WriteLine(i);
            }
            for (var i = 5; i >= 0; i--) {
                Console.WriteLine(i);
            }
        }
    }
}


/**
 * Anotações;
 * 
 * - For é usado quando sabemos a quantidade interações de antemão
 * - Tradução "Para", ou seja, para cada item um valor
 * - Executar uma determinada ação várias vezes
 * - Definido pela palavra for
 * - Exige 3 paramentros
 *      => Contador
 *      => Condição
 *      => Incremento
 * - Exemplos acima mostram como o "for" se comportam usando "operadores 
 *   comparação".
 *   Definições;
 *      => inicializador: antes de entra no loop, declaramos na variavel inicializada
 *          no loop.
 *      => A seção condição: Determina se a proxima interação do loop deve ser executada.
 *          Caso a condição for "false" o loop será encerrado.
 *      => Incremento: Defini o que acontece a cada interação do loop.
 * 
 * 
 * **/
