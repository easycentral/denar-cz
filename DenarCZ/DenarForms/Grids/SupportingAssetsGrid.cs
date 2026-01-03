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
            int assetTypeColumnIndex = grdData.Columns["AssetType"].DisplayIndex;
            grdData.Columns.Remove("AssetType");
            
            var col = new DataGridViewComboBoxColumn
            {
                Name = "AssetType",
                DisplayIndex = assetTypeColumnIndex,
                HeaderText = "Typ aktiva",
                DataPropertyName = "AssetType"
            };
            col.Items.AddRange(new string[] { "Hardware", "Software", "Síť", "Personál", "Prostory", "Data", "Dokumenty" });
            grdData.Columns.Add(col);

            // ošetři DataError
            grdData.DataError += (s, e) => { e.ThrowException = false; };
        }

        protected override void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.grdData_CellValidating(sender, e);
            // Vlastní validace pro SupportingAsset
        }
    }
}
