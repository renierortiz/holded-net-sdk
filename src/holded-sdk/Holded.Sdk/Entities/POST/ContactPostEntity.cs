using System.Text.Json.Serialization;

namespace Holded.Sdk.Models.Entities.POST;

/// <summary>
/// Contact entity to post 
/// </summary>
public class ContactPostEntity : HoldedEntity
{
    /// <summary>
    /// Custom identifier.
    /// </summary>
    public string CustomId { get; set; } = null!;

    /// <summary>
    /// Contact name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Contact code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = null!;

    /// <summary>
    /// Contact email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// Contact mobile.
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// Contact phone.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <summary>
    /// Contact bill address.
    /// </summary>
    [JsonPropertyName("billAddress")]
    public AddressEntity? BillAddress { get; set; }

    /// <summary>
    /// If contact is an a person.
    /// </summary>
    [JsonPropertyName("isPerson")]
    public bool IsPerson { get; set; }
}