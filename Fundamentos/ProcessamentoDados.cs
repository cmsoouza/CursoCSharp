using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ProcessamentoDados {
        public static void Executar() {
            // Exemplo 1
            int a, b;
            double resultado;
            a = 5;
            b = 2;

            //resultado = a / b;
            resultado = (double) a / b; // Casting
            Console.WriteLine(resultado);

            // Exemplo 2
            int x, y;
            x = 5;
            y = 2 * x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            // Exemplo 3
            double c, B, h, area;
            c = 6.0;
            B = 8.0;
            h = 5.0;

            area = (c + B) / 2.0 * h;
            //Console.WriteLine(area);

            // Exemplo 4°
            float d, E, g;
            d = 6f;
            E = 8f;
            g = 5f;

            area = (d + E) / 2f * g;
            //Console.WriteLine(area);
        }
    }
}


/**
 * Anotações;
 * 
 * - Percebemos que nos dois exemplos podemos declarar
 *   operações sempre criando variaveis/expressão.
 * 
 * - Por regra;
 *      => A expressão e calculada
 *      => O resultado da expressão é armazenamento na variavel.
 *      
 * - No 3° Exemplo, vejamos algumas definições;
 *      => Sempre indique o tipo do numero, se a expressão
 *         for ponto flutuante (não inteira).
 *      => Para double indique "0"
 *      => Para float indique  "f"
 * 
 * - No exemplo 1° possuimos o exemplo de "cast", quando á mudança
 *   de um tipo para outro de forma explícita através do operador
 *   casting (o nome do tipo entre parenteses).
 *      
 * 
 * 
 * 
 * 
 * **/
