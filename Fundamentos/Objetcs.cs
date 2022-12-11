using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     internal class Objetcs {
        public static void Executar() {
            int idade = 25;
            //idade = 2.5; // erro de conversão implicita
            Console.WriteLine(idade);

            object quantidade;
            quantidade = 1;
            quantidade= 2.5; // ultima sentença a ser executada
            Console.WriteLine(quantidade);
        }
    }
}

/**
 * anotações;
 * 
 * - Algumas definições do objetc:
 *      => Seu tipo receber qualquer valor ou objeto
 *      => Não possui (intelissense) pois ser um tipo desconhecido
 *      => Evite usar em projetos sob demanda.
 * - Na sentença acima o mesmo possui erro de conversão pois nao conseguimos
 *   declarar um novo valor do tipo ponto flutuante pois seu tipo está implicito
 * 
 * 
 * 
 * 
 * **/
