using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Controle {
    internal class Switchs {
        public static void Executar() {
            // 1° Exemplo
            string valor = "Cristian";
            switch (valor) {
                case "Paulo": Console.WriteLine("Não é o cara!"); break;
                case "Jõao": Console.WriteLine("Não é o cara!"); break;
                case "Paloma": Console.WriteLine("Não é o cara!"); break;
                default: Console.WriteLine("Não encontrei"); break;
            }
            // 2° Exemplo;
            int day = 4;
            switch (day) {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tueday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Ansioso para final de Semana!!!"); break;
            }

        }
    }
}

/**
 * Anotações;
 * 
 * links para consulta;
 *  https://www.w3schools.com/cs/cs_switch.php
 *  
 * - O Switch avalia a expressão uma vez.
 * - O valor da expressão é comparado com os valores de cada "case"
 * - Se houver uma correspondecia, o bloco de código é executado.
 * - Executado em cascata
 * - Utilizado quando temos muitas descisões
 * - Quando o compilador atinge a palavra chave "break", ele sai do bloco.
 * - Definição da palavra "break";
 *      => Facilidade na parada de execução do restante do codigo.
 *      => Quando atinge a palavra "break", o compilador sai do bloco.
 * - Definicões da palavra - chave "Default";
 *      => Caso não encontre o valor do tipo sai no terminal o paramentro
 *         passado para "default". (Não encontrado na tela)
 * 
 * 
 * **/
