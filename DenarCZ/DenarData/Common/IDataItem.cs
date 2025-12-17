using System;
using System.Collections.Generic;
using System.Text;

namespace DenarData.Common
{
    public interface IDataItem
    {
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; } // Pro detekci konfliktů
        public IDataItem GetSaveData();
        public int Load(IDataItem item);
    }
}
