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
    public partial class DataListControl<T> : BaseDataListControl where T : class, IDataItem, new()
    {
        private EntityManager<T> _manager;
        private BindingSource _bindingSource = new BindingSource();
        private BindingList<T>? _list;


        public DataListControl(EntityManager<T> manager)
        {
            InitializeComponent(); // Standardní WinForms inicializace
            _manager = manager;
            SetupGrid();
        }

        public override EntityManager<TItem> GetEntityManager<TItem>()
        {
            // Ověření, že TItem odpovídá T
            if (typeof(TItem) != typeof(T))
                throw new InvalidOperationException("Typ TItem musí odpovídat typu T použitému v DataListControl.");

            // Přetypování na správný generický typ
            return (EntityManager<TItem>)(object)_manager;
        }

        public void BindData(IDictionary<Guid, IDataItem> dict)
        {
            // Bezpečně proměnit na T (jen ty prvky, které jsou T)
            var items = dict.Values.OfType<T>().ToList();
            _list = new BindingList<T>(items);

            // Napojit na grid přes Base
            BindList(_list);
        }

        public T? SelectedItem => grdData.CurrentRow?.DataBoundItem as T;

        /// <summary>
        /// Vrátí editovaný BindingList<T> (po commitnutí změn).
        /// </summary>
        public BindingList<T> GetEditedList()
        {
            CommitEdits();
            return _list ?? new BindingList<T>();
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

        public void SaveRow(T item)
        {
            _manager.SaveItem(item);
        }

        public virtual void ConfigureGrid()
        {
            // Metoda pro další konfiguraci mřížky, může být přepsána v odvozených třídách
        }

        public void DeleteRow(T item)
        {
            _manager.DeleteItem(item.Id);
            RefreshData();
        }




    }
}
