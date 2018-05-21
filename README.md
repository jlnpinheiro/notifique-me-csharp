# Notifique-me! 
![Travis](https://img.shields.io/travis/USER/NotifiqueMe.svg?style=flat-square) [![NuGet](https://img.shields.io/nuget/dt/NotifiqueMe.svg?style=flat-square)](https://www.nuget.org/packages/NotifiqueMe) [![NuGet](https://img.shields.io/nuget/v/NotifiqueMe.svg?style=flat-square)](https://www.nuget.org/packages/NotifiqueMe)

Projeto que permite a utilização de maneira simples do pattern "Domain notifications". 

Esse projeto é altamente baseado no projeto **Flunt** (https://github.com/andrebaltieri/flunt). Porém a necessidade de utilizar o projeto em uma versão do .NET Standard inferior a versão 1.3 e a necessidade de traduzir para o português-BR, motivou a criação desse projeto.

## O que é isso?
Você já precisou realizar algumas validações no seu código e com elas adicionou uma grande quantidade de *"ifs"*, disparando também  *exceptions* sem necessidade?

```csharp
if (cont == 0)
    throw new Exception("Contagem não pode ser zero");
```
```csharp
if (idade < 18)
    throw new Exception("Funcionalidade proibida para menores de 18 anos.");
```
```csharp
if (!ValidaCpf("172.222.479-1a"))
    throw new Exception("CPF inválido.");
```
Cada *"if"* pode trazer complexidade no entendimento do seu código. Além disso várias dessas validações podem ocorrer por mais de uma vez. Então, por que não, substituir todas essas validações e seus *ifs* e *exceptions* desnecessários, por métodos de validações reusáveis, testáveis e **notificar** caso algo esteja errado?

Conheci esse "pattern" pelos treinamentos do [André Baltieri](https://github.com/andrebaltieri) , no site Balta.IO (http://balta.io/) e confesso que depois disso, uso *if* com muito mais sabedoria e deixo as *exceptions* para os imprevistos do dia a dia...

### Sua classe "notificável"
Para que sua classe se torne "notificável", basta herdar da classe **Notificavel** (namespace *JNogueira.Infraestrutura.NotifiqueMe*)

```csharp
using JNogueira.Infraestrutura.NotifiqueMe;

namespace StarWars
{
    public class Jedi : Notificavel
    {
       
    }
}
```
Pronto, sua classe já está preparada para utilizar notificações!

### Adicionando uma notificação
Ao herdar da classe **Notificavel**, você poderá utilizar os métodos **AdicionarNotificacao** e **AdicionarNotificacoes** para adicionar notificações.

```csharp
using JNogueira.Infraestrutura.NotifiqueMe;

namespace StarWars
{
    public class Jedi : Notificavel
    {
        public Jedi(string nome, int anosExperiencia)
        {
            if (string.IsNullOrEmpty(nome))
                this.AdicionarNotificacao("Informe seu nome, guerreiro!");

            if (anosExperiencia >= 1 && anosExperiencia <= 5)
                this.AdicionarNotificacao("Você ainda é um padawan. Finalize seu treinamento!", Dictionary<string, string> { { "Experiência", anosExperiencia.ToString() }, { "Data atual", DateTime.Today.ToShortTimeString() } });
        }
    }
}
```
### É inválido?
Toda classe **notificável** possui a propriedade **Invalido**. Existindo pelo menos uma notificação, sua classe é considerada inválida!

```csharp
var jedi1 = new Jedi("Anakin Skywalker", 1);

if (jed1.Invalido)
{
    // Eita! Temos notificações aqui, padawan!
}
```

### Exibindo as notificações
Você tem acesso a todas as notificações da classe através da propriedade **Notificacoes**.

```csharp
var jedi1 = new Jedi("Anakin Skywalker", 1);

if (jed1.Invalido)
{
    foreach (var notificacao in jedi1.Notificacoes)
    {
        Console.WriteLine($"{notificacao.Mensagem}");
    }
}
```

### Agrupando as notificações
Caso você possua mais de uma classe notificável, é possível agrupar notificações de outras classes notificáveis, através do método **AdicionarNotificacoes**. 

```csharp
class Program : Notificavel
{
    void Main(string[] args)
    {
        var jedi1 = new Jedi("Anakin Skywalker", 1);
        var jedi2 = new Jedi("Rey", 2);

        AdicionarNotificacoes(jedi1, jedi2);
    }
}
```

### Reusando validações...
Por várias vezes você precisou validar, por exemplo, uma *string* para se certificar de que ela não fosse nula ou vazia, certo? 
```csharp
...
    public Jedi(string nome, int anosExperiencia)
    {
        if (string.IsNullOrEmpty(nome))
            this.AdicionarNotificacao("Informe seu nome, guerreiro!");
        ...
    }
```
No exemplo acima, validamos apenas o parâmetro *"nome"*, porém e se fosse necessário realizar várias outras validações? Você iria fazer um CTRL+C e CTRL+V por várias vezes na linha *"if (string.IsNullOrEmpty(...))"*, certo...? 

Errado! Porque não, reusar essas validações comuns:
```csharp
...
    public Jedi(string nome, int anosExperiencia)
    {
        // if (string.IsNullOrEmpty(nome))
        //     this.AdicionarNotificacao("Informe seu nome, guerreiro!");
        
        this.NotificarSeNuloOuVazio(nome, "Informe seu nome, guerreiro!");
        ...
    }
```
No exemplo acima, caso o parâmetro *"nome"* **seja nulo ou vazio**, uma notificação é criada! Resumindo: tchau pra mais um *if*!

A classe **Noitificavel** utiliza [*extension methods*](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/extension-methods), trazendo vários tipos de validações comumente utilizadas. Veja alguns exemplos:
```csharp
this.NotificarSePossuirTamanhoSuperiorA("abc", 2, "A string 'abc' tem tamanho superior a 2.");
```
```csharp
this.NotificarSeEmailInvalido("email@invalido", "O e-mail é inválido.");
```
```csharp
this.NotificarSeMaiorOuIgualA(3, 2, "O valor 3 é maior ou igual ao valor 2.");
```
A lista de validações está disponível em https://github.com/jlnpinheiro/notifique-me-csharp/tree/master/NotifiqueMe/Validacoes. Deixe já aquele seu *pull request* para contribuir!

## Dependências
.NET Standard 1.2+

Informações sobre versões suportadas em https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

## Instalação

### NuGet
```
Install-Package NotifiqueMe
```
### .NET CLI
```
dotnet add package NotifiqueMe
```
