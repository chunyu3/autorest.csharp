// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Tables.Models
{
    /// <summary> The response for a single table. </summary>
    public partial class TableResult : TableResponseProperties
    {
        /// <summary> Initializes a new instance of <see cref="TableResult"/>. </summary>
        internal TableResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableResult"/>. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="odataType"> The odata type of the table. </param>
        /// <param name="odataId"> The id of the table. </param>
        /// <param name="odataEditLink"> The edit link of the table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="odataMetadata"> The metadata response of the table. </param>
        internal TableResult(string tableName, string odataType, string odataId, string odataEditLink, IDictionary<string, BinaryData> serializedAdditionalRawData, string odataMetadata) : base(tableName, odataType, odataId, odataEditLink, serializedAdditionalRawData)
        {
            OdataMetadata = odataMetadata;
        }

        /// <summary> The metadata response of the table. </summary>
        public string OdataMetadata { get; }
    }
}