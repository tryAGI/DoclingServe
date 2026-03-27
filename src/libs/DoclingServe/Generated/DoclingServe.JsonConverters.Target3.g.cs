#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace DoclingServe.JsonConverters
{
    /// <inheritdoc />
    public class Target3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoclingServe.Target3>
    {
        /// <inheritdoc />
        public override global::DoclingServe.Target3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::DoclingServe.InBodyTarget? inbody = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Inbody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.InBodyTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.InBodyTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.InBodyTarget)}");
                inbody = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.ZipTarget? zip = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Zip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.ZipTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.ZipTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.ZipTarget)}");
                zip = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.S3Target? s3 = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.S3Target), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.S3Target> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.S3Target)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::DoclingServe.PutTarget? put = default;
            if (discriminator?.Kind == global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind.Put)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.PutTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.PutTarget> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::DoclingServe.PutTarget)}");
                put = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::DoclingServe.Target3(
                discriminator?.Kind,
                inbody,

                zip,

                s3,

                put
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoclingServe.Target3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInbody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.InBodyTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.InBodyTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.InBodyTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inbody, typeInfo);
            }
            else if (value.IsZip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.ZipTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.ZipTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.ZipTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zip, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.S3Target), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.S3Target?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.S3Target).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3, typeInfo);
            }
            else if (value.IsPut)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::DoclingServe.PutTarget), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::DoclingServe.PutTarget?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::DoclingServe.PutTarget).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Put, typeInfo);
            }
        }
    }
}