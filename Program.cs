﻿using System;
using System.Collections.Generic;
using Csharp.Fundamentos;
using CursoCSharp.Fundamentos;
using CursoCSharp.Net7;
using CursoCSharpx.Fundamentos;
using CursoCSharp.Controle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Fundamentos C# - Fundamentos", estrutura.Executar},
                {"Fundamentos C# - Comentários", Comentarios.Executar},
                {"Fundamentos C# - Variaveis e Const", VariaveisEConst.Executar},
                {"Fundamentos C# - Inferencia", Inferencia.Executar},
                {"Fundamentos C# - Interpolação", Interpolacao.Executar},
                {"Fundamentos C# - Using Sytem", Systems.Executar},
                {"Fundamentos C# - Objetc", Objetcs.Executar},
                {"Fundamentos C# - Alias", Alias.Executar},
                {"Fundamentos C# - Notação Ponto", NotacaoPonto.Executar},
                {"Fundamentos C# - Conversão Implicita", ConversaoImplic.Executar},
                {"Fundamentos C# - Conversão Explicita", ConversaoExpl.Executar},
                {"Fundamentos C# - Conversão Lendo Dado Console", LendoDado.Executar},
                {"Fundamentos C# - Convert", Converts.Executar},
                {"Fundamentos C# - Conversões", Conversoes.Executar},
                {"Fundamentos C# - Operadores Aritméticos", Aritmeticos.Executar},
                {"Fundamentos C# - Operadores Relacionais", Relacionais.Executar},
                {"Fundamentos C# - Operadores Atribuição", Atribuição.Executar},
                {"Fundamentos C# - Operadores Lógicos", Logicos.Executar},
                {"Fundamentos C# - Operadores Unários", Unario.Executar},
                {"Fundamentos C# - Operadores Ternários", Ternario.Executar},
                {"Fundamentos C# - Formatando Numeros", Numbers.Executar},
                // Migrando para dotnet7 e c#11
                {"New Feature .net7 - Interpolação Chain", interpolatedChain.Executar},
                {"New Feature .net7 - List Patterns", ListPatterns.Executar},
                // Estrutura de Controle
                {"Estrutura de Controle - if", Estruturaif.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}