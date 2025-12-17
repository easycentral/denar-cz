using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace DenarData.Common
{
    public class EntityManager<T> where T : class, IDataItem, new()
    {
        public string FolderPath { get; private set; }
        public Dictionary<Guid, T> Items { get; private set; } = new Dictionary<Guid, T>();

        public EntityManager(string rootPath, string entityFolderName)
        {
            FolderPath = Path.Combine(rootPath, entityFolderName);
        }

        public void SetPath(string rootPath, string entityFolderName)
        {
            FolderPath = Path.Combine(rootPath, entityFolderName);
        }

        public int LoadAll()
        {
            try
            {
                if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);

                Items.Clear();
                string[] files = Directory.GetFiles(FolderPath, "*.json");

                foreach (string file in files)
                {
                    string jsonString = File.ReadAllText(file);
                    T item = JsonSerializer.Deserialize<T>(jsonString);

                    if (item != null)
                    {
                        Items.Add(item.Id, item);
                    }
                }
                return Items.Count;
            }
            catch { return -1; }
        }

        public int SaveItem(T item)
        {
            try
            {
                string fileName = Path.Combine(FolderPath, $"{item.Id}.json");

                // Ochrana proti přepsání (Optimistické zamykání)
                if (File.Exists(fileName))
                {
                    DateTime diskTime = File.GetLastWriteTime(fileName);
                    if (diskTime > item.LastModified.AddMilliseconds(500))
                    {
                        return -2; // Konflikt: Na disku je novější verze
                    }
                }

                item.LastModified = DateTime.Now;
                var dataToSave = item.GetSaveData();
                string jsonString = JsonSerializer.Serialize(dataToSave, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(fileName, jsonString);

                // Aktualizace v paměti (pokud tam ještě není)
                Items[item.Id] = item;

                return 0;
            }
            catch { return -1; }
        }

        public int DeleteItem(Guid id)
        {
            try
            {
                string fileName = Path.Combine(FolderPath, $"{id}.json");

                if (File.Exists(fileName))
                    File.Delete(fileName);

                if (Items.ContainsKey(id))
                    Items.Remove(id);

                return 0;
            }
            catch { return -1; }
        }
    }
}
