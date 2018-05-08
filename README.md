# Notifique-me!
Projeto que permite a utilização de maneira simples do pattern "Domain notifications". 

Esse projeto é altamente baseado no projeto **Flunt** (https://github.com/andrebaltieri/flunt). Porém a necessidade de utilizar o projeto em uma versão do .NET Standard inferior a versão 1.3 e a necessidade de traduzir para o português-BR, motivou a criação desse projeto.

## Notificando...
Você já precisou realizar algumas validações no seu código e com elas adicionou uma grande quantidade de "ifs"?

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





### Sua classe "notificável"
Para que sua classe se torne "notificável", basta que herdar da classe **Notificavel** (namespace *JNogueira.Infraestrutura.NotifiqueMe*)

```csharp
using JNogueira.Infraestrutura.NotifiqueMe;

namespace Notificacoes.Testes
{
    public class Classe1 : Notificavel
    {

    }
}
```
Pronto, sua classe já está preparada para utilizar notificações
