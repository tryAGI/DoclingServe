#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DoclingServe
{
    /// <summary>
    /// Specification for the type of output target.<br/>
    /// Default Value: {"kind":"inbody"}
    /// </summary>
    public readonly partial struct Target2 : global::System.IEquatable<Target2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind? Kind { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DoclingServe.InBodyTarget? Inbody { get; init; }
#else
        public global::DoclingServe.InBodyTarget? Inbody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inbody))]
#endif
        public bool IsInbody => Inbody != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DoclingServe.ZipTarget? Zip { get; init; }
#else
        public global::DoclingServe.ZipTarget? Zip { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zip))]
#endif
        public bool IsZip => Zip != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DoclingServe.S3Target? S3 { get; init; }
#else
        public global::DoclingServe.S3Target? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::DoclingServe.PutTarget? Put { get; init; }
#else
        public global::DoclingServe.PutTarget? Put { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Put))]
#endif
        public bool IsPut => Put != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target2(global::DoclingServe.InBodyTarget value) => new Target2((global::DoclingServe.InBodyTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DoclingServe.InBodyTarget?(Target2 @this) => @this.Inbody;

        /// <summary>
        /// 
        /// </summary>
        public Target2(global::DoclingServe.InBodyTarget? value)
        {
            Inbody = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target2(global::DoclingServe.ZipTarget value) => new Target2((global::DoclingServe.ZipTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DoclingServe.ZipTarget?(Target2 @this) => @this.Zip;

        /// <summary>
        /// 
        /// </summary>
        public Target2(global::DoclingServe.ZipTarget? value)
        {
            Zip = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target2(global::DoclingServe.S3Target value) => new Target2((global::DoclingServe.S3Target?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DoclingServe.S3Target?(Target2 @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public Target2(global::DoclingServe.S3Target? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target2(global::DoclingServe.PutTarget value) => new Target2((global::DoclingServe.PutTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::DoclingServe.PutTarget?(Target2 @this) => @this.Put;

        /// <summary>
        /// 
        /// </summary>
        public Target2(global::DoclingServe.PutTarget? value)
        {
            Put = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Target2(
            global::DoclingServe.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind? kind,
            global::DoclingServe.InBodyTarget? inbody,
            global::DoclingServe.ZipTarget? zip,
            global::DoclingServe.S3Target? s3,
            global::DoclingServe.PutTarget? put
            )
        {
            Kind = kind;

            Inbody = inbody;
            Zip = zip;
            S3 = s3;
            Put = put;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Put as object ??
            S3 as object ??
            Zip as object ??
            Inbody as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Inbody?.ToString() ??
            Zip?.ToString() ??
            S3?.ToString() ??
            Put?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInbody && !IsZip && !IsS3 && !IsPut || !IsInbody && IsZip && !IsS3 && !IsPut || !IsInbody && !IsZip && IsS3 && !IsPut || !IsInbody && !IsZip && !IsS3 && IsPut;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::DoclingServe.InBodyTarget?, TResult>? inbody = null,
            global::System.Func<global::DoclingServe.ZipTarget?, TResult>? zip = null,
            global::System.Func<global::DoclingServe.S3Target?, TResult>? s3 = null,
            global::System.Func<global::DoclingServe.PutTarget?, TResult>? put = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInbody && inbody != null)
            {
                return inbody(Inbody!);
            }
            else if (IsZip && zip != null)
            {
                return zip(Zip!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsPut && put != null)
            {
                return put(Put!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::DoclingServe.InBodyTarget?>? inbody = null,
            global::System.Action<global::DoclingServe.ZipTarget?>? zip = null,
            global::System.Action<global::DoclingServe.S3Target?>? s3 = null,
            global::System.Action<global::DoclingServe.PutTarget?>? put = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInbody)
            {
                inbody?.Invoke(Inbody!);
            }
            else if (IsZip)
            {
                zip?.Invoke(Zip!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsPut)
            {
                put?.Invoke(Put!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Inbody,
                typeof(global::DoclingServe.InBodyTarget),
                Zip,
                typeof(global::DoclingServe.ZipTarget),
                S3,
                typeof(global::DoclingServe.S3Target),
                Put,
                typeof(global::DoclingServe.PutTarget),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Target2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::DoclingServe.InBodyTarget?>.Default.Equals(Inbody, other.Inbody) &&
                global::System.Collections.Generic.EqualityComparer<global::DoclingServe.ZipTarget?>.Default.Equals(Zip, other.Zip) &&
                global::System.Collections.Generic.EqualityComparer<global::DoclingServe.S3Target?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::DoclingServe.PutTarget?>.Default.Equals(Put, other.Put) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Target2 obj1, Target2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Target2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Target2 obj1, Target2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Target2 o && Equals(o);
        }
    }
}
