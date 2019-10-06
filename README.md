# Compilador

## Objetivo
Esse projeto tem como objetivo criar um compilador da linguagem de programação **C#** para a linguagem de programação **Python**.

## Estrutura
A estrutura desse projeto será divida em 6 fases:

**1** - `Análise Léxica` **Análise léxica** é o processo de analisar a entrada de linhas de caracteres (tal como o código-fonte de um programa de computador) e produzir uma sequência de símbolos chamado "símbolos léxicos" (lexical tokens), ou somente "símbolos" (tokens), que podem ser manipulados mais facilmente por um parser (leitor de saída).

**2** -  `Análise Sintática` O **analisador sintático** utiliza os primeiros componentes dos tokens produzidos pelo analisador léxico para criar uma representação intermediária tipo árvore.

**3** - `Análise Semântica` O **analisador semântico** utiliza a árvore de sintaxe e as informações na tabela de símbolos para verificar a consistência semântica do programa fonte com a definição da linguagem.

**4** - `Geração de Código Intermediário` A **geração de código intermediário** é a transformação da árvore de derivação em um segmento de código.
Esse código pode, eventualmente, ser o código objeto final,mas, na maioria das vezes, constitui-se num código intermediário.

**5** - `Otimização de Código` A **Otimização de Código** É uma fase independente das arquiteturas de máquina e realiza algumas transformações no
código intermediário com o objetivo de produzir um código objeto melhor.

**6** - `Geração de Código` A **Geração de Código** Mapeia a representação intermediária do código-fonte em uma linguagem objeto.

## Tecnologia
* C#
* SDK do .NET Core
```
Version:   3.0.100
Commit:    04339c3a26
```

## IDE
* Visual Studio Code
