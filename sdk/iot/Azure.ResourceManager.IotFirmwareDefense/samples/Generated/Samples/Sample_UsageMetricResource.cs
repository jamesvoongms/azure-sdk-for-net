// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.IotFirmwareDefense.Samples
{
    public partial class Sample_UsageMetricResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_UsageMetricsGetGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/UsageMetrics_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "UsageMetrics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this UsageMetricResource created on azure
            // for more information of creating UsageMetricResource, please refer to the document of UsageMetricResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string name = "default";
            ResourceIdentifier usageMetricResourceId = UsageMetricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            UsageMetricResource usageMetric = client.GetUsageMetricResource(usageMetricResourceId);

            // invoke the operation
            UsageMetricResource result = await usageMetric.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UsageMetricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
