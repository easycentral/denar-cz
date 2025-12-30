using DenarData.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Common
{
    public partial class DataDetailControl<T> : BaseDataDetailControl where T : class, IDataItem, new()
    {
        private EntityManager<T> _manager;
        private IDataItem _item;
        public DataDetailControl(EntityManager<T> manager, IDataItem item)
        {
            InitializeComponent();
            _manager = manager;
            _item = item;
            SetupGrid();

        }

        private void SetupGrid()
        {

            grdData.SelectedObject = _item;
            grdData.Visible = true;
            grdData.BringToFront();
            grdData.Refresh();
            // Můžeme skrýt sloupce, které uživatel nemusí vidět (např. Guid)
            //if (grdData.Columns.Contains("Id"))
            //    grdData.Columns["Id"].Visible = false;
            //ConfigureGrid();
        }

        public virtual void ConfigureGrid()
        {
            // Metoda pro další konfiguraci mřížky, může být přepsána v odvozených třídách
        }
    }
}
