
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// DescriptionAnnotation.
    /// </summary>
    public sealed partial class DescriptionAnnotation
    {
        /// <summary>
        /// Default Value: description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provenance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAnnotation" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: description
        /// </param>
        /// <param name="text"></param>
        /// <param name="provenance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescriptionAnnotation(
            string text,
            string provenance,
            string? kind)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Provenance = provenance ?? throw new global::System.ArgumentNullException(nameof(provenance));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAnnotation" /> class.
        /// </summary>
        public DescriptionAnnotation()
        {
        }
    }
}