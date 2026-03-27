
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DoclingServe.ChunkedDocumentResultItem> Chunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DoclingServe.ExportResult> Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProcessingTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkDocumentResponse" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="documents"></param>
        /// <param name="processingTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkDocumentResponse(
            global::System.Collections.Generic.IList<global::DoclingServe.ChunkedDocumentResultItem> chunks,
            global::System.Collections.Generic.IList<global::DoclingServe.ExportResult> documents,
            double processingTime)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.ProcessingTime = processingTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkDocumentResponse" /> class.
        /// </summary>
        public ChunkDocumentResponse()
        {
        }
    }
}