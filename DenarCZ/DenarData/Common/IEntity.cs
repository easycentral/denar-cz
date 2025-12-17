using System;
using System.Collections.Generic;
using System.Text;

namespace DenarData.Common
{
    public interface IEntity
    {
        string Name { get; set; }
        string FolderPath { get; set; }
        Dictionary<Guid, IDataItem> Items { get; set; }

        int LoadAll();                  // Načte celou složku při startu/refreshi
        int SaveItem(IDataItem item);    // Uloží jeden konkrétní záznam (s kontrolou)
        int DeleteItem(Guid id);        // Smaže soubor z disku i ze slovníku
    }
}
