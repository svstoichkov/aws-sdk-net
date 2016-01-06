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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrail operation.
    /// Creates a trail that specifies the settings for delivery of log data to an Amazon
    /// S3 bucket. A maximum of five trails can exist in a region, irrespective of the region
    /// in which they were created.
    /// </summary>
    public partial class CreateTrailRequest : AmazonCloudTrailRequest
    {
        private string _cloudWatchLogsLogGroupArn;
        private string _cloudWatchLogsRoleArn;
        private bool? _enableLogFileValidation;
        private bool? _includeGlobalServiceEvents;
        private bool? _isMultiRegionTrail;
        private string _kmsKeyId;
        private string _name;
        private string _s3BucketName;
        private string _s3KeyPrefix;
        private string _snsTopicName;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier
        /// that represents the log group to which CloudTrail logs will be delivered. Not required
        /// unless you specify CloudWatchLogsRoleArn.
        /// </para>
        /// </summary>
        public string CloudWatchLogsLogGroupArn
        {
            get { return this._cloudWatchLogsLogGroupArn; }
            set { this._cloudWatchLogsLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogsLogGroupArn property is set
        internal bool IsSetCloudWatchLogsLogGroupArn()
        {
            return this._cloudWatchLogsLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's
        /// log group.
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn
        {
            get { return this._cloudWatchLogsRoleArn; }
            set { this._cloudWatchLogsRoleArn = value; }
        }

        // Check to see if CloudWatchLogsRoleArn property is set
        internal bool IsSetCloudWatchLogsRoleArn()
        {
            return this._cloudWatchLogsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnableLogFileValidation. 
        /// <para>
        /// Specifies whether log file integrity validation is enabled. The default is false.
        /// </para>
        ///  <note>When you disable log file integrity validation, the chain of digest files is
        /// broken after one hour. CloudTrail will not create digest files for log files that
        /// were delivered during a period in which log file integrity validation was disabled.
        /// For example, if you enable log file integrity validation at noon on January 1, disable
        /// it at noon on January 2, and re-enable it at noon on January 10, digest files will
        /// not be created for the log files delivered from noon on January 2 to noon on January
        /// 10. The same applies whenever you stop CloudTrail logging or delete a trail.</note>
        /// </summary>
        public bool EnableLogFileValidation
        {
            get { return this._enableLogFileValidation.GetValueOrDefault(); }
            set { this._enableLogFileValidation = value; }
        }

        // Check to see if EnableLogFileValidation property is set
        internal bool IsSetEnableLogFileValidation()
        {
            return this._enableLogFileValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeGlobalServiceEvents. 
        /// <para>
        /// Specifies whether the trail is publishing events from global services such as IAM
        /// to the log files. 
        /// </para>
        /// </summary>
        public bool IncludeGlobalServiceEvents
        {
            get { return this._includeGlobalServiceEvents.GetValueOrDefault(); }
            set { this._includeGlobalServiceEvents = value; }
        }

        // Check to see if IncludeGlobalServiceEvents property is set
        internal bool IsSetIncludeGlobalServiceEvents()
        {
            return this._includeGlobalServiceEvents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsMultiRegionTrail. 
        /// <para>
        /// Specifies whether the trail is created in the current region or in all regions. The
        /// default is false.
        /// </para>
        /// </summary>
        public bool IsMultiRegionTrail
        {
            get { return this._isMultiRegionTrail.GetValueOrDefault(); }
            set { this._isMultiRegionTrail = value; }
        }

        // Check to see if IsMultiRegionTrail property is set
        internal bool IsSetIsMultiRegionTrail()
        {
            return this._isMultiRegionTrail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail. The value
        /// can be a an alias name prefixed by "alias/", a fully specified ARN to an alias, a
        /// fully specified ARN to a key, or a globally unique identifier.
        /// </para>
        ///  
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li>alias/MyAliasName</li> <li>arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</li>
        /// <li>arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li>
        /// <li>12345678-1234-1234-1234-123456789012</li> </ul>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the trail. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li>Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores
        /// (_), or dashes (-)</li> <li>Start with a letter or number, and end with a letter or
        /// number</li> <li>Be between 3 and 128 characters</li> <li>Have no adjacent periods,
        /// underscores or dashes. Names like <code>my-_namespace</code> and <code>my--namespace</code>
        /// are invalid.</li> <li>Not be in IP address format (for example, 192.168.5.4)</li>
        /// </ul>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Specifies the name of the Amazon S3 bucket designated for publishing log files. See
        /// <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/create_trail_naming_policy.html">Amazon
        /// S3 Bucket Naming Requirements</a>.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Specifies the Amazon S3 key prefix that comes after the name of the bucket you have
        /// designated for log file delivery. For more information, see <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-find-log-files.html">Finding
        /// Your CloudTrail Log Files</a>. The maximum length is 200 characters.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicName. 
        /// <para>
        /// Specifies the name of the Amazon SNS topic defined for notification of log file delivery.
        /// The maximum length is 256 characters.
        /// </para>
        /// </summary>
        public string SnsTopicName
        {
            get { return this._snsTopicName; }
            set { this._snsTopicName = value; }
        }

        // Check to see if SnsTopicName property is set
        internal bool IsSetSnsTopicName()
        {
            return this._snsTopicName != null;
        }

    }
}