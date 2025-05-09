// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlPrivateLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAPrivateLinkResourceForMySQL()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/PrivateLinkResourcesGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlPrivateLinkResource created on azure
            // for more information of creating MySqlPrivateLinkResource, please refer to the document of MySqlPrivateLinkResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default";
            string serverName = "test-svr";
            string groupName = "plr";
            ResourceIdentifier mySqlPrivateLinkResourceId = MySqlPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, groupName);
            MySqlPrivateLinkResource mySqlPrivateLinkResource = client.GetMySqlPrivateLinkResource(mySqlPrivateLinkResourceId);

            // invoke the operation
            MySqlPrivateLinkResource result = await mySqlPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
