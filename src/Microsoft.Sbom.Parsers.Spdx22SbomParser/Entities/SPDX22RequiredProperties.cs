// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Sbom.Parsers.Spdx22SbomParser.Entities;

using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Microsoft.Sbom.Contracts;

// This class uses JSON serialization attributes to enforce the SPDX 2.x format
// Metadata fields tagged as required are required by the SPDX 2.x specification.
public class SPDX22RequiredProperties : SbomRequiredProperties
{
    // These attributes are required by the SPDX 2.x spec.
    [JsonRequired]
    [JsonPropertyName("spdxVersion")]
    public override string Version { get; set; }

    [JsonRequired]
    [JsonPropertyName("dataLicense")]
    public override string DataLicense { get; set; }

    [JsonRequired]
    [JsonPropertyName("SPDXID")]
    public override string SPDXID { get; set; }

    [JsonRequired]
    [JsonPropertyName("name")]
    public override string Name { get; set; }

    [JsonRequired]
    [JsonPropertyName("documentNamespace")]
    public override string DocumentNamespace { get; set; }

    [JsonRequired]
    [JsonPropertyName("creationInfo")]
    public CreationInfo CreationInfo { get; set; }

    public override IEnumerable<string> Creators
    {
        get => CreationInfo?.Creators;
        set
        {
            if (CreationInfo != null)
            {
                CreationInfo.Creators = value;
            }
            else
            {
                throw new InvalidDataException("CreationInfo is null. Cannot set Creators.");
            }
        }
    }

    public override string Created
    {
        get => CreationInfo?.Created;
        set
        {
            if (CreationInfo != null)
            {
                CreationInfo.Created = value;
            }
            else
            {
                throw new InvalidDataException("CreationInfo is null. Cannot set Created.");
            }
        }
    }
}
