// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Represents a property on a storage resource container.
    /// </summary>
    /// <typeparam name="T">The property type of the storage resource.</typeparam>
#pragma warning disable SA1649 // File name should match first type name
    public class DataTransferContainerProperty<T> : DataTransferProperty<T> where T : notnull
#pragma warning restore SA1649 // File name should match first type name
    {
        /// <summary>
        /// Represents whether to apply/preserve property to files, directories, or both.
        /// </summary>
        public enum ResourceFilterType
        {
            /// <summary>
            /// Filters only files.
            /// </summary>
            FilesOnly = 1,

            /// <summary>
            /// Filters only directories.
            /// </summary>
            DirectoriesOnly = 2,

            /// <summary>
            /// Filters both files and directories.
            /// By default does both.
            /// </summary>
            All = default,
        }
        internal ResourceFilterType FilterType;

        /// <summary>
        /// Constructs <see cref="DataTransferProperty"/> to preserves the respective property.
        /// </summary>
        /// <param name="preserve">Specifies whether or to preserve the property value from the source.</param>
        public DataTransferContainerProperty(bool preserve) : base(preserve)
        {
        }

        /// <summary>
        /// Constructor for <see cref="DataTransferProperty"/> to set value on the destination.
        /// This will overwrite the property on the destination with the parameter value.
        /// </summary>
        /// <param name="value">The value to set on the property.</param>
        public DataTransferContainerProperty(T value) : this(value, ResourceFilterType.All)
        {
        }

        /// <summary>
        /// Constructor for <see cref="DataTransferProperty"/> to set value on the destination.
        /// This will overwrite the property on the destination with the parameter value.
        /// </summary>
        /// <param name="value">The value to set on the property.</param>
        /// <param name="filterType">Represents whether to apply/preserve property to files, directories, or both.</param>
        public DataTransferContainerProperty(T value, ResourceFilterType filterType)
            : base(value)
        {
            FilterType = filterType;
        }
    }
}
