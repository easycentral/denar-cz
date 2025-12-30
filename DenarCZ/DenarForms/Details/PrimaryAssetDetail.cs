using DenarData.Asset;
using DenarData.Common;
using DenarForms.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Details
{
    public partial class PrimaryAssetDetail : DataDetailControl<PrimaryAsset>
    {
        public PrimaryAssetDetail(EntityManager<PrimaryAsset> manager, IDataItem item) : base(manager,item)
        {

            
        }

    }
}
