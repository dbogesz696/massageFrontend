using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class ugyfelekSummary
{
public int Id { get; set; }
public required string Nev { get; set; } 
public required string TelefonSzam { get; set; } 
}
