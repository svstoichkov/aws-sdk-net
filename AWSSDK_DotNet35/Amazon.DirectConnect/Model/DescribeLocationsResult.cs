/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// A location is a network facility where AWS Direct Connect routers are available to
    /// be connected. Generally, these are colocation hubs where many network providers have
    /// equipment, and where cross connects can be delivered. Locations include a name and
    /// facility code, and must be provided when creating a connection.
    /// </summary>
    public partial class DescribeLocationsResult : AmazonWebServiceResponse
    {
        private List<Location> _locations = new List<Location>();

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// A list of colocation hubs where network providers have equipment. Most regions have
        /// multiple locations available.
        /// </para>
        /// </summary>
        public List<Location> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && this._locations.Count > 0; 
        }

    }
}