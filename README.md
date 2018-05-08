# Notifique-me!
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
Cada *"if"* pode trazer complexidade no entendimento do seu código. Além disso várias dessas validações podem ocorrer por mais de uma vez. Então, por que não, substituir todas essas validações e seus *ifs* e *exceptions* desnecessários, por métodos de validações reuzáveis, testáveis e **notificar** caso algo esteja errado?

Conheci esse "pattern" pelos treinamentos do [André Baltieri](https://github.com/andrebaltieri) , no site Balta.IO (http://balta.io/) e confesso que depois disso, uso *if* com muito mais sabedoria e deixo as *exceptions* para os imprevistos do dia a dia...

### Sua classe "notificável"
Para que sua classe se torne "notificável", basta herdar da classe **Notificavel** (namespace *JNogueira.Infraestrutura.NotifiqueMe*)

```csharp
namespace StarWars
{
    public class Jedi : Notificavel
    {
       
    }
}
```
Pronto, sua classe já está preparada para utilizar notificações

### Adicionando uma notificação
Herdando da classe **Notificavel**, você poderá utilizar os métodos **AdicionarNotificacao** ou **AdicionarNotificacoes** para adicionar notificações!

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

            if (anosExperiencia >= 1 && anosExperiencia <=5)
                this.AdicionarNotificacao("Você ainda é um padawan. Finalize seu treinamento!", Dictionary<string, string> { { "Experiência", anosExperiencia.ToString() }, { "Data atual", DateTime.Today.ToShortTimeString() } });
        }
    }
}
```


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
