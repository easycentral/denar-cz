using DenarData.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenarCZ.Data
{
    public interface IAppConfiguration : IDataItem
    {
        string RootDataPath { get; set; }
        string OrganizationName { get; set; }
        
    }
}
