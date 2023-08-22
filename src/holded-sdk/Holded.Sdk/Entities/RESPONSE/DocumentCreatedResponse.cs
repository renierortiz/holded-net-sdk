using System.Text.Json.Serialization;

namespace Holded.Sdk.Models.Entities.RESPONSE;

/// <summary>
/// Response on document created
/// </summary>
public class DocumentCreatedResponse : BaseResponse
{
    /// <summary>
    /// Other information
    /// </summary>
    [JsonPropertyName("info")]
    public string Info { get; set; } = null!;
}