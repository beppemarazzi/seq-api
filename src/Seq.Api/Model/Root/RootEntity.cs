﻿// Copyright © Datalust and contributors. 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Seq.Api.Model.Root
{
    /// <summary>
    /// Information about the API exposed by the server.
    /// </summary>
    public class RootEntity : ILinked
    {
        /// <summary>
        /// Construct a <see cref="RootEntity"/>.
        /// </summary>
        public RootEntity()
        {
            Links = new LinkCollection();
        }

        /// <summary>
        /// The product serving the API.
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// The version of the product serving the API.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// An informational name identifying the instance.
        /// </summary>
        public string InstanceName { get; set; }
        
        /// <summary>
        /// A list of non-default features enabled on this server. Normally, <c langword="null">null</c> unless
        /// an administrator has explicitly opted-into alpha or beta-level features.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<string> EnabledFeatures { get; set; }

        /// <summary>
        /// Links to resources exposed by the API.
        /// </summary>
        public LinkCollection Links { get; set; }
    }
}
