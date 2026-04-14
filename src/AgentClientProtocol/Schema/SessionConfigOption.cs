using System.Text.Json;
using System.Text.Json.Serialization;

namespace AgentClientProtocol;

/// <summary>
/// A configuration option exposed by the agent.
/// </summary>
public record SessionConfigOption
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("label")]
    public required string Label { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("category")]
    public string? Category { get; init; }

    [JsonPropertyName("value")]
    public JsonElement? Value { get; init; }

    [JsonPropertyName("options")]
    public SessionConfigOptionChoice[]? Options { get; init; }

    [JsonPropertyName("_meta")]
    public Dictionary<string, object>? Meta { get; init; }
}

public record SessionConfigOptionChoice
{
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonPropertyName("label")]
    public required string Label { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }
}
