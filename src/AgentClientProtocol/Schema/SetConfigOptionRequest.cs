using System.Text.Json.Serialization;

namespace AgentClientProtocol;

public record SetConfigOptionRequest
{
    [JsonPropertyName("sessionId")]
    public required string SessionId { get; init; }

    [JsonPropertyName("configOptionId")]
    public required string ConfigOptionId { get; init; }

    [JsonPropertyName("value")]
    public required object Value { get; init; }

    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}

public record SetConfigOptionResponse
{
    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}
