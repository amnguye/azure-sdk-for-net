// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for the service task to upload an OCI driver.
    /// </summary>
    public partial class UploadOCIDriverTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the UploadOCIDriverTaskOutput class.
        /// </summary>
        public UploadOCIDriverTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UploadOCIDriverTaskOutput class.
        /// </summary>
        /// <param name="driverPackageName">The name of the driver package that
        /// was validated and uploaded.</param>
        /// <param name="validationErrors">Validation errors</param>
        public UploadOCIDriverTaskOutput(string driverPackageName = default(string), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            DriverPackageName = driverPackageName;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the driver package that was validated and
        /// uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "driverPackageName")]
        public string DriverPackageName { get; private set; }

        /// <summary>
        /// Gets validation errors
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
