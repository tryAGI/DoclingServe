
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// Specification for a VLM model.<br/>
    /// This defines the model configuration that is independent of the engine.<br/>
    /// It includes:<br/>
    /// - Default model repository ID<br/>
    /// - Prompt template<br/>
    /// - Response format<br/>
    /// - Engine-specific overrides
    /// </summary>
    public sealed partial class VlmModelSpec
    {
        /// <summary>
        /// Human-readable model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default HuggingFace repository ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_repo_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultRepoId { get; set; }

        /// <summary>
        /// Default model revision<br/>
        /// Default Value: main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Prompt template for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Expected response format from the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoclingServe.JsonConverters.ResponseFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DoclingServe.ResponseFormat ResponseFormat { get; set; }

        /// <summary>
        /// Set of supported engines (None = all supported)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_engines")]
        public global::System.Collections.Generic.IList<global::DoclingServe.VlmEngineType>? SupportedEngines { get; set; }

        /// <summary>
        /// Engine-specific configuration overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::DoclingServe.EngineModelConfig>? EngineOverrides { get; set; }

        /// <summary>
        /// API-specific configuration overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ApiModelConfig>? ApiOverrides { get; set; }

        /// <summary>
        /// Whether to trust remote code for this model<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_remote_code")]
        public bool? TrustRemoteCode { get; set; }

        /// <summary>
        /// Stop strings for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_strings")]
        public global::System.Collections.Generic.IList<string>? StopStrings { get; set; }

        /// <summary>
        /// Maximum number of new tokens to generate<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmModelSpec" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable model name
        /// </param>
        /// <param name="defaultRepoId">
        /// Default HuggingFace repository ID
        /// </param>
        /// <param name="revision">
        /// Default model revision<br/>
        /// Default Value: main
        /// </param>
        /// <param name="prompt">
        /// Prompt template for this model
        /// </param>
        /// <param name="responseFormat">
        /// Expected response format from the model
        /// </param>
        /// <param name="supportedEngines">
        /// Set of supported engines (None = all supported)
        /// </param>
        /// <param name="engineOverrides">
        /// Engine-specific configuration overrides
        /// </param>
        /// <param name="apiOverrides">
        /// API-specific configuration overrides
        /// </param>
        /// <param name="trustRemoteCode">
        /// Whether to trust remote code for this model<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stopStrings">
        /// Stop strings for generation
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum number of new tokens to generate<br/>
        /// Default Value: 4096
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VlmModelSpec(
            string name,
            string defaultRepoId,
            string prompt,
            global::DoclingServe.ResponseFormat responseFormat,
            string? revision,
            global::System.Collections.Generic.IList<global::DoclingServe.VlmEngineType>? supportedEngines,
            global::System.Collections.Generic.Dictionary<string, global::DoclingServe.EngineModelConfig>? engineOverrides,
            global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ApiModelConfig>? apiOverrides,
            bool? trustRemoteCode,
            global::System.Collections.Generic.IList<string>? stopStrings,
            int? maxNewTokens)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultRepoId = defaultRepoId ?? throw new global::System.ArgumentNullException(nameof(defaultRepoId));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ResponseFormat = responseFormat;
            this.Revision = revision;
            this.SupportedEngines = supportedEngines;
            this.EngineOverrides = engineOverrides;
            this.ApiOverrides = apiOverrides;
            this.TrustRemoteCode = trustRemoteCode;
            this.StopStrings = stopStrings;
            this.MaxNewTokens = maxNewTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmModelSpec" /> class.
        /// </summary>
        public VlmModelSpec()
        {
        }
    }
}