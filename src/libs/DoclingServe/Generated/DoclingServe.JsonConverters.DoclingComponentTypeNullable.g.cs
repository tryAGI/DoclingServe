#nullable enable

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public sealed class DoclingComponentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.DoclingComponentType?>
    {
        /// <inheritdoc />
        public override global::DoclingServe.DoclingComponentType? Read(
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
                        return global::DoclingServe.DoclingComponentTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DoclingServe.DoclingComponentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DoclingServe.DoclingComponentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoclingServe.DoclingComponentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DoclingServe.DoclingComponentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
