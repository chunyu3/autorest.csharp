// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The ListModelsResponse. </summary>
    public partial class ListModelsResponse
    {
        /// <summary> Initializes a new instance of <see cref="ListModelsResponse"/>. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="object"/> or <paramref name="data"/> is null. </exception>
        internal ListModelsResponse(string @object, IEnumerable<Model> data)
        {
            ClientUtilities.AssertNotNull(@object, nameof(@object));
            ClientUtilities.AssertNotNull(data, nameof(data));

            Object = @object;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListModelsResponse"/>. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        internal ListModelsResponse(string @object, IReadOnlyList<Model> data)
        {
            Object = @object;
            Data = data;
        }

        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Model> Data { get; }
    }
}
