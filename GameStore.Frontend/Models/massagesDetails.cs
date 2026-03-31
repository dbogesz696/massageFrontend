using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class massagesDetails
{
public int Id { get; set; }
public required string MessageType { get; set; }
public int Price { get; set; }
}
