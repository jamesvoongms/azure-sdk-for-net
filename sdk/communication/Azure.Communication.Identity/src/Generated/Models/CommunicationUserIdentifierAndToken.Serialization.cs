// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.Identity.Models;

namespace Azure.Communication.Identity
{
    public partial class CommunicationUserIdentifierAndToken
    {
        internal static CommunicationUserIdentifierAndToken DeserializeCommunicationUserIdentifierAndToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentity identity = default;
            CommunicationIdentityAccessToken accessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    identity = CommunicationIdentity.DeserializeCommunicationIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessToken = CommunicationIdentityAccessToken.DeserializeCommunicationIdentityAccessToken(property.Value);
                    continue;
                }
            }
            return new CommunicationUserIdentifierAndToken(identity, accessToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CommunicationUserIdentifierAndToken FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCommunicationUserIdentifierAndToken(document.RootElement);
        }
    }
}
