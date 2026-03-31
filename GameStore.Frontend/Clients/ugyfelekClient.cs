using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class ugyfelekClient(HttpClient httpClient)
{    
    public async Task<ugyfelekSummary[]> GetugyfelekAsync() => await httpClient.GetFromJsonAsync<ugyfelekSummary[]>("ugyfelek") ?? [];

    public async Task AddugyfelAsync(ugyfelekDetails ugyfelek) => await httpClient.PostAsJsonAsync("ugyfelek", ugyfelek);
  
    public async Task<ugyfelekDetails> GetugyfelAsync(int id) => 
        await httpClient.GetFromJsonAsync<ugyfelekDetails>($"ugyfelek/{id}") 
        ?? throw new InvalidOperationException($"ugyfelek with ID {id} not found.");
    public async Task UpdateugyfelAsync(ugyfelekDetails updatedugyfelek) =>    
        await httpClient.PutAsJsonAsync($"ugyfelek/{updatedugyfelek.Id}", updatedugyfelek);
    public async Task DeleteugyfelAsync(int id) =>    
        await httpClient.DeleteAsync($"ugyfelek/{id}");    
}

