using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class idopontokClient(HttpClient httpClient)
{    
    public async Task<idopontokSummary[]> GetidopontokAsync() => await httpClient.GetFromJsonAsync<idopontokSummary[]>("idopontok") ?? [];

    public async Task AddidopontokAsync(idopontokDetails idopontok) => await httpClient.PostAsJsonAsync("idopontok", idopontok);
  
    public async Task<idopontokDetails> GetIdopontAsync(int id) => 
        await httpClient.GetFromJsonAsync<idopontokDetails>($"idopontok/{id}") 
        ?? throw new InvalidOperationException($"idopontok with ID {id} not found.");
    public async Task UpdateidopontokAsync(idopontokDetails updatedidopontok) =>    
        await httpClient.PutAsJsonAsync($"idopontok/{updatedidopontok.Id}", updatedidopontok);
    public async Task DeleteidopontokAsync(int id) =>    
        await httpClient.DeleteAsync($"idopontok/{id}");    
}
