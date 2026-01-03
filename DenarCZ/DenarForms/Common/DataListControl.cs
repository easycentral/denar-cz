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
    public abstract partial class DataListControl<T> : BaseDataListControl where T : class, IDataItem, new()
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
            
            // Přihlásit se k události pro nastavení výchozích hodnot
            grdData.DefaultValuesNeeded += GrdData_DefaultValuesNeeded;
            
            ConfigureGrid();
        }

        private void GrdData_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Tato událost se volá při vytváření nového řádku
            // Nastavíme výchozí hodnoty pro nový objekt
            e.Row.Cells["Id"].Value = Guid.NewGuid();
            e.Row.Cells["LastModified"].Value = DateTime.Now;
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

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            T? selectedItem = SelectedItem;
            if (selectedItem is null) return;

            // Vyvolej událost přes base raising metodu
            OnEditItemRequested(new ItemEventArgs(selectedItem));
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            // Kontrola readonly režimu
            if (grdData.ReadOnly)
            {
                MessageBox.Show("Nelze mazat v režimu pouze pro čtení.", "Upozornění", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Získat vybranou položku
            T? selectedItem = SelectedItem;
            if (selectedItem is null)
            {
                MessageBox.Show("Není vybrána žádná položka ke smazání.", "Upozornění", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Získej potvrzovací zprávu z odvozené třídy
            string confirmationMessage = GetDeleteConfirmationMessage();
            
            // Potvrzení smazání
            if (MessageBox.Show(confirmationMessage, "Potvrzení smazání", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            // Smazat položku
            DeleteRow(selectedItem);
        }

        // ========== Společné handlery pro všechny gridy ==========

        protected override void grdData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            base.grdData_UserAddedRow(sender, e);
            
            // Získat přidaný objekt z DataBoundItem
            var newItem = e.Row.DataBoundItem as T;
            if (newItem != null)
            {
                // Uložit nový záznam
                SaveRow(newItem);
            }
        }

        protected override void grdData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            base.grdData_RowValidated(sender, e);
            if (grdData.ReadOnly)
            {
                return;
            }

            // Kontrola platnosti indexu řádku a existence DataBoundItem
            if (e.RowIndex < 0 || e.RowIndex >= grdData.Rows.Count)
            {
                return;
            }

            try
            {
                var row = grdData.Rows[e.RowIndex];

                // Kontrola, zda řádek má platné DataBoundItem (může být null během RefreshData)
                if (row.DataBoundItem == null)
                {
                    return;
                }

                var item = row.DataBoundItem as T;
                if (item != null)
                {
                    item.LastModified = DateTime.Now;
                    SaveRow(item);
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected override void grdData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (grdData.ReadOnly)
            {
                e.Cancel = true;
                return;
            }
            
            // Získej potvrzovací zprávu z odvozené třídy
            string confirmationMessage = GetDeleteConfirmationMessage();
            
            if (MessageBox.Show(confirmationMessage, "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            
            var row = e.Row;
            var item = row.DataBoundItem as T;
            if (item != null)
            {
                DeleteRow(item);
            }
        }

        // ========== Abstraktní/virtuální metody pro přizpůsobení ==========

        /// <summary>
        /// Vrací potvrzovací zprávu pro mazání položky. Může být přepsána v odvozených třídách.
        /// </summary>
        protected virtual string GetDeleteConfirmationMessage()
        {
            return "Opravdu chcete smazat vybranou položku?";
        }
    }
}