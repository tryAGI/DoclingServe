#nullable enable

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public sealed class HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind?>
    {
        /// <inheritdoc />
        public override global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
