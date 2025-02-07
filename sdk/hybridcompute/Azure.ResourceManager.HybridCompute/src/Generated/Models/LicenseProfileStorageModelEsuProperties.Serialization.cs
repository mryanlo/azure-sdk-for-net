// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class LicenseProfileStorageModelEsuProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static LicenseProfileStorageModelEsuProperties DeserializeLicenseProfileStorageModelEsuProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> assignedLicenseImmutableId = default;
            Optional<IReadOnlyList<EsuKey>> esuKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignedLicenseImmutableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicenseImmutableId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("esuKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EsuKey> array = new List<EsuKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EsuKey.DeserializeEsuKey(item));
                    }
                    esuKeys = array;
                    continue;
                }
            }
            return new LicenseProfileStorageModelEsuProperties(Optional.ToNullable(assignedLicenseImmutableId), Optional.ToList(esuKeys));
        }
    }
}
