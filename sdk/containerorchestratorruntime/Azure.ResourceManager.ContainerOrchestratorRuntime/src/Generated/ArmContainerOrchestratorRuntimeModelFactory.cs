// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmContainerOrchestratorRuntimeModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ContainerOrchestratorRuntime.ConnectedClusterStorageClassData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="ContainerOrchestratorRuntime.ConnectedClusterStorageClassData"/> instance for mocking. </returns>
        public static ConnectedClusterStorageClassData ConnectedClusterStorageClassData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ConnectedClusterStorageClassProperties properties = null)
        {
            return new ConnectedClusterStorageClassData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConnectedClusterStorageClassProperties"/>. </summary>
        /// <param name="allowVolumeExpansion"> Volume can be expanded or not. </param>
        /// <param name="mountOptions"> Additional mount options. </param>
        /// <param name="provisioner"> Provisioner name. </param>
        /// <param name="volumeBindingMode"> Binding mode of volumes: Immediate, WaitForFirstConsumer. </param>
        /// <param name="accessModes"> The access mode: [ReadWriteOnce, ReadWriteMany] or [ReadWriteOnce]. </param>
        /// <param name="dataResilience"> Allow single data node failure. </param>
        /// <param name="failoverSpeed"> Failover speed: NA, Slow, Fast. </param>
        /// <param name="limitations"> Limitations of the storage class. </param>
        /// <param name="performance"> Performance tier. </param>
        /// <param name="priority"> Selection priority when multiple storage classes meet the criteria. 0: Highest, -1: Never use. </param>
        /// <param name="typeProperties">
        /// Properties of the StorageClass
        /// Please note <see cref="StorageClassTypeProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BlobStorageClassTypeProperties"/>, <see cref="NativeStorageClassTypeProperties"/>, <see cref="NfsStorageClassTypeProperties"/>, <see cref="RwxStorageClassTypeProperties"/> and <see cref="SmbStorageClassTypeProperties"/>.
        /// </param>
        /// <param name="provisioningState"> Resource provision state. </param>
        /// <returns> A new <see cref="Models.ConnectedClusterStorageClassProperties"/> instance for mocking. </returns>
        public static ConnectedClusterStorageClassProperties ConnectedClusterStorageClassProperties(VolumeExpansion? allowVolumeExpansion = null, IEnumerable<string> mountOptions = null, string provisioner = null, VolumeBindingMode? volumeBindingMode = null, IEnumerable<StorageClassAccessMode> accessModes = null, DataResilienceTier? dataResilience = null, FailoverTier? failoverSpeed = null, IEnumerable<string> limitations = null, PerformanceTier? performance = null, long? priority = null, StorageClassTypeProperties typeProperties = null, ContainerOrchestratorProvisioningState? provisioningState = null)
        {
            mountOptions ??= new List<string>();
            accessModes ??= new List<StorageClassAccessMode>();
            limitations ??= new List<string>();

            return new ConnectedClusterStorageClassProperties(
                allowVolumeExpansion,
                mountOptions?.ToList(),
                provisioner,
                volumeBindingMode,
                accessModes?.ToList(),
                dataResilience,
                failoverSpeed,
                limitations?.ToList(),
                performance,
                priority,
                typeProperties,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerOrchestratorRuntime.ConnectedClusterLoadBalancerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="ContainerOrchestratorRuntime.ConnectedClusterLoadBalancerData"/> instance for mocking. </returns>
        public static ConnectedClusterLoadBalancerData ConnectedClusterLoadBalancerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ConnectedClusterLoadBalancerProperties properties = null)
        {
            return new ConnectedClusterLoadBalancerData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConnectedClusterLoadBalancerProperties"/>. </summary>
        /// <param name="addresses"> IP Range. </param>
        /// <param name="serviceSelector"> A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services with label "a=b", then please specify {"a": "b"} in the field. </param>
        /// <param name="advertiseMode"> Advertise Mode. </param>
        /// <param name="bgpPeers"> The list of BGP peers it should advertise to. Null or empty means to advertise to all peers. </param>
        /// <param name="provisioningState"> Resource provision state. </param>
        /// <returns> A new <see cref="Models.ConnectedClusterLoadBalancerProperties"/> instance for mocking. </returns>
        public static ConnectedClusterLoadBalancerProperties ConnectedClusterLoadBalancerProperties(IEnumerable<string> addresses = null, IDictionary<string, string> serviceSelector = null, AdvertiseMode advertiseMode = default, IEnumerable<string> bgpPeers = null, ContainerOrchestratorProvisioningState? provisioningState = null)
        {
            addresses ??= new List<string>();
            serviceSelector ??= new Dictionary<string, string>();
            bgpPeers ??= new List<string>();

            return new ConnectedClusterLoadBalancerProperties(
                addresses?.ToList(),
                serviceSelector,
                advertiseMode,
                bgpPeers?.ToList(),
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerOrchestratorRuntime.ConnectedClusterBgpPeerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="ContainerOrchestratorRuntime.ConnectedClusterBgpPeerData"/> instance for mocking. </returns>
        public static ConnectedClusterBgpPeerData ConnectedClusterBgpPeerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ConnectedClusterBgpPeerProperties properties = null)
        {
            return new ConnectedClusterBgpPeerData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConnectedClusterBgpPeerProperties"/>. </summary>
        /// <param name="myAsn"> My ASN. </param>
        /// <param name="peerAsn"> Peer ASN. </param>
        /// <param name="peerAddress"> Peer Address. </param>
        /// <param name="provisioningState"> Resource provision state. </param>
        /// <returns> A new <see cref="Models.ConnectedClusterBgpPeerProperties"/> instance for mocking. </returns>
        public static ConnectedClusterBgpPeerProperties ConnectedClusterBgpPeerProperties(int myAsn = default, int peerAsn = default, string peerAddress = null, ContainerOrchestratorProvisioningState? provisioningState = null)
        {
            return new ConnectedClusterBgpPeerProperties(myAsn, peerAsn, peerAddress, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ContainerOrchestratorRuntime.ConnectedClusterServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <returns> A new <see cref="ContainerOrchestratorRuntime.ConnectedClusterServiceData"/> instance for mocking. </returns>
        public static ConnectedClusterServiceData ConnectedClusterServiceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ConnectedClusterServiceProperties properties = null)
        {
            return new ConnectedClusterServiceData(
                id,
                name,
                resourceType,
                systemData,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConnectedClusterServiceProperties"/>. </summary>
        /// <param name="rpObjectId"> The object id of the service principal of the RP provisioned in the tenant. </param>
        /// <param name="provisioningState"> Resource provision state. </param>
        /// <returns> A new <see cref="Models.ConnectedClusterServiceProperties"/> instance for mocking. </returns>
        public static ConnectedClusterServiceProperties ConnectedClusterServiceProperties(Guid? rpObjectId = null, ContainerOrchestratorProvisioningState? provisioningState = null)
        {
            return new ConnectedClusterServiceProperties(rpObjectId, provisioningState, serializedAdditionalRawData: null);
        }
    }
}
