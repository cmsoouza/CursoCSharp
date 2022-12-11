using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Fundamentos {
    class VariaveisEConst {
        public static void Executar() {
            // Area da cicuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_6_000_000;
            Console.WriteLine("Tamanho da População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            //Valores reais
            float precoComputador = 1299.9f;
            Console.WriteLine("O preço do Computador é " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000.00;
            Console.WriteLine("Valor da Apple " + valorDeMercadoDaApple);

            char letra = 'b';
            Console.WriteLine("A letra é " + letra);

            string texto = "Minha esposa Kassia, cheirosa e lindona!!!";
            Console.WriteLine("Gatinha é " + texto);
        }
    }
}

/**
 * Anotações;
 * 
 * Links para consultas;
 * https://www.w3schools.com/cs/cs_data_types.php
 * 
 * - Int é um tipo muito usado em codigo c#
 * - Numeros que precisam de uma maior precisao, ou seja, com pontuação
 *   float usamos o sufixo (f)
 * - o char é ultilizado para armazena apenas um caracter no formato unicode.
 * - Strings armazena uma cadeia de caracteres, segue definições;
 *      => Podemos pensar nele como uma lista de char
 *      => A definição de uma string pode ser dada por aspas duplas (" ")
 * - Var e suas definições;
 *      => Substitui o nome do tipo
 *      => Será do tipo do primeiro valor atribuido
 *      => Recomendado o uso, porem com cuidados somente quando dominar os tipos.
 * 
 *  (Outros aprofundamentos buscar no material de apoio) 
 * 
 * **/
