
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DoclingServe
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChunkDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChunkedDocumentResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChunkedDocumentResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ExportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ExportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConversionStatus), TypeInfoPropertyName = "ConversionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ExportDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ProfilingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProfilingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DoclingComponentType), TypeInfoPropertyName = "DoclingComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DoclingDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PresignedUrlConvertDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProfilingScope), TypeInfoPropertyName = "ProfilingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskProcessingMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>), TypeInfoPropertyName = "AnyOfConvertDocumentResponsePresignedUrlConvertDocumentResponseChunkDocumentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConversionStatus?), TypeInfoPropertyName = "NullableConversionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DoclingComponentType?), TypeInfoPropertyName = "NullableDoclingComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProfilingScope?), TypeInfoPropertyName = "NullableProfilingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskType?), TypeInfoPropertyName = "NullableTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>?), TypeInfoPropertyName = "NullableAnyOfConvertDocumentResponsePresignedUrlConvertDocumentResponseChunkDocumentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChunkedDocumentResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ExportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.DateTime>))]
    internal sealed partial class TasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::DoclingServe.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::DoclingServe.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>());
            options.Converters.Add(new global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>());
            options.Converters.Add(new global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>());
            options.Converters.Add(new global::DoclingServe.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::DoclingServe.ConversionStatus)

                    || typeToConvert == typeof(global::DoclingServe.ConversionStatus?)

                    || typeToConvert == typeof(global::DoclingServe.DoclingComponentType)

                    || typeToConvert == typeof(global::DoclingServe.DoclingComponentType?)

                    || typeToConvert == typeof(global::DoclingServe.ProfilingScope)

                    || typeToConvert == typeof(global::DoclingServe.ProfilingScope?)

                    || typeToConvert == typeof(global::DoclingServe.TaskType)

                    || typeToConvert == typeof(global::DoclingServe.TaskType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DoclingServe.ConversionStatus))
                {
                    return new global::DoclingServe.JsonConverters.ConversionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.ConversionStatus?))
                {
                    return new global::DoclingServe.JsonConverters.ConversionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.DoclingComponentType))
                {
                    return new global::DoclingServe.JsonConverters.DoclingComponentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.DoclingComponentType?))
                {
                    return new global::DoclingServe.JsonConverters.DoclingComponentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.ProfilingScope))
                {
                    return new global::DoclingServe.JsonConverters.ProfilingScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.ProfilingScope?))
                {
                    return new global::DoclingServe.JsonConverters.ProfilingScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.TaskType))
                {
                    return new global::DoclingServe.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DoclingServe.TaskType?))
                {
                    return new global::DoclingServe.JsonConverters.TaskTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}