namespace RASharp.Models;

using System.Text.Json.Serialization;

public record GetUserProfile
{
    [JsonPropertyName("User")]
    public required string User { get; set; }

}