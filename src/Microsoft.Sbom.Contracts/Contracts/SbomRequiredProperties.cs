// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.Sbom.Contracts;

/// <summary>
/// An abstract class to define the concepts that we expect to have in all SBOMs, regardless of the disk format
/// These items must not be defined in terms of types that are defined as part of an SPDX format. The mappping
/// of concept to file representation is handled in the derived class's implementation of the abstract properties.
/// </summary>
public abstract class SbomRequiredProperties
{
    public abstract string Version { get; set; }

    public abstract string DataLicense { get; set; }

    public abstract string SPDXID { get; set; }

    public abstract string Name { get; set; }

    public abstract string DocumentNamespace { get; set; }

    public abstract IEnumerable<string> Creators { get; set; }

    public abstract string Created { get; set; }
}
