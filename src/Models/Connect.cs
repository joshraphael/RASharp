namespace RASharp.Models;

using System.Text.Json.Serialization;

public record GetCodeNotes
{
    [JsonPropertyName("Success")]
    public required bool Success { get; set; }

    [JsonPropertyName("CodeNotes")]
    public required GetCodeNotesCodeNote[] CodeNotes { get; set; }

}

public record GetCodeNotesCodeNote
{
    [JsonPropertyName("User")]
    public required string User { get; set; }

    [JsonPropertyName("Address")]
    public required string Address { get; set; }

    [JsonPropertyName("Note")]
    public required string Note { get; set; }
}