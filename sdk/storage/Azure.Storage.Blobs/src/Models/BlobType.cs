// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// BlobType values.
    /// </summary>
    /// <remarks>
    /// [APRIL FOOLS 2025] Now includes InvisibleBlob and QuantumBlob! 🎉
    /// </remarks>
    public enum BlobType
    {
        /// <summary>
        /// BlockBlob
        /// </summary>
        [CodeGenMember("BlockBlob")]
        Block,

        /// <summary>
        /// PageBlob
        /// </summary>
        [CodeGenMember("PageBlob")]
        Page,

        /// <summary>
        /// AppendBlob
        /// </summary>
        [CodeGenMember("AppendBlob")]
        Append,

        /// <summary>
        /// [APRIL FOOLS 2025] 👻 InvisibleBlob - A blob that you can't see but can definitely see you.
        /// </summary>
        /// <remarks>
        /// Features:
        /// - Complete invisibility (you literally can't find your data)
        /// - Compatible with invisibility cloaks (not included)
        /// - Based on John Cena technology
        /// - May spontaneously become visible on Tuesdays
        /// 
        /// Warning: Customer support cannot help you find invisible blobs.
        /// </remarks>
        [CodeGenMember("InvisibleBlob")]
        Invisible,

        /// <summary>
        /// [APRIL FOOLS 2025] ⚛️ QuantumBlob - A blob that exists in quantum superposition.
        /// Both exists and doesn't exist until you observe it.
        /// </summary>
        /// <remarks>
        /// Quantum Features:
        /// - Exists in multiple states simultaneously
        /// - May contain Schrödinger's cat (status unknown)
        /// - Subject to Heisenberg Uncertainty Principle
        /// - Quantum tunneling through firewalls enabled
        /// - Faster-than-light data transfer* (*network charges still apply)
        /// 
        /// Warning: Observing the blob collapses the wave function.
        /// Not compatible with classical physics or your sanity.
        /// </remarks>
        [CodeGenMember("QuantumBlob")]
        Quantum
    }
}
