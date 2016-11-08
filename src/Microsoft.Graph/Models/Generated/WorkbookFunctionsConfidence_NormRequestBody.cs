// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsConfidence_NormRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsConfidence_NormRequestBody
    {
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [DataMember(Name = "alpha", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets StandardDev.
        /// </summary>
        [DataMember(Name = "standardDev", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken StandardDev { get; set; }
    
        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Size { get; set; }
    
    }
}