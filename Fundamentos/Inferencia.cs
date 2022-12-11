using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpx.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Cristian Souza";
            //nome = 123;
            Console.WriteLine(nome);

            var idade = 35;
            //idade = 35;
            Console.WriteLine(idade);

            int a;
            a = 1;

            int b = 2;
            Console.WriteLine(a + b);
        }
    }
}

/**
 *  anotações;
 *  
 *  links para consulta:
 *  https://pt.stackoverflow.com/questions/47383/quando-usar-var-em-c
 *  https://pt.stackoverflow.com/questions/302945/diferen%c3%a7as-entre-declara%c3%a7%c3%b5es-de-vari%c3%a1veis-em-c
 *  
 *  - Compilador em c# automaticamente inferi que o valor do tipo é uma string.
 *  - Outra situação que variaveis do tipo implicito devem ser inicializadas.
 *  - Alguns definições para não inicializar a variavel com o valor;
 *      => Neste caso temos que inferir o tipo do valor da variavel
 *      => realizando a inferencia podemos declarar na outra setença o valor da variavel
 *      => Em casos podemos realizar esse procedimento, porem para projetos reais que 
 *         usam heranças, interfaces, delegates o interessante seria a tipagem explicita dos dados.
 * 
 * 
 * 
 * 
 * 
 * **/
