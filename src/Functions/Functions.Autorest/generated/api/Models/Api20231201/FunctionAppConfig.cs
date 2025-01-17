// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Function app configuration.</summary>
    public partial class FunctionAppConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfig,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal
    {

        /// <summary>
        /// Use this property for StorageAccountConnectionString. Set the name of the app setting that has the storage account connection
        /// string. Do not set a value for this property when using other authentication type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string AuthenticationStorageAccountConnectionStringName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationStorageAccountConnectionStringName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationStorageAccountConnectionStringName = value ?? null; }

        /// <summary>
        /// Property to select authentication type to access the selected storage account. Available options: SystemAssignedIdentity,
        /// UserAssignedIdentity, StorageAccountConnectionString.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType? AuthenticationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType)""); }

        /// <summary>
        /// Use this property for UserAssignedIdentity. Set the resource ID of the identity. Do not set a value for this property
        /// when using other authentication type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string AuthenticationUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationUserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).AuthenticationUserAssignedIdentityResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Deployment" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment _deployment;

        /// <summary>Function app deployment configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment Deployment { get => (this._deployment = this._deployment ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeployment()); set => this._deployment = value; }

        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public float? HttpPerInstanceConcurrency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).HttpPerInstanceConcurrency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).HttpPerInstanceConcurrency = value ?? default(float); }

        /// <summary>Internal Acessors for Deployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.Deployment { get => (this._deployment = this._deployment ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsDeployment()); set { {_deployment = value;} } }

        /// <summary>Internal Acessors for DeploymentStorage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorage Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.DeploymentStorage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).Storage = value; }

        /// <summary>Internal Acessors for Runtime</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.Runtime { get => (this._runtime = this._runtime ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsRuntime()); set { {_runtime = value;} } }

        /// <summary>Internal Acessors for ScaleAndConcurrency</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.ScaleAndConcurrency { get => (this._scaleAndConcurrency = this._scaleAndConcurrency ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrency()); set { {_scaleAndConcurrency = value;} } }

        /// <summary>Internal Acessors for ScaleAndConcurrencyTrigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggers Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.ScaleAndConcurrencyTrigger { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).Trigger; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).Trigger = value; }

        /// <summary>Internal Acessors for StorageAuthentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorageAuthentication Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.StorageAuthentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageAuthentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageAuthentication = value; }

        /// <summary>Internal Acessors for TriggerHttp</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppConfigInternal.TriggerHttp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).TriggerHttp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).TriggerHttp = value; }

        /// <summary>Backing field for <see cref="Runtime" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime _runtime;

        /// <summary>Function app runtime settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime Runtime { get => (this._runtime = this._runtime ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsRuntime()); set => this._runtime = value; }

        /// <summary>
        /// Function app runtime name. Available options: dotnet-isolated, node, java, powershell, python, custom
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName? RuntimeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntimeInternal)Runtime).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntimeInternal)Runtime).Name = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName)""); }

        /// <summary>Function app runtime version. Example: 8 (for dotnet-isolated)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string RuntimeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntimeInternal)Runtime).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntimeInternal)Runtime).Version = value ?? null; }

        /// <summary>Backing field for <see cref="ScaleAndConcurrency" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency _scaleAndConcurrency;

        /// <summary>Function app scale and concurrency settings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency ScaleAndConcurrency { get => (this._scaleAndConcurrency = this._scaleAndConcurrency ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionsScaleAndConcurrency()); set => this._scaleAndConcurrency = value; }

        /// <summary>'Always Ready' configuration for the function app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig[] ScaleAndConcurrencyAlwaysReady { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).AlwaysReady; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).AlwaysReady = value ?? null /* arrayOf */; }

        /// <summary>
        /// Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated
        /// proportionally.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public float? ScaleAndConcurrencyInstanceMemoryMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).InstanceMemoryMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).InstanceMemoryMb = value ?? default(float); }

        /// <summary>The maximum number of instances for the function app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public float? ScaleAndConcurrencyMaximumInstanceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).MaximumInstanceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyInternal)ScaleAndConcurrency).MaximumInstanceCount = value ?? default(float); }

        /// <summary>Property to select Azure Storage type. Available options: blobContainer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType? StorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType)""); }

        /// <summary>
        /// Property to set the URL for the selected Azure Storage type. Example: For blobContainer, the value could be https://<storageAccountName>.blob.core.windows.net/<containerName>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string StorageValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentInternal)Deployment).StorageValue = value ?? null; }

        /// <summary>Creates an new <see cref="FunctionAppConfig" /> instance.</summary>
        public FunctionAppConfig()
        {

        }
    }
    /// Function app configuration.
    public partial interface IFunctionAppConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Use this property for StorageAccountConnectionString. Set the name of the app setting that has the storage account connection
        /// string. Do not set a value for this property when using other authentication type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use this property for StorageAccountConnectionString. Set the name of the app setting that has the storage account connection string. Do not set a value for this property when using other authentication type.",
        SerializedName = @"storageAccountConnectionStringName",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationStorageAccountConnectionStringName { get; set; }
        /// <summary>
        /// Property to select authentication type to access the selected storage account. Available options: SystemAssignedIdentity,
        /// UserAssignedIdentity, StorageAccountConnectionString.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to select authentication type to access the selected storage account. Available options: SystemAssignedIdentity, UserAssignedIdentity, StorageAccountConnectionString.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>
        /// Use this property for UserAssignedIdentity. Set the resource ID of the identity. Do not set a value for this property
        /// when using other authentication type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use this property for UserAssignedIdentity. Set the resource ID of the identity. Do not set a value for this property when using other authentication type.",
        SerializedName = @"userAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationUserAssignedIdentityResourceId { get; set; }
        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number of concurrent HTTP trigger invocations per instance.",
        SerializedName = @"perInstanceConcurrency",
        PossibleTypes = new [] { typeof(float) })]
        float? HttpPerInstanceConcurrency { get; set; }
        /// <summary>
        /// Function app runtime name. Available options: dotnet-isolated, node, java, powershell, python, custom
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Function app runtime name. Available options: dotnet-isolated, node, java, powershell, python, custom",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName? RuntimeName { get; set; }
        /// <summary>Function app runtime version. Example: 8 (for dotnet-isolated)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Function app runtime version. Example: 8 (for dotnet-isolated)",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeVersion { get; set; }
        /// <summary>'Always Ready' configuration for the function app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"'Always Ready' configuration for the function app.",
        SerializedName = @"alwaysReady",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig[] ScaleAndConcurrencyAlwaysReady { get; set; }
        /// <summary>
        /// Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated
        /// proportionally.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated proportionally.",
        SerializedName = @"instanceMemoryMB",
        PossibleTypes = new [] { typeof(float) })]
        float? ScaleAndConcurrencyInstanceMemoryMb { get; set; }
        /// <summary>The maximum number of instances for the function app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number of instances for the function app.",
        SerializedName = @"maximumInstanceCount",
        PossibleTypes = new [] { typeof(float) })]
        float? ScaleAndConcurrencyMaximumInstanceCount { get; set; }
        /// <summary>Property to select Azure Storage type. Available options: blobContainer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to select Azure Storage type. Available options: blobContainer.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType? StorageType { get; set; }
        /// <summary>
        /// Property to set the URL for the selected Azure Storage type. Example: For blobContainer, the value could be https://<storageAccountName>.blob.core.windows.net/<containerName>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Property to set the URL for the selected Azure Storage type. Example: For blobContainer, the value could be https://<storageAccountName>.blob.core.windows.net/<containerName>.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string StorageValue { get; set; }

    }
    /// Function app configuration.
    internal partial interface IFunctionAppConfigInternal

    {
        /// <summary>
        /// Use this property for StorageAccountConnectionString. Set the name of the app setting that has the storage account connection
        /// string. Do not set a value for this property when using other authentication type.
        /// </summary>
        string AuthenticationStorageAccountConnectionStringName { get; set; }
        /// <summary>
        /// Property to select authentication type to access the selected storage account. Available options: SystemAssignedIdentity,
        /// UserAssignedIdentity, StorageAccountConnectionString.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AuthenticationType? AuthenticationType { get; set; }
        /// <summary>
        /// Use this property for UserAssignedIdentity. Set the resource ID of the identity. Do not set a value for this property
        /// when using other authentication type.
        /// </summary>
        string AuthenticationUserAssignedIdentityResourceId { get; set; }
        /// <summary>Function app deployment configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeployment Deployment { get; set; }
        /// <summary>Storage for deployed package used by the function app.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorage DeploymentStorage { get; set; }
        /// <summary>The maximum number of concurrent HTTP trigger invocations per instance.</summary>
        float? HttpPerInstanceConcurrency { get; set; }
        /// <summary>Function app runtime settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsRuntime Runtime { get; set; }
        /// <summary>
        /// Function app runtime name. Available options: dotnet-isolated, node, java, powershell, python, custom
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.RuntimeName? RuntimeName { get; set; }
        /// <summary>Function app runtime version. Example: 8 (for dotnet-isolated)</summary>
        string RuntimeVersion { get; set; }
        /// <summary>Function app scale and concurrency settings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrency ScaleAndConcurrency { get; set; }
        /// <summary>'Always Ready' configuration for the function app.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsAlwaysReadyConfig[] ScaleAndConcurrencyAlwaysReady { get; set; }
        /// <summary>
        /// Set the amount of memory allocated to each instance of the function app in MB. CPU and network bandwidth are allocated
        /// proportionally.
        /// </summary>
        float? ScaleAndConcurrencyInstanceMemoryMb { get; set; }
        /// <summary>The maximum number of instances for the function app.</summary>
        float? ScaleAndConcurrencyMaximumInstanceCount { get; set; }
        /// <summary>Scale and concurrency settings for the function app triggers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggers ScaleAndConcurrencyTrigger { get; set; }
        /// <summary>Authentication method to access the storage account for deployment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsDeploymentStorageAuthentication StorageAuthentication { get; set; }
        /// <summary>Property to select Azure Storage type. Available options: blobContainer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.FunctionsDeploymentStorageType? StorageType { get; set; }
        /// <summary>
        /// Property to set the URL for the selected Azure Storage type. Example: For blobContainer, the value could be https://<storageAccountName>.blob.core.windows.net/<containerName>.
        /// </summary>
        string StorageValue { get; set; }
        /// <summary>Scale and concurrency settings for the HTTP trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionsScaleAndConcurrencyTriggersHttp TriggerHttp { get; set; }

    }
}