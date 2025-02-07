// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Specifies which Redis node(s) to reboot. </summary>
    public partial class RedisRebootContent
    {
        /// <summary> Initializes a new instance of <see cref="RedisRebootContent"/>. </summary>
        public RedisRebootContent()
        {
            Ports = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisRebootContent"/>. </summary>
        /// <param name="rebootType"> Which Redis node(s) to reboot. Depending on this value data loss is possible. </param>
        /// <param name="shardId"> If clustering is enabled, the ID of the shard to be rebooted. </param>
        /// <param name="ports"> A list of redis instances to reboot, specified by per-instance SSL ports or non-SSL ports. </param>
        internal RedisRebootContent(RedisRebootType? rebootType, int? shardId, IList<int> ports)
        {
            RebootType = rebootType;
            ShardId = shardId;
            Ports = ports;
        }

        /// <summary> Which Redis node(s) to reboot. Depending on this value data loss is possible. </summary>
        public RedisRebootType? RebootType { get; set; }
        /// <summary> If clustering is enabled, the ID of the shard to be rebooted. </summary>
        public int? ShardId { get; set; }
        /// <summary> A list of redis instances to reboot, specified by per-instance SSL ports or non-SSL ports. </summary>
        public IList<int> Ports { get; }
    }
}
