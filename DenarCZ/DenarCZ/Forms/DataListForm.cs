using DenarData.Asset;
using DenarData.Common;
using DenarForms.Common;
using DenarForms.Details;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DenarCZ.Forms
{
    public partial class DataListForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<IDataItem> DataItems { get; set; } = new List<IDataItem>();
        
        public DataListForm()
        {
            InitializeComponent();
        }

        private void DataListForm_Load(object sender, EventArgs e)
        {
            if (pnlData.Controls.Count > 0)
            {
                BaseDataListControl grd = (BaseDataListControl) pnlData.Controls[0];
                grd.NewItemRequested += (s, ea) =>
                {
                    var itemType = ea.Item.GetType();
                    
                    switch (itemType.Name)
                    {
                        case "PrimaryAsset":
                            var em = grd.GetEntityManager<PrimaryAsset>();
                            OpenDetailForm(em, ea.Item as PrimaryAsset);
                            break;
                        // Add cases for other IDataItem implementations as needed
                        default:
                            
                            break;
                    }

                    //
                };
            }
            
            


        }
        public void OpenDetailForm<T>(EntityManager<T> manager, IDataItem item)
            where T : class, IDataItem, new()
        {
            DataDetailForm detailForm = new DataDetailForm
            {
                Text = "Detail",
                DataItem = item
            };
            detailForm.MdiParent = this.MdiParent;
            var itemType = item.GetType();
            switch (itemType.Name)
            {
                case "PrimaryAsset":
                    pnlData.Controls.Add(new PrimaryAssetDetail(manager as EntityManager<PrimaryAsset>,item));
                    break;
                // Add cases for other IDataItem implementations as needed
                default:

                    break;
            }
            
            detailForm.Show();
        }
    }
}
