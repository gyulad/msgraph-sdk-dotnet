// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WorkbookWorksheetProtectionOptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WorkbookWorksheetProtectionOptions
    {
    
        /// <summary>
        /// Gets or sets allowAutoFilter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowAutoFilter", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowAutoFilter { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteColumns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeleteColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeleteColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteRows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeleteRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeleteRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatCells.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatCells", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatCells { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatColumns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatRows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertColumns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertHyperlinks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertHyperlinks", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertHyperlinks { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertRows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowPivotTables.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowPivotTables", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowPivotTables { get; set; }
    
        /// <summary>
        /// Gets or sets allowSort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowSort", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowSort { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
