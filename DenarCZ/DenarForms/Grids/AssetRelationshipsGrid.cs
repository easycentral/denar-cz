using DenarCZ.Data;
using DenarData.Asset;
using DenarData.Common;
using DenarData.Lookup;
using DenarForms.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DenarForms.Grids
{
    public class AssetRelationshipsGrid : DataListControl<AssetRelationship>
    {
        private EntityManager<PrimaryAsset> _primaryAssetManager;
        private EntityManager<SupportingAsset> _supportingAssetManager;

        public AssetRelationshipsGrid(
            EntityManager<AssetRelationship> manager,
            EntityManager<PrimaryAsset> primaryAssetManager,
            EntityManager<SupportingAsset> supportingAssetManager) : base(manager)
        {
            _primaryAssetManager = primaryAssetManager;
            _supportingAssetManager = supportingAssetManager;
        }

        public override EntityManager<AssetRelationship> GetEntityManager<AssetRelationship>()
        {
            return base.GetEntityManager<AssetRelationship>();
        }

        protected override string GetDeleteConfirmationMessage()
        {
            return "Opravdu chcete smazat vybranou vazbu mezi aktivy?";
        }

        protected override IDataItem NewItem()
        {
            return new AssetRelationship();
        }

        public override void ConfigureGrid()
        {
            base.ConfigureGrid();
            
            grdData.Columns["LastModified"].ReadOnly = true;
            grdData.Columns["Description"].Visible = false;
            
            // Skrýt ID sloupce
            grdData.Columns["PrimaryAssetId"].Visible = false;
            grdData.Columns["SupportingAssetId"].Visible = false;
            
            // Nastavit názvy sloupcù pouze pro ètení
            grdData.Columns["PrimaryAssetName"].HeaderText = "Primární aktivum";
            grdData.Columns["PrimaryAssetName"].ReadOnly = true;
            grdData.Columns["PrimaryAssetName"].Width = 200;

            grdData.Columns["SupportingAssetName"].HeaderText = "Podpùrné aktivum";
            grdData.Columns["SupportingAssetName"].ReadOnly = true;
            grdData.Columns["SupportingAssetName"].Width = 200;

            // Pøevést sloupec RelationshipType na ComboBox
            int relationshipTypeIndex = grdData.Columns["RelationshipType"].DisplayIndex;
            grdData.Columns.Remove("RelationshipType");
            var col = new DataGridViewComboBoxColumn
            {
                Name = "RelationshipType",
                DisplayIndex = relationshipTypeIndex,
                HeaderText = "Typ vazby",
                DataPropertyName = "RelationshipType"
            };
            col.Items.AddRange(AppConfig.Instance.RelationshipTypes.Split(';'));
            grdData.Columns.Add(col);

            // Pøevést Importance na ComboBox s úrovnìmi
            int importanceIndex = grdData.Columns["Importance"].DisplayIndex;
            grdData.Columns.Remove("Importance");
            
            var levels = LookupProvider.GetLevelLabels("1;2;3;4", "Nízká;Støední;Vysoká;Kritická");
            var dataSource = levels.Select(x => new { Value = x.Value, Label = x.Label }).ToList();

            var importance = new DataGridViewComboBoxColumn
            {
                Name = "Importance",
                HeaderText = "Dùležitost",
                DataPropertyName = "Importance",
                DataSource = dataSource,
                ValueMember = "Value",
                DisplayMember = "Label",
                DisplayIndex = importanceIndex
            };
            grdData.Columns.Add(importance);

            // Pøidat tlaèítkové sloupce pro výbìr aktiv
            var btnPrimaryAsset = new DataGridViewButtonColumn
            {
                Name = "SelectPrimaryAsset",
                HeaderText = "Vybrat primární",
                Text = "...",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            grdData.Columns.Add(btnPrimaryAsset);

            var btnSupportingAsset = new DataGridViewButtonColumn
            {
                Name = "SelectSupportingAsset",
                HeaderText = "Vybrat podpùrné",
                Text = "...",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            grdData.Columns.Add(btnSupportingAsset);

            // Handler pro kliknutí na tlaèítka
            grdData.CellContentClick += GrdData_CellContentClick;

            grdData.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void GrdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Zakázat tlaèítka v readonly režimu
            if (grdData.ReadOnly) return;

            var row = grdData.Rows[e.RowIndex];
            var item = row.DataBoundItem as AssetRelationship;
            if (item == null) return;

            // Kliknutí na tlaèítko výbìru primárního aktiva
            if (grdData.Columns[e.ColumnIndex].Name == "SelectPrimaryAsset")
            {
                var selectedAsset = ShowAssetSelectionDialog(_primaryAssetManager, "Výbìr primárního aktiva");
                if (selectedAsset != null)
                {
                    item.PrimaryAssetId = selectedAsset.Id;
                    item.PrimaryAssetName = selectedAsset.Name;
                    item.LastModified = DateTime.Now;
                    SaveRow(item);
                    RefreshData();
                }
            }
            // Kliknutí na tlaèítko výbìru podpùrného aktiva
            else if (grdData.Columns[e.ColumnIndex].Name == "SelectSupportingAsset")
            {
                var selectedAsset = ShowAssetSelectionDialog(_supportingAssetManager, "Výbìr podpùrného aktiva");
                if (selectedAsset != null)
                {
                    item.SupportingAssetId = selectedAsset.Id;
                    item.SupportingAssetName = selectedAsset.Name;
                    item.LastModified = DateTime.Now;
                    SaveRow(item);
                    RefreshData();
                }
            }
        }

        private T ShowAssetSelectionDialog<T>(EntityManager<T> manager, string title) where T : class, IDataItem, new()
        {
            using (var dialog = new Form())
            {
                dialog.Text = title;
                dialog.Size = new System.Drawing.Size(600, 400);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;

                var listBox = new ListBox
                {
                    Dock = DockStyle.Fill,
                    DisplayMember = "Name"
                };

                foreach (var asset in manager.Items.Values)
                {
                    listBox.Items.Add(asset);
                }

                var panelButtons = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 40
                };

                var btnOk = new Button
                {
                    Text = "Vybrat",
                    DialogResult = DialogResult.OK,
                    Location = new System.Drawing.Point(400, 5),
                    Width = 80
                };

                var btnCancel = new Button
                {
                    Text = "Zrušit",
                    DialogResult = DialogResult.Cancel,
                    Location = new System.Drawing.Point(490, 5),
                    Width = 80
                };

                panelButtons.Controls.Add(btnOk);
                panelButtons.Controls.Add(btnCancel);

                dialog.Controls.Add(listBox);
                dialog.Controls.Add(panelButtons);
                dialog.AcceptButton = btnOk;
                dialog.CancelButton = btnCancel;

                if (dialog.ShowDialog() == DialogResult.OK && listBox.SelectedItem != null)
                {
                    return listBox.SelectedItem as T;
                }

                return null;
            }
        }

        protected override void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.grdData_CellValidating(sender, e);
        }
    }
}