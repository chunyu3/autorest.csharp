// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtAcronymMapping.Models
{
    public partial class ImageStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue<ImageOSDisk>(OSDisk);
            }
            if (Optional.IsCollectionDefined(DataDisks))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDisks)
                {
                    writer.WriteObjectValue<ImageDataDisk>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ZoneResilient))
            {
                writer.WritePropertyName("zoneResilient"u8);
                writer.WriteBooleanValue(ZoneResilient.Value);
            }
            writer.WriteEndObject();
        }

        internal static ImageStorageProfile DeserializeImageStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageOSDisk osDisk = default;
            IList<ImageDataDisk> dataDisks = default;
            bool? zoneResilient = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = ImageOSDisk.DeserializeImageOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImageDataDisk> array = new List<ImageDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageDataDisk.DeserializeImageDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("zoneResilient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneResilient = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ImageStorageProfile(osDisk, dataDisks ?? new ChangeTrackingList<ImageDataDisk>(), zoneResilient);
        }
    }
}
