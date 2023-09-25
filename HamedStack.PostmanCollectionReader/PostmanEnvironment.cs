// ReSharper disable CollectionNeverUpdated.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

using System.Text.Json;
using System.Text.Json.Serialization;

namespace PostmanCollectionV2_1_0
{
    /// <summary>
    /// Represents a Postman environment.
    /// </summary>
    public class PostmanEnvironment
    {
        /// <summary>
        /// Gets or sets the ID of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of variables in the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("values")]
        public List<PostmanEnvironmentVariable>? Variables { get; set; }

        /// <summary>
        /// Gets or sets the variable scope in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_variable_scope")]
        public string? PostmanVariableScope { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the environment was exported in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_at")]
        public DateTime? PostmanExportedAt { get; set; }

        /// <summary>
        /// Gets or sets the tool used for exporting the environment in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_using")]
        public string? PostmanExportedUsing { get; set; }
    }

    /// <summary>
    /// Represents a variable in a Postman environment.
    /// </summary>
    public class PostmanEnvironmentVariable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the variable is enabled.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the key of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("key")]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("value")]
        public string Value { get; set; } = null!;
    }

    /// <summary>
    /// Represents a Postman Collection in version 2.1.0.
    /// </summary>
    public partial class PostmanCollection2_1_0
    {
        /// <summary>
        /// Deserialize a JSON string into a PostmanEnvironment object.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A PostmanEnvironment object deserialized from the JSON string.</returns>
        public static PostmanEnvironment? EnvironmentFromJson(string json) =>
            JsonSerializer.Deserialize<PostmanEnvironment>(json);
    }
}

namespace PostmanCollectionV2_0_0
{
    /// <summary>
    /// Represents a Postman environment.
    /// </summary>
    public class PostmanEnvironment
    {
        /// <summary>
        /// Gets or sets the ID of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of variables in the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("values")]
        public List<PostmanEnvironmentVariable>? Variables { get; set; }

        /// <summary>
        /// Gets or sets the variable scope in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_variable_scope")]
        public string? PostmanVariableScope { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the environment was exported in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_at")]
        public DateTime? PostmanExportedAt { get; set; }

        /// <summary>
        /// Gets or sets the tool used for exporting the environment in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_using")]
        public string? PostmanExportedUsing { get; set; }
    }

    /// <summary>
    /// Represents a variable in a Postman environment.
    /// </summary>
    public class PostmanEnvironmentVariable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the variable is enabled.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the key of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("key")]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("value")]
        public string Value { get; set; } = null!;
    }

    /// <summary>
    /// Represents a Postman Collection in version 2.0.0.
    /// </summary>
    public partial class PostmanCollection2_0_0
    {
        /// <summary>
        /// Deserialize a JSON string into a PostmanEnvironment object.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A PostmanEnvironment object deserialized from the JSON string.</returns>
        public static PostmanEnvironment? EnvironmentFromJson(string json) =>
            JsonSerializer.Deserialize<PostmanEnvironment>(json);
    }
}

namespace PostmanCollectionV1_0_0
{
    /// <summary>
    /// Represents a Postman environment.
    /// </summary>
    public class PostmanEnvironment
    {
        /// <summary>
        /// Gets or sets the ID of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of variables in the environment.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("values")]
        public List<PostmanEnvironmentVariable>? Variables { get; set; }

        /// <summary>
        /// Gets or sets the variable scope in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_variable_scope")]
        public string? PostmanVariableScope { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the environment was exported in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_at")]
        public DateTime? PostmanExportedAt { get; set; }

        /// <summary>
        /// Gets or sets the tool used for exporting the environment in Postman.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("_postman_exported_using")]
        public string? PostmanExportedUsing { get; set; }
    }

    /// <summary>
    /// Represents a variable in a Postman environment.
    /// </summary>
    public class PostmanEnvironmentVariable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the variable is enabled.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the key of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("key")]
        public string Key { get; set; } = null!;

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("value")]
        public string Value { get; set; } = null!;
    }

    /// <summary>
    /// Represents a Postman Collection in version 1.0.0.
    /// </summary>
    public partial class PostmanCollection1_0_0
    {
        /// <summary>
        /// Deserialize a JSON string into a PostmanEnvironment object.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A PostmanEnvironment object deserialized from the JSON string.</returns>
        public static PostmanEnvironment? EnvironmentFromJson(string json) =>
            JsonSerializer.Deserialize<PostmanEnvironment>(json);
    }
}