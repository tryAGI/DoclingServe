
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// Metadata model for pictures.
    /// </summary>
    public sealed partial class PictureMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::DoclingServe.SummaryMetaField? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::DoclingServe.DescriptionMetaField? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        public global::DoclingServe.PictureClassificationMetaField? Classification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("molecule")]
        public global::DoclingServe.MoleculeMetaField? Molecule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tabular_chart")]
        public global::DoclingServe.TabularChartMetaField? TabularChart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMeta" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        /// <param name="classification"></param>
        /// <param name="molecule"></param>
        /// <param name="tabularChart"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PictureMeta(
            global::DoclingServe.SummaryMetaField? summary,
            global::DoclingServe.DescriptionMetaField? description,
            global::DoclingServe.PictureClassificationMetaField? classification,
            global::DoclingServe.MoleculeMetaField? molecule,
            global::DoclingServe.TabularChartMetaField? tabularChart)
        {
            this.Summary = summary;
            this.Description = description;
            this.Classification = classification;
            this.Molecule = molecule;
            this.TabularChart = tabularChart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMeta" /> class.
        /// </summary>
        public PictureMeta()
        {
        }
    }
}