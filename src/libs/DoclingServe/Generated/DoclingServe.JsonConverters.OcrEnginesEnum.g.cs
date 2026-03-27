#nullable enable

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public sealed class OcrEnginesEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.OcrEnginesEnum>
    {
        /// <inheritdoc />
        public override global::DoclingServe.OcrEnginesEnum Read(
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
                        return global::DoclingServe.OcrEnginesEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DoclingServe.OcrEnginesEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DoclingServe.OcrEnginesEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoclingServe.OcrEnginesEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DoclingServe.OcrEnginesEnumExtensions.ToValueString(value));
        }
    }
}
