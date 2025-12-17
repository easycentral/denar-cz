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
                LastModified = this.LastModified
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
    }
}
