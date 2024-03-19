// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureSample.ResourceManager.Storage.Models
{
    /// <summary> Management policy action for snapshot. </summary>
    public partial class ManagementPolicySnapShot
    {
        /// <summary> Initializes a new instance of <see cref="ManagementPolicySnapShot"/>. </summary>
        public ManagementPolicySnapShot()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementPolicySnapShot"/>. </summary>
        /// <param name="tierToCool"> The function to tier blob snapshot to cool storage. Support blob snapshot currently at Hot tier. </param>
        /// <param name="tierToArchive"> The function to tier blob snapshot to archive storage. Support blob snapshot currently at Hot or Cool tier. </param>
        /// <param name="delete"> The function to delete the blob snapshot. </param>
        internal ManagementPolicySnapShot(DateAfterCreation tierToCool, DateAfterCreation tierToArchive, DateAfterCreation delete)
        {
            TierToCool = tierToCool;
            TierToArchive = tierToArchive;
            Delete = delete;
        }

        /// <summary> The function to tier blob snapshot to cool storage. Support blob snapshot currently at Hot tier. </summary>
        internal DateAfterCreation TierToCool { get; set; }
        /// <summary> Value indicating the age in days after creation. </summary>
        public float? TierToCoolDaysAfterCreationGreaterThan
        {
            get => TierToCool is null ? default(float?) : TierToCool.DaysAfterCreationGreaterThan;
            set
            {
                TierToCool = value.HasValue ? new DateAfterCreation(value.Value) : null;
            }
        }

        /// <summary> The function to tier blob snapshot to archive storage. Support blob snapshot currently at Hot or Cool tier. </summary>
        internal DateAfterCreation TierToArchive { get; set; }
        /// <summary> Value indicating the age in days after creation. </summary>
        public float? TierToArchiveDaysAfterCreationGreaterThan
        {
            get => TierToArchive is null ? default(float?) : TierToArchive.DaysAfterCreationGreaterThan;
            set
            {
                TierToArchive = value.HasValue ? new DateAfterCreation(value.Value) : null;
            }
        }

        /// <summary> The function to delete the blob snapshot. </summary>
        internal DateAfterCreation Delete { get; set; }
        /// <summary> Value indicating the age in days after creation. </summary>
        public float? DeleteDaysAfterCreationGreaterThan
        {
            get => Delete is null ? default(float?) : Delete.DaysAfterCreationGreaterThan;
            set
            {
                Delete = value.HasValue ? new DateAfterCreation(value.Value) : null;
            }
        }
    }
}