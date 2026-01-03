using DenarData.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenarCZ.Data
{
    public class AppConfig : IAppConfiguration
    {
        private static AppConfig _instance;
        private static readonly object _lock = new object();

        // Singleton přístup
        public static AppConfig Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new AppConfig();
                    return _instance;
                }
            }
        }

        // Data konfigurace
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string RootDataPath { get; set; } = string.Empty;
        public string DataFileName { get; set; } = "";
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


        // Soukromý konstruktor
        private AppConfig()
        {
            Id = Guid.NewGuid(); // Konfigurace má obvykle pevné ID nebo se s ním nepracuje jako s entitou
            LastModified = DateTime.Now;
        }

        // Implementace IDataItem
        public IDataItem GetSaveData()
        {
            AppConfigSave saveData = new AppConfigSave
            {
                Id = this.Id,
                OrganizationName = this.OrganizationName,
                LastModified = this.LastModified,
                AssetCategories = this.AssetCategories,
                ConfidentialityLevels = this.ConfidentialityLevels,
                IntegrityLevels = this.IntegrityLevels,
                AvailabilityLevels = this.AvailabilityLevels,
                ConfidentialityLabels = this.ConfidentialityLabels,
                IntegrityLabels = this.IntegrityLabels,
                AvailabilityLabels = this.AvailabilityLabels,
                CriticalityLevels = this.CriticalityLevels,
                CriticalityLabels = this.CriticalityLabels

            };
            return saveData;
        } 

        public int Load(IDataItem item)
        {
            if (item is AppConfigSave source)
            {
                //this.RootDataPath = source.RootDataPath;
                this.OrganizationName = source.OrganizationName;
                this.LastModified = source.LastModified;
                this.AssetCategories = source.AssetCategories;
                this.ConfidentialityLevels = source.ConfidentialityLevels;
                this.IntegrityLevels = source.IntegrityLevels;
                this.AvailabilityLevels = source.AvailabilityLevels;
                this.ConfidentialityLabels = source.ConfidentialityLabels;
                this.IntegrityLabels = source.IntegrityLabels;
                this.AvailabilityLabels = source.AvailabilityLabels;
                this.CriticalityLabels = source.CriticalityLabels;
                this.CriticalityLevels = source.CriticalityLevels;

                return 0;
            }
            return -1;
        }

        // Pomocná metoda pro inicializaci cest
        public void Initialize(string configFilePath)
        {
            RootDataPath = Path.GetDirectoryName(configFilePath);
            DataFileName = Path.GetFileName(configFilePath);
            // Zde můžeme automaticky vytvořit podsložky, pokud neexistují
            Directory.CreateDirectory(Path.Combine(RootDataPath, "PrimaryAssets"));
            Directory.CreateDirectory(Path.Combine(RootDataPath, "SupportingAssets"));
            Directory.CreateDirectory(Path.Combine(RootDataPath, "Risks"));
        }

        public Type getType()
        {
            return typeof(AppConfig);
        }
    }
}
