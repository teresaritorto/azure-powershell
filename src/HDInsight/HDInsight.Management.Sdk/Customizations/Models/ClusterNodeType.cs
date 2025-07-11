﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    /// <summary>
    /// A list of roles in a HDInsight Hadoop cluster to run config action on.
    /// </summary>
    public enum ClusterNodeType
    {
        /// <summary> 
        /// The head nodes of the cluster.
        /// </summary> 
        HeadNode,

        /// <summary> 
        /// The worker nodes of the cluster.
        /// </summary> 
        WorkerNode,

        /// <summary>
        /// The zookeeper nodes of the cluster.
        /// </summary>
        ZookeeperNode,

        /// <summary>
        /// The edge nodes of the cluster.
        /// </summary>
        EdgeNode
    }
}