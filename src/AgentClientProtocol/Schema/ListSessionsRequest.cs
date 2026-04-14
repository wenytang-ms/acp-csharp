using System.Text.Json.Serialization;

namespace AgentClientProtocol;

public record ListSessionsRequest
{
    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}

public record ListSessionsResponse
{
    [JsonPropertyName("sessions")]
    public required SessionInfo[] Sessions { get; init; }

    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}

public record SessionInfo
{
    [JsonPropertyName("sessionId")]
    public required string SessionId { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; init; }

    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}
