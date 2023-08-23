using System.Text.Json.Serialization;

namespace Holded.Sdk.Entities.RESPONSE;

/// <summary>
/// Holded base response entity
/// </summary>
public class BaseResponse
{
    /// <summary>
    /// Entity created holded identifier
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Create status
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}