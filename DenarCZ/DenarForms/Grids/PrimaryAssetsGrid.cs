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
    public class PrimaryAssetsGrid : DataListControl<PrimaryAsset>
    {
        public PrimaryAssetsGrid(EntityManager<PrimaryAsset> manager) : base(manager)
        {
        }

        public override EntityManager<PrimaryAsset> GetEntityManager<PrimaryAsset>()
        {
            return base.GetEntityManager<PrimaryAsset>();
        }

        protected override string GetDeleteConfirmationMessage()
        {
            return "Opravdu chcete smazat vybrané aktivum?";
        }

        protected override IDataItem NewItem()
        {
            return new PrimaryAsset();
        }

        public override void ConfigureGrid()
        {
            base.ConfigureGrid();
            grdData.Columns["LastModified"].ReadOnly = true;
            grdData.Columns["Description"].Visible = false;

            // Převést sloupec AssetCategory na ComboBox s hodnotami z konfigurace
            ConfigureComboBoxColumn("AssetCategory", "Kategorie aktiva", 
                AppConfig.Instance.AssetCategories.Split(';'));

            // Převést sloupce pro hodnocení CIA
            ConfigureLevelColumn("ConfidentialityRequirement", "Důvěrnost",
                AppConfig.Instance.ConfidentialityLevels, AppConfig.Instance.ConfidentialityLabels);

            ConfigureLevelColumn("IntegrityRequirement", "Integrita",
                AppConfig.Instance.IntegrityLevels, AppConfig.Instance.IntegrityLabels);

            ConfigureLevelColumn("AvailabilityRequirement", "Dostupnost",
                AppConfig.Instance.AvailabilityLevels, AppConfig.Instance.AvailabilityLabels);

            ConfigureLevelColumn("Criticality", "Kritičnost",
                AppConfig.Instance.CriticalityLevels, AppConfig.Instance.CriticalityLabels, true);

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

        private void ConfigureLevelColumn(string columnName, string headerText, 
            string levels, string labels, bool readOnly = false)
        {
            int columnIndex = grdData.Columns[columnName].DisplayIndex;
            grdData.Columns.Remove(columnName);

            var levelLabels = LookupProvider.GetLevelLabels(levels, labels);
            var dataSource = levelLabels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();

            var col = new DataGridViewComboBoxColumn
            {
                Name = columnName,
                HeaderText = headerText,
                DataPropertyName = columnName,
                DataSource = dataSource,
                ValueMember = "Value",
                DisplayMember = "Label",
                DisplayIndex = columnIndex,
                ReadOnly = readOnly
            };

            grdData.Columns.Add(col);
        }

        protected override void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.grdData_CellValidating(sender, e);
            // Vlastní validace pro PrimaryAsset
        }
    }
}
