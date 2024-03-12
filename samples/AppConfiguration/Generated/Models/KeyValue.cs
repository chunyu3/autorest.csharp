// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using AppConfiguration;

namespace AppConfiguration.Models
{
    /// <summary> The KeyValue. </summary>
    public partial class KeyValue
    {
        /// <summary> Initializes a new instance of <see cref="KeyValue"/>. </summary>
        public KeyValue()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyValue"/>. </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="contentType"></param>
        /// <param name="value"></param>
        /// <param name="lastModified"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="locked"></param>
        /// <param name="etag"></param>
        internal KeyValue(string key, string label, string contentType, string value, DateTimeOffset? lastModified, IDictionary<string, string> tags, bool? locked, string etag)
        {
            Key = key;
            Label = label;
            ContentType = contentType;
            Value = value;
            LastModified = lastModified;
            Tags = tags;
            Locked = locked;
            Etag = etag;
        }

        /// <summary> Gets or sets the key. </summary>
        public string Key { get; set; }
        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Gets or sets the content type. </summary>
        public string ContentType { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
        /// <summary> Gets or sets the last modified. </summary>
        public DateTimeOffset? LastModified { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the locked. </summary>
        public bool? Locked { get; set; }
        /// <summary> Gets or sets the etag. </summary>
        public string Etag { get; set; }
    }
}
