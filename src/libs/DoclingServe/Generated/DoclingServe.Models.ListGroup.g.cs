
#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// ListGroup.
    /// </summary>
    public sealed partial class ListGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SelfRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::DoclingServe.RefItem? Parent { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::DoclingServe.RefItem>? Children { get; set; }

        /// <summary>
        /// ContentLayer.<br/>
        /// Default Value: body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_layer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoclingServe.JsonConverters.ContentLayerJsonConverter))]
        public global::DoclingServe.ContentLayer? ContentLayer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::DoclingServe.BaseMeta? Meta { get; set; }

        /// <summary>
        /// Default Value: group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup" /> class.
        /// </summary>
        /// <param name="selfRef"></param>
        /// <param name="parent"></param>
        /// <param name="children">
        /// Default Value: []
        /// </param>
        /// <param name="contentLayer">
        /// ContentLayer.<br/>
        /// Default Value: body
        /// </param>
        /// <param name="meta"></param>
        /// <param name="name">
        /// Default Value: group
        /// </param>
        /// <param name="label">
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGroup(
            string selfRef,
            global::DoclingServe.RefItem? parent,
            global::System.Collections.Generic.IList<global::DoclingServe.RefItem>? children,
            global::DoclingServe.ContentLayer? contentLayer,
            global::DoclingServe.BaseMeta? meta,
            string? name,
            string? label)
        {
            this.SelfRef = selfRef ?? throw new global::System.ArgumentNullException(nameof(selfRef));
            this.Parent = parent;
            this.Children = children;
            this.ContentLayer = contentLayer;
            this.Meta = meta;
            this.Name = name;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup" /> class.
        /// </summary>
        public ListGroup()
        {
        }
    }
}