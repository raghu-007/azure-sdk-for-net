// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Grammar-based tokenizer that is suitable for processing most
    /// European-language documents. This tokenizer is implemented using
    /// Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/standard/ClassicTokenizer.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.ClassicTokenizer")]
    public partial class ClassicTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the ClassicTokenizer class.
        /// </summary>
        public ClassicTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the ClassicTokenizer class.
        /// </summary>
        public ClassicTokenizer(string name, int? maxTokenLength = default(int?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Default is 255. Tokens
        /// longer than the maximum length are split. The maximum token
        /// length that can be used is 300 characters. Tokens longer than 300
        /// characters are ignored.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
