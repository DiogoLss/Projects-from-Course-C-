using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excessoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos.
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados - Fundamentos", LendoDados.Executar },
                {"Formatando numero - Fundamentos", FormatandoNumero.Executar }, 
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },                
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },                
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },                
                {"Operador Tarnário - Fundamentos", OperadorTernario.Executar },                
                //Estruturas de controle.
                {"Estrutura if - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura if/else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura if/elseIf - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Estrutura Usando o Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Estrutura Usando o Continue - Estruturas de Controle", UsandoContinue.Executar },
                //Classes e Métodos.
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos", GetSet.Executar },
                {"Propriedades - Classes e Métodos", Props.Executar },
                {"ReadOnly - Classes e Métodos", ReadOnly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct vs classes - Classes e Métodos", StructVsClasse.Executar },
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros por referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetro com valor padrão - Classes e Métodos", ParametroPadrao.Executar },
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
                //OO
                {"Herança - OO", Heranca.Executar },
                {"Construtor this - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar },
                {"Abstract - OO", Abstract.Executar },
                {"Interface - OO", Interface.Executar },
                {"Sealed - OO", Sealed.Executar },
                //Metodos e Funções
                {"Exemplo Lambda - Métodos & funções", ExemploLambda.Executar },
                {"Lambdas como Delegate - Métodos & funções", LambdasDelegate.Executar },
                {"Usando Delegate - Métodos & funções", UsandoDelegate.Executar },
                {"Delegates com funções anonimas - Métodos & funções", DelegateFunAnonima.Executar },
                {"Delegates como parametros - Métodos & funções", DelegatesComoParametro.Executar },
                {"Metodos de extenção - Métodos & funções", MetodosDeExtencao.Executar },
                //Excessoes
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", Excecoes.ExcecoesPersonalizadas.Executar },
                //API
                {"Primeiro arquivo - Usando API", PrimeiroArquivo.Executar },
                {"Lendo arquivos - Usando API", LendoArquivos.Executar },
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar },
                {"Diretórios - Usando API", Diretorios.Executar },
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar },
                {"Exemplo Path - Usando API", ExemploPath.Executar },
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar },
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar },
                //Tópicos Avançados
                {"LINQ1 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
                {"Genericos - Tópicos Avançados", Genericos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}