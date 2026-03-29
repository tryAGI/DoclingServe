
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DoclingServe.ExportDocumentResponse Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoclingServe.JsonConverters.ConversionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DoclingServe.ConversionStatus Status { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::DoclingServe.ErrorItem>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProcessingTime { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timings")]
        public global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ProfilingItem>? Timings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="status"></param>
        /// <param name="processingTime"></param>
        /// <param name="errors">
        /// Default Value: []
        /// </param>
        /// <param name="timings">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertDocumentResponse(
            global::DoclingServe.ExportDocumentResponse document,
            global::DoclingServe.ConversionStatus status,
            double processingTime,
            global::System.Collections.Generic.IList<global::DoclingServe.ErrorItem>? errors,
            global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ProfilingItem>? timings)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Status = status;
            this.Errors = errors;
            this.ProcessingTime = processingTime;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentResponse" /> class.
        /// </summary>
        public ConvertDocumentResponse()
        {
        }
    }
}