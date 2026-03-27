#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public class SourcesItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.SourcesItem3>
    {
        /// <inheritdoc />
        public override global::DoclingServe.SourcesItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DoclingServe.FileSourceRequest? file = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.FileSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.FileSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.FileSourceRequest)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.HttpSourceRequest? http = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.Http)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.HttpSourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.HttpSourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.HttpSourceRequest)}");
                http = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.S3SourceRequest? s3 = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.S3SourceRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.S3SourceRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.S3SourceRequest)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::DoclingServe.SourcesItem3(
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
            global::DoclingServe.SourcesItem3 value,
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