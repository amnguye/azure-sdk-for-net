// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (RouterName != null)
            {
                writer.WritePropertyName("routerName");
                writer.WriteStringValue(RouterName);
            }
            if (InterfaceName != null)
            {
                writer.WritePropertyName("interfaceName");
                writer.WriteStringValue(InterfaceName);
            }
            if (PatchPanelId != null)
            {
                writer.WritePropertyName("patchPanelId");
                writer.WriteStringValue(PatchPanelId);
            }
            if (RackId != null)
            {
                writer.WritePropertyName("rackId");
                writer.WriteStringValue(RackId);
            }
            if (ConnectorType != null)
            {
                writer.WritePropertyName("connectorType");
                writer.WriteStringValue(ConnectorType.Value.ToString());
            }
            if (AdminState != null)
            {
                writer.WritePropertyName("adminState");
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (MacSecConfig != null)
            {
                writer.WritePropertyName("macSecConfig");
                writer.WriteObjectValue(MacSecConfig);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteLink DeserializeExpressRouteLink(JsonElement element)
        {
            string name = default;
            string etag = default;
            string id = default;
            string routerName = default;
            string interfaceName = default;
            string patchPanelId = default;
            string rackId = default;
            ExpressRouteLinkConnectorType? connectorType = default;
            ExpressRouteLinkAdminState? adminState = default;
            ProvisioningState? provisioningState = default;
            ExpressRouteLinkMacSecConfig macSecConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("routerName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interfaceName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interfaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patchPanelId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            patchPanelId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rackId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rackId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectorType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorType = new ExpressRouteLinkConnectorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("adminState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new ExpressRouteLinkAdminState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("macSecConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            macSecConfig = ExpressRouteLinkMacSecConfig.DeserializeExpressRouteLinkMacSecConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteLink(id, name, etag, routerName, interfaceName, patchPanelId, rackId, connectorType, adminState, provisioningState, macSecConfig);
        }
    }
}