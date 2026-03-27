#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.SourcesItem>
    {
        /// <inheritdoc />
        public override global::DoclingServe.SourcesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.ConvertDocumentsRequestSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.ConvertDocumentsRequestSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.ConvertDocumentsRequestSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DoclingServe.FileSourceRequest? file = default;
            if (discriminator?.Kind == global::DoclingServe.ConvertDocumentsRequestSourceDiscriminatorKind.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.FileSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.FileSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.FileSourceRequest)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.HttpSourceRequest? http = default;
            if (discriminator?.Kind == global::DoclingServe.ConvertDocumentsRequestSourceDiscriminatorKind.Http)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.HttpSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.HttpSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.HttpSourceRequest)}");
                http = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.S3SourceRequest? s3 = default;
            if (discriminator?.Kind == global::DoclingServe.ConvertDocumentsRequestSourceDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.S3SourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.S3SourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.S3SourceRequest)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::DoclingServe.SourcesItem(
                discriminator?.Kind,
                file,

                http,

                s3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoclingServe.SourcesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.FileSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.FileSourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.FileSourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.HttpSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.HttpSourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.HttpSourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Http, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.S3SourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.S3SourceRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.S3SourceRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3, typeInfo);
            }
        }
    }
}