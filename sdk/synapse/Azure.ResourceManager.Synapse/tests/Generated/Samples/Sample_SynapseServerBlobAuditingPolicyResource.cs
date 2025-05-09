// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseServerBlobAuditingPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetBlobAuditingSettingOfWorkspaceManagedSqlServer()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseServerBlobAuditingPolicyResource created on azure
            // for more information of creating SynapseServerBlobAuditingPolicyResource, please refer to the document of SynapseServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            ResourceIdentifier synapseServerBlobAuditingPolicyResourceId = SynapseServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, blobAuditingPolicyName);
            SynapseServerBlobAuditingPolicyResource synapseServerBlobAuditingPolicy = client.GetSynapseServerBlobAuditingPolicyResource(synapseServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SynapseServerBlobAuditingPolicyResource result = await synapseServerBlobAuditingPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateBlobAuditingPolicyOfWorkspaceSQLServerWithAllParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerBlobAuditingSettingsWithAllParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseServerBlobAuditingPolicyResource created on azure
            // for more information of creating SynapseServerBlobAuditingPolicyResource, please refer to the document of SynapseServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            ResourceIdentifier synapseServerBlobAuditingPolicyResourceId = SynapseServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, blobAuditingPolicyName);
            SynapseServerBlobAuditingPolicyResource synapseServerBlobAuditingPolicy = client.GetSynapseServerBlobAuditingPolicyResource(synapseServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SynapseServerBlobAuditingPolicyData data = new SynapseServerBlobAuditingPolicyData
            {
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
                AuditActionsAndGroups = { "SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP", "FAILED_DATABASE_AUTHENTICATION_GROUP", "BATCH_COMPLETED_GROUP" },
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
            };
            ArmOperation<SynapseServerBlobAuditingPolicyResource> lro = await synapseServerBlobAuditingPolicy.UpdateAsync(WaitUntil.Completed, data);
            SynapseServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateBlobAuditingPolicyOfWorkspaceManagedSqlServerWithMinimalParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerBlobAuditingSettingsWithMinParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseServerBlobAuditingPolicyResource created on azure
            // for more information of creating SynapseServerBlobAuditingPolicyResource, please refer to the document of SynapseServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            ResourceIdentifier synapseServerBlobAuditingPolicyResourceId = SynapseServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, blobAuditingPolicyName);
            SynapseServerBlobAuditingPolicyResource synapseServerBlobAuditingPolicy = client.GetSynapseServerBlobAuditingPolicyResource(synapseServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SynapseServerBlobAuditingPolicyData data = new SynapseServerBlobAuditingPolicyData
            {
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<SynapseServerBlobAuditingPolicyResource> lro = await synapseServerBlobAuditingPolicy.UpdateAsync(WaitUntil.Completed, data);
            SynapseServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
