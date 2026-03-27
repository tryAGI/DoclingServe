
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HybridChunkerOptionsDocumentsRequestSourceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoclingServe.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter))]
        public global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestSourceDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HybridChunkerOptionsDocumentsRequestSourceDiscriminator(
            global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestSourceDiscriminator" /> class.
        /// </summary>
        public HybridChunkerOptionsDocumentsRequestSourceDiscriminator()
        {
        }
    }
}