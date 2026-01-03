using DenarData.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Common
{
    public partial class BaseDataDetailControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public object EditedItem { get; set; } = null;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AssetCategories? AssetCategories { get; set; }
        public BaseDataDetailControl()
        {
            InitializeComponent();
        }

        protected virtual void grdData_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            grdData.Refresh();
        }
    }
}
