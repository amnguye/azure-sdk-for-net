// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Files.Shares;

namespace Azure.Storage.DataMovement.Files.Shares
{
    internal class ShareDirectoryStorageResourceContainer : StorageResourceContainerInternal
    {
        internal ShareDirectoryStorageResourceOptions ResourceOptions { get; set; }
        internal PathScanner PathScanner { get; set; } = PathScanner.Singleton.Value;

        internal ShareDirectoryClient ShareDirectoryClient { get; }

        public override Uri Uri => ShareDirectoryClient.Uri;

        public override string ProviderId => "share";

        internal ShareDirectoryStorageResourceContainer(ShareDirectoryClient shareDirectoryClient, ShareDirectoryStorageResourceOptions options)
        {
            ShareDirectoryClient = shareDirectoryClient;
            ResourceOptions = options;
        }

        protected override StorageResourceItem GetStorageResourceReference(string path)
        {
            List<string> pathSegments = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToList();
            ShareDirectoryClient dir = ShareDirectoryClient;
            foreach (string pathSegment in pathSegments.Take(pathSegments.Count - 1))
            {
                dir = dir.GetSubdirectoryClient(pathSegment);
            }
            ShareFileClient file = dir.GetFileClient(pathSegments.Last());
            return new ShareFileStorageResource(file, ResourceOptions.FileOptions);
        }

        protected override async IAsyncEnumerable<StorageResource> GetStorageResourcesAsync(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach ((ShareDirectoryClient dir, ShareFileClient file) in PathScanner.ScanAsync(
                ShareDirectoryClient, cancellationToken).ConfigureAwait(false))
            {
                if (file != default)
                {
                    yield return new ShareFileStorageResource(file, ResourceOptions.FileOptions);
                }
                else
                {
                    yield return new ShareDirectoryStorageResourceContainer(dir, ResourceOptions);
                }
            }
        }

        protected override StorageResourceCheckpointData GetSourceCheckpointData()
        {
            return new ShareFileSourceCheckpointData();
        }

        protected override StorageResourceCheckpointData GetDestinationCheckpointData()
        {
            return new ShareFileDestinationCheckpointData(
                contentType: ResourceOptions?.FileOptions?.ContentType,
                contentEncoding: ResourceOptions?.FileOptions?.ContentEncoding,
                contentLanguage: ResourceOptions?.FileOptions?.ContentLanguage,
                contentDisposition: ResourceOptions?.FileOptions?.ContentDisposition,
                cacheControl: ResourceOptions?.FileOptions?.CacheControl,
                fileAttributes: ResourceOptions?.FileOptions?.FileAttributes,
                filePermissionKey: ResourceOptions?.FileOptions?.FilePermissionKey,
                fileCreatedOn: ResourceOptions?.FileOptions?.FileCreatedOn,
                fileLastWrittenOn: ResourceOptions?.FileOptions?.FileLastWrittenOn,
                fileChangedOn: ResourceOptions?.FileOptions?.FileChangedOn,
                fileMetadata: ResourceOptions?.FileOptions?.FileMetadata,
                directoryMetadata: ResourceOptions?.DirectoryMetadata);
        }

        protected override async Task CreateIfNotExistsAsync(CancellationToken cancellationToken = default)
        {
            await ShareDirectoryClient.CreateIfNotExistsAsync(
                metadata: default,
                smbProperties: default,
                filePermission: default,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        protected override StorageResourceContainer GetChildStorageResourceContainer(string path)
            => new ShareDirectoryStorageResourceContainer(ShareDirectoryClient.GetSubdirectoryClient(path), ResourceOptions);
    }
}
