using System;
using System.Collections.Generic;
using Csharp.Fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharpx.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", estrutura.Executar},
                {"Primeiro Programa - Comentários", Comentarios.Executar},
                {"Primeiro Programa - Variaveis e Const", VariaveisEConst.Executar},
                {"Primeiro Programa - Inferencia", Inferencia.Executar},
                {"Primeiro Programa - Interpolação", Interpolacao.Executar},
                {"Primeiro Programa - Using Sytem", Systems.Executar},
                {"Primeiro Programa - Objetc", Objetcs.Executar},
                {"Primeiro Programa - Alias", Alias.Executar},
                {"Primeiro Programa - Notação Ponto", NotacaoPonto.Executar},
                {"Primeiro Programa - Conversão Implicita", ConversaoImplic.Executar},
                {"Primeiro Programa - Conversão Explicita", ConversaoExpl.Executar},
                {"Primeiro Programa - Conversão Lendo Dado Console", LendoDado.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}