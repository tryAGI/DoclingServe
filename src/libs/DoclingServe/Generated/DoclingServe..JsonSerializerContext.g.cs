
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
            typeof(global::DoclingServe.JsonConverters.CodeLanguageLabelJsonConverter),

            typeof(global::DoclingServe.JsonConverters.CodeLanguageLabelNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ContentLayerJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ContentLayerNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConversionStatusJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConversionStatusNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConvertDocumentsRequestSourceDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConvertDocumentsRequestSourceDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConvertDocumentsRequestTargetDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ConvertDocumentsRequestTargetDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.CoordOriginJsonConverter),

            typeof(global::DoclingServe.JsonConverters.CoordOriginNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.DoclingComponentTypeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.DoclingComponentTypeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GraphCellLabelJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GraphCellLabelNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GraphLinkLabelJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GraphLinkLabelNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GroupLabelJsonConverter),

            typeof(global::DoclingServe.JsonConverters.GroupLabelNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter),

            typeof(global::DoclingServe.JsonConverters.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ImageRefModeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ImageRefModeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.InferenceFrameworkJsonConverter),

            typeof(global::DoclingServe.JsonConverters.InferenceFrameworkNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.InputFormatJsonConverter),

            typeof(global::DoclingServe.JsonConverters.InputFormatNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.OutputFormatJsonConverter),

            typeof(global::DoclingServe.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.PdfBackendJsonConverter),

            typeof(global::DoclingServe.JsonConverters.PdfBackendNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.PictureClassificationLabelJsonConverter),

            typeof(global::DoclingServe.JsonConverters.PictureClassificationLabelNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ProcessingPipelineJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ProcessingPipelineNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ProfilingScopeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ProfilingScopeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ResponseFormatNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ScriptJsonConverter),

            typeof(global::DoclingServe.JsonConverters.ScriptNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TableFormerModeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TableFormerModeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TargetNameJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TargetNameNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TaskTypeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TaskTypeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TransformersModelTypeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TransformersModelTypeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.VlmEngineTypeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.VlmEngineTypeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.VlmModelTypeJsonConverter),

            typeof(global::DoclingServe.JsonConverters.VlmModelTypeNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.OcrEnginesEnumJsonConverter),

            typeof(global::DoclingServe.JsonConverters.OcrEnginesEnumNullableJsonConverter),

            typeof(global::DoclingServe.JsonConverters.SourcesItemJsonConverter),

            typeof(global::DoclingServe.JsonConverters.TargetJsonConverter),

            typeof(global::DoclingServe.JsonConverters.SourcesItem2JsonConverter),

            typeof(global::DoclingServe.JsonConverters.Target2JsonConverter),

            typeof(global::DoclingServe.JsonConverters.SourcesItem3JsonConverter),

            typeof(global::DoclingServe.JsonConverters.Target3JsonConverter),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.VlmConvertOptions, object, object>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.PictureDescriptionVlmEngineOptions, object, object>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.CodeFormulaVlmOptions, object, object>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.RichTableCell, global::DoclingServe.TableCell>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>),

            typeof(global::DoclingServe.JsonConverters.AnyOfJsonConverter<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>),

            typeof(global::DoclingServe.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ApiModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BaseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.SummaryMetaField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BaseVlmEngineOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmEngineType), TypeInfoPropertyName = "VlmEngineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyChunkFilesWithHierarchicalChunkerAsAsyncTaskV1ChunkHierarchicalFileAsyncPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TargetName), TypeInfoPropertyName = "TargetName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.InputFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.InputFormat), TypeInfoPropertyName = "InputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ImageRefMode), TypeInfoPropertyName = "ImageRefMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.OcrEnginesEnum), TypeInfoPropertyName = "OcrEnginesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PdfBackend), TypeInfoPropertyName = "PdfBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TableFormerMode), TypeInfoPropertyName = "TableFormerMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProcessingPipeline), TypeInfoPropertyName = "ProcessingPipeline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyChunkFilesWithHierarchicalChunkerV1ChunkHierarchicalFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyProcessFileAsyncV1ConvertFileAsyncPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.OutputFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BodyProcessFileV1ConvertFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.BoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.CoordOrigin), TypeInfoPropertyName = "CoordOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChartBar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChartLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChartPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChartSlice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChartStackedBar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChunkDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChunkedDocumentResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ChunkedDocumentResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ExportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ExportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ClearResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.CodeFormulaVlmOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmModelSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.CodeLanguageLabel), TypeInfoPropertyName = "CodeLanguageLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ContentLayer), TypeInfoPropertyName = "ContentLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConversionStatus), TypeInfoPropertyName = "ConversionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ExportDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ProfilingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProfilingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequestOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.SourcesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.SourcesItem), TypeInfoPropertyName = "SourcesItem4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.FileSourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HttpSourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.S3SourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequestSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequestSourceDiscriminatorKind), TypeInfoPropertyName = "ConvertDocumentsRequestSourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Target), TypeInfoPropertyName = "Target4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.InBodyTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ZipTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.S3Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PutTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequestTargetDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ConvertDocumentsRequestTargetDiscriminatorKind), TypeInfoPropertyName = "ConvertDocumentsRequestTargetDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureDescriptionLocal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureDescriptionApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmModelLocal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmModelApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.VlmConvertOptions, object, object>), TypeInfoPropertyName = "AnyOfVlmConvertOptionsObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.VlmConvertOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.PictureDescriptionVlmEngineOptions, object, object>), TypeInfoPropertyName = "AnyOfPictureDescriptionVlmEngineOptionsObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureDescriptionVlmEngineOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.CodeFormulaVlmOptions, object, object>), TypeInfoPropertyName = "AnyOfCodeFormulaVlmOptionsObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DescriptionAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DescriptionMetaField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DoclingComponentType), TypeInfoPropertyName = "DoclingComponentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.DocumentOrigin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.EngineModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.FineRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.FloatingMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Formatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Script), TypeInfoPropertyName = "Script2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GraphCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GraphCellLabel), TypeInfoPropertyName = "GraphCellLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProvenanceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.RefItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GraphData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.GraphCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.GraphLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GraphLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GraphLinkLabel), TypeInfoPropertyName = "GraphLinkLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GroupItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.RefItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.GroupLabel), TypeInfoPropertyName = "GroupLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HealthCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.SourcesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.SourcesItem2), TypeInfoPropertyName = "SourcesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind), TypeInfoPropertyName = "HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Target2), TypeInfoPropertyName = "Target22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind), TypeInfoPropertyName = "HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.SourcesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.SourcesItem3), TypeInfoPropertyName = "SourcesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind), TypeInfoPropertyName = "HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Target3), TypeInfoPropertyName = "Target32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind), TypeInfoPropertyName = "HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ImageRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.Size))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.InferenceFramework), TypeInfoPropertyName = "InferenceFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.InlineGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ListGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.MiscAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.MoleculeMetaField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureBarChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChartBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureClassificationClass))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureClassificationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.PictureClassificationClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureClassificationLabel), TypeInfoPropertyName = "PictureClassificationLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureClassificationMetaField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.PictureClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.PictureClassificationLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureLineChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChartLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TabularChartMetaField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureMoleculeData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PicturePieChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChartSlice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureScatterChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChartPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureStackedBarChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.ChartStackedBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PictureTabularChartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TableData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.PresignedUrlConvertDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ProfilingScope), TypeInfoPropertyName = "ProfilingScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ReadinessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.RichTableCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TableCell))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.AnyOf<global::DoclingServe.RichTableCell, global::DoclingServe.TableCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.RichTableCell, global::DoclingServe.TableCell>), TypeInfoPropertyName = "AnyOfRichTableCellTableCell2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::DoclingServe.TableCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.TableCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskProcessingMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TrackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.TransformersModelType), TypeInfoPropertyName = "TransformersModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoclingServe.VlmEngineType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DoclingServe.EngineModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::DoclingServe.ApiModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse>), TypeInfoPropertyName = "AnyOfConvertDocumentResponsePresignedUrlConvertDocumentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoclingServe.AnyOf<global::DoclingServe.ConvertDocumentResponse, global::DoclingServe.PresignedUrlConvertDocumentResponse, global::DoclingServe.ChunkDocumentResponse>), TypeInfoPropertyName = "AnyOfConvertDocumentResponsePresignedUrlConvertDocumentResponseChunkDocumentResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.InputFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.OutputFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChunkedDocumentResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ExportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.SourcesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.GraphCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.GraphLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.RefItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.SourcesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.SourcesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChartBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.PictureClassificationClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.PictureClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.PictureClassificationLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChartLine>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChartSlice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChartPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.ChartStackedBar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.DateTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.AnyOf<global::DoclingServe.RichTableCell, global::DoclingServe.TableCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::DoclingServe.TableCell>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.TableCell>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoclingServe.VlmEngineType>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}