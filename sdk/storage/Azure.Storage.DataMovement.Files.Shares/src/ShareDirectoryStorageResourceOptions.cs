// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Storage.Files.Shares.Models;
using Metadata = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.DataMovement.Files.Shares
{
    /// <summary>
    /// Optional parameters for all Share Directory Storage resource types.
    /// </summary>
    public class ShareDirectoryStorageResourceOptions
    {
        /// <summary>
        /// The file system attributes for this directory.
        ///
        /// By default preserves the File Attributes from the source.
        /// </summary>
        public DataTransferProperty<NtfsFileAttributes?> FileAttributes { get; set; }

        /// <summary>
        /// The creation time of the directory.
        ///
        /// By default preserves the directory Created On Time from the source.
        /// </summary>
        public DataTransferProperty<DateTimeOffset?> DirectoryCreatedOn { get; set; }

        /// <summary>
        /// The change time of the directory.
        ///
        /// By default preserves the directory Changed On Time from the source.
        /// </summary>
        public DataTransferProperty<DateTimeOffset?> DirectoryChangedOn { get; set; }

        /// <summary>
        /// Optional. Defines custom metadata to set on the destination resource.
        ///
        /// Applies to upload and copy transfers.
        ///
        /// Preserves Metadata from the source by default.
        /// </summary>
#pragma warning disable CA2227 // Collection properties should be readonly
        public DataTransferProperty<Metadata> DirectoryMetadata { get; set; }
#pragma warning restore CA2227 // Collection properties should be readonly

        /// <summary>
        /// Optional. Sets the File specific options for the transfer.
        /// </summary>
        public ShareFileStorageResourceOptions FileOptions { get; set; }
    }
}
