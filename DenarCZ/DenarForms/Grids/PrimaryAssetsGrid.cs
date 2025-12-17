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
            grdData.Columns["Name"].HeaderText = "Název aktiva";
            grdData.Columns["Description"].Visible = false;
            grdData.Columns["AssetCategory"].HeaderText = "Kategorie";
            grdData.Columns["Owner"].HeaderText = "Garant";
            grdData.Columns["ConfidentialityRequirement"].HeaderText = "Důvěrnost";
            grdData.Columns["IntegrityRequirement"].HeaderText = "Integrita";
            grdData.Columns["AvailabilityRequirement"].HeaderText = "Dostupnost";
            grdData.Columns["Criticality"].HeaderText = "Kritičnost";






        }
    }
}
