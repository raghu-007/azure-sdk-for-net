// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    public partial class V2Manifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType");
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config");
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static V2Manifest DeserializeV2Manifest(JsonElement element)
        {
            Optional<string> mediaType = default;
            Optional<Descriptor> config = default;
            Optional<IList<Descriptor>> layers = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("config"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = Descriptor.DeserializeDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Descriptor> array = new List<Descriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Descriptor.DeserializeDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new V2Manifest(Optional.ToNullable(schemaVersion), mediaType.Value, config.Value, Optional.ToList(layers));
        }
    }
}
