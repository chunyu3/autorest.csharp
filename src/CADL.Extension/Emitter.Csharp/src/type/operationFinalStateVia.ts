// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

export enum OperationFinalStateVia {
    AzureAsyncOperation = "AzureAsyncOperation",
    Location = "Location",
    OriginalUri = "OriginalUri",
    OperationLocation = "OperationLocation",
    LocationOverride = "LocationOverride",
    CustomLink = "CustomLink",
    CustomOperationReference = "CustomOperationReference"
}

export const operationFinalStateViaMap: { [key: string]: OperationFinalStateVia } = {
    "azure-async-operation": OperationFinalStateVia.AzureAsyncOperation,
    "Location": OperationFinalStateVia.Location,
    "original-uri": OperationFinalStateVia.OriginalUri,
    "operation-location": OperationFinalStateVia.OperationLocation,
    "location-override": OperationFinalStateVia.LocationOverride,
    "custom-link": OperationFinalStateVia.CustomLink,
    "custom-operation-reference": OperationFinalStateVia.CustomOperationReference
};
