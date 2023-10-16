// <auto-generated/>

#nullable disable

using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Internal;
using System.Text.Json;

namespace UnbrandedTypeSpec.Models
{
    public partial class ModelWithFormat : IUtf8JsonWriteable
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceUrl"u8);
            writer.WriteStringValue(SourceUrl.AbsoluteUri);
            writer.WritePropertyName("guid"u8);
            writer.WriteStringValue(Guid);
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
