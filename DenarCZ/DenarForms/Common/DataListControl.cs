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
    public partial class DataListControl<T> : dataList where T : class, IDataItem, new()
    {
        private EntityManager<T> _manager;
        private BindingSource _bindingSource = new BindingSource();
        

        public DataListControl(EntityManager<T> manager)
        {
            InitializeComponent(); // Standardní WinForms inicializace
            _manager = manager;
            SetupGrid();
        }

        private void SetupGrid()
        {
            grdData.AutoGenerateColumns = true;
            
            RefreshData();
            grdData.DataSource = _bindingSource;

            // Můžeme skrýt sloupce, které uživatel nemusí vidět (např. Guid)
            if (grdData.Columns.Contains("Id"))
                grdData.Columns["Id"].Visible = false;
            
            ConfigureGrid();
        }

        public void RefreshData()
        {
            // Převod Dictionary na List pro BindingSource
            _bindingSource.DataSource = _manager.Items.Values.ToList();
        }

        public virtual void ConfigureGrid()
        {
            // Metoda pro další konfiguraci mřížky, může být přepsána v odvozených třídách
        }



    }
}
