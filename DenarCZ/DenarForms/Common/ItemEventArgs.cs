using DenarData.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenarForms.Common
{
    public sealed class ItemEventArgs : EventArgs
    {
        
        public IDataItem? Item { get;}
        public ItemEventArgs(IDataItem item)
        {
            Item=item;
        }
    }
}
