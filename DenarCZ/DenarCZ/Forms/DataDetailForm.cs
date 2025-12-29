using DenarData.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DenarCZ.Forms
{
    public partial class DataDetailForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IDataItem DataItem { get; set; }
        public DataDetailForm()
        {
            InitializeComponent();
        }
    }
}
