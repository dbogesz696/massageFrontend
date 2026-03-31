using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class idopontokDetails
{
public int Id { get; set; }
public int Id_massage { get; set; }
public int Id_ugyfelek { get; set; }
public  DateTime MassageIdopont { get; set; }
}
