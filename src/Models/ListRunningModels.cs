using System;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace OllamaSharp.Models;

/// <summary>
/// List models that are currently loaded into memory.
///
/// <see href="https://github.com/ollama/ollama/blob/main/docs/api.md#list-running-models">Ollama API docs</see>
/// </summary>
[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Skip)]
public class ListRunningModelsResponse
{
	/// <summary>
	/// An array of running models.
	/// </summary>
	[JsonPropertyName("models")]
	public RunningModel[] RunningModels { get; set; } = null!;
}

/// <summary>
/// Represents a running model.
/// </summary>
[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Skip)]
[DebuggerDisplay("{Name}")]
public class RunningModel : Model
{
	/// <summary>
	/// The amount of vram (in bytes) used by the model.
	/// </summary>
	[JsonPropertyName("size_vram")]
	public long SizeVram { get; set; }

	/// <summary>
	/// The time the model will be unloaded from memory.
	/// </summary>
	[JsonPropertyName("expires_at")]
	public DateTime ExpiresAt { get; set; }
}