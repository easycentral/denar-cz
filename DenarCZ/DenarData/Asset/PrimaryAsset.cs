using DenarData.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenarData.Asset
{
    public class PrimaryAsset : IDataItem
    {
        // Implementace vlastností z IDataItem
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }

        // Vlastnosti specifické pro PrimaryAsset
        public string Name { get; set; }
        public string Description { get; set; }
        public string AssetCategory { get; set; }
        public string Owner { get; set; }
        public int ConfidentialityRequirement { get; set; }
        public int IntegrityRequirement { get; set; }
        public int AvailabilityRequirement { get; set; }
        public List<Guid> SupportingAssetIds { get; set; }

        public PrimaryAsset()
        {
            Id = Guid.NewGuid();
            LastModified = DateTime.Now;
            Name = string.Empty;
            Description = string.Empty;
            AssetCategory = string.Empty;
            Owner = string.Empty;
            SupportingAssetIds = new List<Guid>();
        }

        public int Criticality => Math.Max(ConfidentialityRequirement,
                                  Math.Max(IntegrityRequirement, AvailabilityRequirement));

        public IDataItem GetSaveData()
        {
            var copy = (PrimaryAsset)this.MemberwiseClone();
            copy.SupportingAssetIds = new List<Guid>(this.SupportingAssetIds);
            return copy;
        }

        public int Load(IDataItem item)
        {
            if (item is PrimaryAsset source)
            {
                this.Id = source.Id;
                this.LastModified = source.LastModified;
                this.Name = source.Name;
                this.Description = source.Description;
                this.AssetCategory = source.AssetCategory;
                this.Owner = source.Owner;
                this.ConfidentialityRequirement = source.ConfidentialityRequirement;
                this.IntegrityRequirement = source.IntegrityRequirement;
                this.AvailabilityRequirement = source.AvailabilityRequirement;
                this.SupportingAssetIds = source.SupportingAssetIds != null
                    ? new List<Guid>(source.SupportingAssetIds)
                    : new List<Guid>();
                return 0;
            }
            return -1;
        }
    }
}
