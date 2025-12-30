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
