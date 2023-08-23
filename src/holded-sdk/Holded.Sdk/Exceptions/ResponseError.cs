using System.Text.Json;

namespace Holded.Sdk.Exceptions;

public sealed class ResponseError
{
    /// <summary>General error text message.</summary>
    public string Message;

    /// <summary>Type of error.</summary>
    public string Type;

    /// <summary>Error identifier.</summary>
    public string Id;

    /// <summary>Date (UNIX timestamp).</summary>
    public long Date;

    /// <summary>Collection of field name / error description pairs.</summary>
    public Dictionary<string, string> errors;

    /// <summary>Deserializes JSON ResponseError instance.</summary>
    /// <param name="serializedResponseError">JSON-serialized ResponseError instance.</param>
    /// <returns>Returns new instance of ResponseError class or null if deserialization failed.</returns>
    public static ResponseError? FromJSON(string serializedResponseError)
    {
        try
        {
            return JsonSerializer.Deserialize<ResponseError>(serializedResponseError);
        }
        catch (Exception)
        {
            return null;
        }
    }
}