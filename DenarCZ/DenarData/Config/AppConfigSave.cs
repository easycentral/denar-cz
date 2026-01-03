using DenarData.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenarCZ.Data
{
    public class AppConfigSave : IDataItem
    {
        // Data konfigurace
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        //public string RootDataPath { get; set; } = string.Empty;
        public string OrganizationName { get; set; } = string.Empty;
        public string AssetCategories { get; set; } = string.Empty;
        public string ConfidentialityLevels { get; set; } = string.Empty;
        public string IntegrityLevels { get; set; } = string.Empty;
        public string AvailabilityLevels { get; set; } = string.Empty;
        public string ConfidentialityLabels { get; set; } = string.Empty;
        public string IntegrityLabels { get; set; } = string.Empty;
        public string AvailabilityLabels { get; set; } = string.Empty;
        public string CriticalityLevels { get; set; } = string.Empty;
        public string CriticalityLabels { get; set; } = string.Empty;
        public string SupportingAssetTypes { get; set; } = string.Empty;

        public IDataItem GetSaveData() => (AppConfigSave)this.MemberwiseClone();
        public int Load(IDataItem item)
        {
            if (item is AppConfigSave source)
            {
                this.Id = source.Id;
                this.OrganizationName = source.OrganizationName;
                this.LastModified = source.LastModified;
                return 0;
            }
            return -1;
        }

        public Type getType()
        {
            return typeof(AppConfigSave);
        }
    }
}
