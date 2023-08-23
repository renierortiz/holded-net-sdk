using System.Text.Json.Serialization;

namespace Holded.Sdk.Entities.GET;

public class EntityGetBase
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}