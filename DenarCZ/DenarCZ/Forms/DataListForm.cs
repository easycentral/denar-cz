using DenarData.Common;
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
            
            
            


        }
        public void OpenDetailForm(IDataItem item)
        {
            DataDetailForm detailForm = new DataDetailForm
            {
                Text = "Detail",
                DataItem = item
            };
            detailForm.MdiParent = this.MdiParent;
            detailForm.Show();
        }
    }
}
