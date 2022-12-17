using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Net7 {
    internal class interpolatedChain {
        public static void Executar() {
            //1° Exemplo
            var lista = new List<string>();
            var text = $@" eu quebro
                              minha linha
                              bonitinho"; // Permitido
            // 2° Exemplo
            var text3 = $"Será que eu consigo {lista
                        .Order()
                        .FirstOrDefault()}"; // Permitido
            // Nova interpolação de string com varias linhas (triplas """)
            string longMessage = """
                This is a ling message.
                It has several lines.
                some are indented
                more than others.
                Some should start at the first column.
                Some have "quoted text" in them.
                """;
            Console.WriteLine(longMessage);
            // 4° Exemplo de modelo de interpolação c#11
            int Longitude = 10;
            int Latitude = 20;
            var location = $$"""
                You are at {{{Longitude}}, {{Latitude}}}
                """;
            Console.WriteLine(location);

        }
    }
}
