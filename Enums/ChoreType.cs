using System.Text.Json.Serialization;
namespace ChoreType.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreType
{ Bedroom,
  Kitchen,
  Bathroom,
  Yard,
  Pet,
}