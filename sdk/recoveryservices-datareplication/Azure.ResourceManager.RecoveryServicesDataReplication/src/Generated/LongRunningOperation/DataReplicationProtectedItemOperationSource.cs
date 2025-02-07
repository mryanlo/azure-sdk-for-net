// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    internal class DataReplicationProtectedItemOperationSource : IOperationSource<DataReplicationProtectedItemResource>
    {
        private readonly ArmClient _client;

        internal DataReplicationProtectedItemOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataReplicationProtectedItemResource IOperationSource<DataReplicationProtectedItemResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataReplicationProtectedItemData.DeserializeDataReplicationProtectedItemData(document.RootElement);
            return new DataReplicationProtectedItemResource(_client, data);
        }

        async ValueTask<DataReplicationProtectedItemResource> IOperationSource<DataReplicationProtectedItemResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataReplicationProtectedItemData.DeserializeDataReplicationProtectedItemData(document.RootElement);
            return new DataReplicationProtectedItemResource(_client, data);
        }
    }
}
