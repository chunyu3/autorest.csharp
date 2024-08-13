// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm._Type.Property.Nullable
{
    // Data plane generated client.
    /// <summary> Illustrates models with nullable properties. </summary>
    public partial class NullableClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of NullableClient. </summary>
        public NullableClient() : this(new Uri("http://localhost:3000"), new NullableClientOptions())
        {
        }

        /// <summary> Initializes a new instance of NullableClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public NullableClient(Uri endpoint, NullableClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new NullableClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private String _cachedString;
        private Bytes _cachedBytes;
        private Datetime _cachedDatetime;
        private Duration _cachedDuration;
        private CollectionsByte _cachedCollectionsByte;
        private CollectionsModel _cachedCollectionsModel;
        private CollectionsString _cachedCollectionsString;

        /// <summary> Initializes a new instance of String. </summary>
        public virtual String GetStringClient()
        {
            return Volatile.Read(ref _cachedString) ?? Interlocked.CompareExchange(ref _cachedString, new String(_pipeline, _endpoint), null) ?? _cachedString;
        }

        /// <summary> Initializes a new instance of Bytes. </summary>
        public virtual Bytes GetBytesClient()
        {
            return Volatile.Read(ref _cachedBytes) ?? Interlocked.CompareExchange(ref _cachedBytes, new Bytes(_pipeline, _endpoint), null) ?? _cachedBytes;
        }

        /// <summary> Initializes a new instance of Datetime. </summary>
        public virtual Datetime GetDatetimeClient()
        {
            return Volatile.Read(ref _cachedDatetime) ?? Interlocked.CompareExchange(ref _cachedDatetime, new Datetime(_pipeline, _endpoint), null) ?? _cachedDatetime;
        }

        /// <summary> Initializes a new instance of Duration. </summary>
        public virtual Duration GetDurationClient()
        {
            return Volatile.Read(ref _cachedDuration) ?? Interlocked.CompareExchange(ref _cachedDuration, new Duration(_pipeline, _endpoint), null) ?? _cachedDuration;
        }

        /// <summary> Initializes a new instance of CollectionsByte. </summary>
        public virtual CollectionsByte GetCollectionsByteClient()
        {
            return Volatile.Read(ref _cachedCollectionsByte) ?? Interlocked.CompareExchange(ref _cachedCollectionsByte, new CollectionsByte(_pipeline, _endpoint), null) ?? _cachedCollectionsByte;
        }

        /// <summary> Initializes a new instance of CollectionsModel. </summary>
        public virtual CollectionsModel GetCollectionsModelClient()
        {
            return Volatile.Read(ref _cachedCollectionsModel) ?? Interlocked.CompareExchange(ref _cachedCollectionsModel, new CollectionsModel(_pipeline, _endpoint), null) ?? _cachedCollectionsModel;
        }

        /// <summary> Initializes a new instance of CollectionsString. </summary>
        public virtual CollectionsString GetCollectionsStringClient()
        {
            return Volatile.Read(ref _cachedCollectionsString) ?? Interlocked.CompareExchange(ref _cachedCollectionsString, new CollectionsString(_pipeline, _endpoint), null) ?? _cachedCollectionsString;
        }
    }
}
