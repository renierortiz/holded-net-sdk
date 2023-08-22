using System.Text.Json.Serialization;

namespace Holded.Sdk.Models.Entities.RESPONSE;

/// <summary>
/// Response on contact created
/// </summary>
public class ContactCreatedResponse : BaseResponse
{
    /// <summary>
    /// Other information
    /// </summary>
    [JsonPropertyName("info")]
    public string Info { get; set; } = null!;
}