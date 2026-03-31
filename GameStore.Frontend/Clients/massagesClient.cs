using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class massagesClient(HttpClient httpClient)
{    
    public async Task<massagesSummary[]> GetmassagesAsync() => await httpClient.GetFromJsonAsync<massagesSummary[]>("massages") ?? [];

    public async Task AddmassageAsync(massagesDetails massage) => await httpClient.PostAsJsonAsync("massage", massage);
  
    public async Task<massagesDetails> GetmassageAsync(int id) => 
        await httpClient.GetFromJsonAsync<massagesDetails>($"massage/{id}") 
        ?? throw new InvalidOperationException($"massage with ID {id} not found.");
    public async Task UpdatemassageAsync(massagesDetails updatedmassage) =>    
        await httpClient.PutAsJsonAsync($"massage/{updatedmassage.Id}", updatedmassage);
    public async Task DeletemassageAsync(int id) =>    
        await httpClient.DeleteAsync($"massage/{id}");    
}
