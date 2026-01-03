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

        public override void ConfigureGrid()
        {
            base.ConfigureGrid();
            grdData.Columns["LastModified"].ReadOnly = true;
            grdData.Columns["Description"].Visible = false;

            // Zde můžete přidat další konfigurace specifické pro PrimaryAsset, pokud je potřeba


            // Převést sloupec AssetCategory na ComboBox s hodnotami z konfigurace
            int assetCategoryColumnIndex = grdData.Columns["AssetCategory"].DisplayIndex;
            grdData.Columns.Remove("AssetCategory");
            var col = new DataGridViewComboBoxColumn
            {
                Name = "AssetCategory",
                DisplayIndex = assetCategoryColumnIndex,
                HeaderText = "Kategorie aktiva",
                DataPropertyName = "AssetCategory" 
            };

            // statické hodnoty
            col.Items.AddRange(AppConfig.Instance.AssetCategories.Split(';'));

            // přidat do gridu
            grdData.Columns.Add(col);


            // Převést sloupec ConfidentialityRequirement na ComboBox s hodnotami z konfigurace
            int confColumnIndex = grdData.Columns["ConfidentialityRequirement"].DisplayIndex;
            grdData.Columns.Remove("ConfidentialityRequirement");

            var levels = LookupProvider.GetLevelLabels(
                AppConfig.Instance.ConfidentialityLevels,  
                AppConfig.Instance.ConfidentialityLabels   
            );

            var dataSource = levels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();

            var conf = new DataGridViewComboBoxColumn
            {
                Name = "ConfidentialityRequirement",
                HeaderText = "Důvěrnost",
                DataPropertyName = "ConfidentialityRequirement", 
                DataSource = dataSource,
                ValueMember = "Value",    // uloží se číslo (int)
                DisplayMember = "Label",  // zobrazí se text
                //DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                //FlatStyle = FlatStyle.Flat,
                DisplayIndex = confColumnIndex
            };

            
            grdData.Columns.Add(conf);

            // Převést sloupec IntegrityRequirement na ComboBox s hodnotami z konfigurace
            int integColumnIndex = grdData.Columns["IntegrityRequirement"].DisplayIndex;
            grdData.Columns.Remove("IntegrityRequirement");

            var integlevels = LookupProvider.GetLevelLabels(
                AppConfig.Instance.IntegrityLevels,
                AppConfig.Instance.IntegrityLabels
            );

            var integdataSource = integlevels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();

            var integ = new DataGridViewComboBoxColumn
            {
                Name = "IntegrityRequirement",
                HeaderText = "Integrita",
                DataPropertyName = "IntegrityRequirement",
                DataSource = integdataSource,
                ValueMember = "Value",    // uloží se číslo (int)
                DisplayMember = "Label",  // zobrazí se text
                //DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                //FlatStyle = FlatStyle.Flat,
                DisplayIndex = integColumnIndex
            };
                        
            grdData.Columns.Add(integ);
            // Převést sloupec AvailabilityRequirement na ComboBox s hodnotami z konfigurace
            int availColumnIndex = grdData.Columns["AvailabilityRequirement"].DisplayIndex;
            grdData.Columns.Remove("AvailabilityRequirement");
            var availlevels = LookupProvider.GetLevelLabels(
                AppConfig.Instance.AvailabilityLevels,
                AppConfig.Instance.AvailabilityLabels
            );
            var availdataSource = availlevels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();
            var avail = new DataGridViewComboBoxColumn
            {
                Name = "AvailabilityRequirement",
                HeaderText = "Dostupnost",
                DataPropertyName = "AvailabilityRequirement",
                DataSource = availdataSource,
                ValueMember = "Value",    // uloží se číslo (int)
                DisplayMember = "Label",  // zobrazí se text
                //DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                //FlatStyle = FlatStyle.Flat,
                DisplayIndex = availColumnIndex
            };
            grdData.Columns.Add(avail);


            // Převést sloupec Criticality na ComboBox s hodnotami z konfigurace
            int critColumnIndex = grdData.Columns["Criticality"].DisplayIndex;
            grdData.Columns.Remove("Criticality");
            var critlevels = LookupProvider.GetLevelLabels(
                AppConfig.Instance.CriticalityLevels,
                AppConfig.Instance.CriticalityLabels
            );
            var critdataSource = critlevels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();
            var crit = new DataGridViewComboBoxColumn
            {
                Name = "Criticality",
                HeaderText = "Kritičnost",
                DataPropertyName = "Criticality",
                DataSource = critdataSource,
                ValueMember = "Value",    // uloží se číslo (int)
                DisplayMember = "Label",  // zobrazí se text
                //DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
                //FlatStyle = FlatStyle.Flat,
                DisplayIndex = critColumnIndex,
                ReadOnly = true

            };
            grdData.Columns.Add(crit);



            // ošetři DataError (když v datech je hodnota, která v nabídce není)
            grdData.DataError += (s, e) => { e.ThrowException = false; };



            
        }
        protected override void grdData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            base.grdData_UserAddedRow(sender, e);
            // Při přidání nového řádku můžeme nastavit výchozí hodnoty
            //var newRow = e.Row.DataBoundItem as PrimaryAsset;
            var newRow = new PrimaryAsset();
            
            if (newRow != null)
            {
                newRow.Id= Guid.NewGuid();
                newRow.LastModified = DateTime.Now;
                SaveRow(newRow);
            }
        }
        protected override void grdData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            base.grdData_RowValidated(sender, e);
            if (grdData.ReadOnly)
            {
                return;
            }
            // Při validaci řádku můžeme aktualizovat čas poslední úpravy
            var row = grdData.Rows[e.RowIndex];
            var item = row.DataBoundItem as PrimaryAsset;
            if (item != null)
            {
                item.LastModified = DateTime.Now;
                SaveRow(item);
                
            }

        }

        protected override void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.grdData_CellValidating(sender, e);
            // Příklad vlastní validace: Název aktiva nesmí být prázdný
            
        }

        protected override void grdData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (grdData.ReadOnly)             {
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("Opravdu chcete smazat vybrané aktivum?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            //base.grdData_UserDeletingRow(sender, e);
            var row = e.Row;
            var item = row.DataBoundItem as PrimaryAsset;
            if (item != null)
            {
                DeleteRow(item);
            }
        }

        protected override IDataItem NewItem()
        {
            return new PrimaryAsset();
            
        }

    }
}
