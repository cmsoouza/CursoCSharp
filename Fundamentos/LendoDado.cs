using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDado {
        public static void Executar() {

            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{ nome} { idade} R${ salario}");
      
        }
    }
}

/**
 * 
 * Anotações:
 * 
 * Links para consultas:
 *   https://learn.microsoft.com/pt-br/dotnet/api/system.globalization.cultureinfo?view=net-7.0
 *   
 * - Metodo presente em todo tipo primitivo
 * - Usado para converte uma string para um tipo qualquer
 * - Ao usarmos as propriedades "CultureInfo" pegamos a execução do dado
 *   de acordo com a inserção do mesmo no console.
 * 
 * 
 * 
 * 
 * **/
