using System.Net.Http.Json;
using System.Text.Json.Serialization;

const string endpoint = "https://catfact.ninja/fact";

using HttpClient httpClient = new();

try
{
    CatFactResponse? resposta = await httpClient.GetFromJsonAsync<CatFactResponse>(endpoint);

    if (resposta is null || string.IsNullOrWhiteSpace(resposta.Fact))
    {
        Console.WriteLine("Não foi possível obter um fato sobre gatos.");
        return;
    }

    Console.WriteLine("Fato sobre Gatos:");
    Console.WriteLine(resposta.Fact);
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"Erro ao acessar a Cat Fact API: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
}

internal sealed class CatFactResponse
{
    [JsonPropertyName("fact")]
    public string Fact { get; init; } = string.Empty;

    [JsonPropertyName("length")]
    public int Length { get; init; }
}
