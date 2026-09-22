# Consumer Cat Fact API - .NET Console

Aplicação console em C# que consome a [Cat Fact API](https://catfact.ninja/) e exibe um fato aleatório sobre gatos.

## Tecnologias

- C#
- .NET 8
- `HttpClient`
- `System.Net.Http.Json`

## Endpoint utilizado

```text
https://catfact.ninja/fact
```

## Como executar

É necessário ter o [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.

```bash
dotnet run
```

## Exemplo de saída

Como a API retorna um fato aleatório, o conteúdo pode mudar a cada execução.

```text
Fato sobre Gatos:
Many cats cannot properly digest cow's milk. Milk and milk products give them diarrhea.
```
