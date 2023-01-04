using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class EntradaDeDados {
        public static void Executar() {
            // 1° Exemplo;
            string frase = Console.ReadLine();

            Console.WriteLine("Qual sabor de sorvete voçê gosta? " + frase);


            // 2° Exemplo;
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Voçê digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture)); // para retorno do inteiro com "."

            // 3° Exemplo
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}


/**
 * Anotações:
 * 
 * - Em definição o comando Readiline() é quando realizamos a entrada de dados
 *   podemos operar realizando algum tipo de concatenação.
 *   
 * - Readline por si retornar uma string, vejamos alguns erros que podem comprometer
 *   aplicação;
 *      => Quando não usamos o "Parse" nao conseguimos converte um "int" para "string".
 *      => Precisamos declarar o tipo para qual queremos converter para "string".
 *         
 * - No segundo exemplo quando inserimos no terminal numero com "." utilizaremos
 *   using Globalization. Quando o retorno no terminal aceite o ponto que digitamos
 *   no readline precisamos declarar na variavel a mesma propriedade "CultureInfo".
 *   
 * - Outra função importante é inserirmos a função "ToString" para converter um dado
 *   de um tipo que não é string. Assim utilizamos a formatação para retorna as casas
 *   decimais usando ("F2" = 2 CASAS DECIMAIS e assim por diante ....)
 *   
 * - 3° Exemplo teremos que armazenar utilizando o metodo "Split()" para cada vetor
 *   usado usando o conceito de arrays.
 *      => Algumas conversoes sao necessárias nesse exemplo;
 *          ==> l'31 Utilizando parse para converter em string
 *          ==> l'32 O mesmo conceito para transformar "int" em uma "string"
 * 
 * 
 * **/
