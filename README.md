# Como Utilizar Os Dados em CSharp - Parte 1

## Vamos Mergulhar em Dados e Tipos, Como Manipular Strings e Dados Numéricos.

### Nosso Caminho de Códificação

1)  Escolha o tipo de dados correto para o tipo de dados com os quais você precisa trabalhar

#### Introdução

A linguagem de programação C# depende amplamente de tipos de dados. Os tipos de dados restringem os tipos de valores que podem ser armazenados em uma determinada variável, o que pode ser útil ao tentar criar código sem erros. Como desenvolvedor, você realiza operações com segurança em suas variáveis ​​porque sabe com antecedência que armazenará apenas valores válidos.

Suponha que seu trabalho seja construir um novo aplicativo que deve recuperar, manipular e armazenar muitos tipos diferentes de dados, incluindo valores numéricos individuais e sequências de valores numéricos e de texto. A escolha dos tipos de dados corretos é fundamental para o sucesso de seus esforços de desenvolvimento de software. Mas quais são suas opções e quais critérios você deve usar ao se deparar com vários tipos de dados que parecem semelhantes? 

Neste módulo, você aprenderá como os dados são armazenados e processados ​​pelo computador. Você aprenderá que existem dois tipos de dados que correspondem às duas maneiras como os dados são processados ​​pelo computador. Você escreverá o código que identifica os valores máximos e mínimos que podem ser armazenados em um determinado tipo de dados numéricos e aprenderá os critérios que deve usar ao escolher entre vários tipos de dados numéricos para seu aplicativo.

#### Tipos de valor e tipos de referência

Com tantos tipos de dados diferentes disponíveis em C #, escolher o certo para usar significa que você precisa entender o que cada um faz e quando pode escolher um tipo de dados em vez de outro.

#### O que são dados?

Responder à pergunta "o que são dados" depende de quem você pergunta e em que contexto está perguntando.

#### E quanto aos dados textuais?

Se um computador só entende 0s e 1s, como ele nos permite trabalhar com texto? Usando um sistema como o ASCII, você pode usar um único byte para representar letras maiúsculas e minúsculas, números, tab, backspace, nova linha e muitos símbolos matemáticos, blocos, linhas e assim por diante.

#### O que é um tipo de dado?

Um tipo de dados é uma construção de linguagem de programação que define quanta memória reservar para um valor. É por isso que temos tantos tipos de dados - porque os designers da linguagem de programação entendem que ela será usada para muitos aplicativos e tamanhos de dados diferentes.

#### Tipo de valor vs. referência

Existem duas categorias básicas de tipos de dados: tipos de valor e tipos de referência. A diferença fundamental entre os tipos de valor e referência diz respeito a onde esses valores são armazenados temporariamente na memória enquanto seu aplicativo é executado. O local onde o valor é armazenado afeta o modo como o tempo de execução .NET gerencia a vida útil do valor, incluindo sua declaração (nascimento), atribuição e recuperação (vida) e finalização (morte). Isso, por sua vez, impacta a sintaxe que você usa ao trabalhar com um tipo de valor ou um tipo de referência.

#### Tipos de valor simples

Tipos de valor simples são um conjunto de tipos predefinidos fornecidos por C # como palavras-chave. Essas palavras-chave são meramente apelidos para tipos predefinidos definidos na Biblioteca de Classes .NET. Por exemplo, a palavra-chave C # int é um alias de um tipo de valor definido na biblioteca de classes .NET como System.Int32.

##### Usando as propriedades *MinValue* e *MaxValue* - Exemplo 1

```c#
Console.WriteLine("Tipos integrais assinados:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
```

##### Usando as propriedades *MinValue* e *MaxValue* - Exemplo 2

```c#
Console.WriteLine("");
Console.WriteLine("Tipos integrais sem sinal:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
```
OBS : Exclua ou comente qualquer código dos exercícios anteriores no Editor .NET

Selecione o código do exercício anterior e selecione a tecla backspace ou del. Opcionalmente, comente o código anterior no Editor .NET.

##### Usando as propriedades *MinValue* e *MaxValue* - Exemplo 3

Para ver os intervalos de valores dos vários tipos de dados, digite o código a seguir no Editor .NET.

```c#
Console.WriteLine("");
Console.WriteLine("Tipos de ponto flutuante:");

Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
```


#### Nível Iniciante :

* Conceitos C#
* Declarações, Inicialização, Variáveis
* Instruções de If-ElseIf-Else
* Matrizes, Instruções Foreach

#### Referências :
[Docs Microsoft](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)