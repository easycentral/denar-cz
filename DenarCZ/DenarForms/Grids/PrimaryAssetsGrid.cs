using DenarData.Asset;
using DenarData.Common;
using DenarForms.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Grids
{
    public class PrimaryAssetsGrid : DataListControl<PrimaryAsset>
    {
        public PrimaryAssetsGrid(EntityManager<PrimaryAsset> manager) : base(manager)
        {
        }

        public override void ConfigureGrid()
        {
            base.ConfigureGrid();
            // Zde můžete přidat další konfigurace specifické pro PrimaryAsset, pokud je potřeba
            grdData.Columns["Id"].HeaderText = "ID";
            grdData.Columns["LastModified"].HeaderText = "Upraveno";
            grdData.Columns["LastModified"].ReadOnly = true;
            grdData.Columns["Name"].HeaderText = "Název aktiva";
            grdData.Columns["Description"].Visible = false;
            grdData.Columns["AssetCategory"].HeaderText = "Kategorie";
            grdData.Columns["Owner"].HeaderText = "Garant";
            grdData.Columns["ConfidentialityRequirement"].HeaderText = "Důvěrnost";
            grdData.Columns["IntegrityRequirement"].HeaderText = "Integrita";
            grdData.Columns["AvailabilityRequirement"].HeaderText = "Dostupnost";
            grdData.Columns["Criticality"].HeaderText = "Kritičnost";

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
    }
}
