using DenarCZ.Data;
using DenarData.Asset;
using DenarData.Common;
using DenarData.Lookup;
using DenarForms.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Grids
{
    public class SupportingAssetsGrid : DataListControl<SupportingAsset>
    {
        public SupportingAssetsGrid(EntityManager<SupportingAsset> manager) : base(manager)
        {
        }

        public override EntityManager<SupportingAsset> GetEntityManager<SupportingAsset>()
        {
            return base.GetEntityManager<SupportingAsset>();
        }

        protected override string GetDeleteConfirmationMessage()
        {
            return "Opravdu chcete smazat vybrané podpůrné aktivum?";
        }

        protected override IDataItem NewItem()
        {
            return new SupportingAsset();
        }

        public override void ConfigureGrid()
        {
            base.ConfigureGrid();
            grdData.Columns["LastModified"].ReadOnly = true;
            grdData.Columns["Description"].Visible = false;

            // Převést sloupec AssetType na ComboBox
            ConfigureComboBoxColumn("AssetType", "Typ aktiva", AppConfig.Instance.SupportingAssetTypes.Split(';'));

            // ošetři DataError
            grdData.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void ConfigureComboBoxColumn(string columnName, string headerText, string[] items)
        {
            int columnIndex = grdData.Columns[columnName].DisplayIndex;
            grdData.Columns.Remove(columnName);

            var col = new DataGridViewComboBoxColumn
            {
                Name = columnName,
                DisplayIndex = columnIndex,
                HeaderText = headerText,
                DataPropertyName = columnName
            };
            col.Items.AddRange(items);
            grdData.Columns.Add(col);
        }

        protected override void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.grdData_CellValidating(sender, e);
            // Vlastní validace pro SupportingAsset
        }
    }
}
