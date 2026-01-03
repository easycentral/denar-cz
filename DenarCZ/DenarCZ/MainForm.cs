using DenarCZ.Data;
using DenarCZ.Forms;
using DenarData.Asset;
using DenarData.Common;
using DenarForms.Grids;
using System.ComponentModel;

namespace DenarCZ
{
    public partial class MainForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EntityManager<PrimaryAsset> AssetManager { get; set; } = new EntityManager<PrimaryAsset>("", "PrimaryAssets");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EntityManager<SupportingAsset> SupportingAssetManager { get; set; } = new EntityManager<SupportingAsset>("", "SupportingAssets");
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EntityManager<AssetRelationship> RelationshipManager { get; set; } = new EntityManager<AssetRelationship>("", "AssetRelationships");
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON soubory (*.json)|*.json",
                Title = "Otevøít konfiguraci"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DenarCZ.Data.AppConfig.Instance.Initialize(dialog.FileName);
                    var json = System.IO.File.ReadAllText(dialog.FileName);
                    var config = System.Text.Json.JsonSerializer.Deserialize<DenarCZ.Data.AppConfigSave>(json);
                    DenarCZ.Data.AppConfig.Instance.Load(config);
                    AssetManager = new EntityManager<PrimaryAsset>(AppConfig.Instance.RootDataPath, "PrimaryAssets");
                    AssetManager.LoadAll();
                    SupportingAssetManager = new EntityManager<SupportingAsset>(AppConfig.Instance.RootDataPath, "SupportingAssets");
                    SupportingAssetManager.LoadAll();
                    RelationshipManager = new EntityManager<AssetRelationship>(AppConfig.Instance.RootDataPath, "AssetRelationships");
                    RelationshipManager.LoadAll();
                    MessageBox.Show("Konfigurace byla úspìšnì naètena.", "Úspìch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba pøi naèítání konfigurace: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "JSON soubory (*.json)|*.json",
                Title = "Uložit konfiguraci"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var config = AppConfig.Instance.GetSaveData();
                    var json = System.Text.Json.JsonSerializer.Serialize(config, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(dialog.FileName, json);
                    MessageBox.Show("Konfigurace byla úspìšnì uložena.", "Úspìch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppConfig.Instance.RootDataPath = System.IO.Path.GetDirectoryName(dialog.FileName) ?? string.Empty;
                    AppConfig.Instance.DataFileName = System.IO.Path.GetFileName(dialog.FileName);
                    AssetManager.SetPath(AppConfig.Instance.RootDataPath, "PrimaryAsset");
                    SupportingAssetManager.SetPath(AppConfig.Instance.RootDataPath, "SupportingAssets");
                    RelationshipManager.SetPath(AppConfig.Instance.RootDataPath, "AssetRelationships");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba pøi ukládání konfigurace: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            AppConfig.Instance.RootDataPath = string.Empty;
            AppConfig.Instance.OrganizationName = string.Empty;
            AssetManager = new EntityManager<PrimaryAsset>("", "PrimaryAssets");
            SupportingAssetManager = new EntityManager<SupportingAsset>("", "SupportingAssets");
            RelationshipManager = new EntityManager<AssetRelationship>("", "AssetRelationships");
            mnuFileSaveAs_Click(sender, e);
        }

        private void mnuOptionsSettings_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.ShowDialog();
        }

        private void mnuAssetPrimary_Click(object sender, EventArgs e)
        {
            AssetManager.LoadAll();
            DataListForm dataListForm = new DataListForm()
            {
                Text = "Správa primárních aktiv",

                DataItems = AssetManager.Items.Values.Cast<IDataItem>().ToList()
            };

            dataListForm.pnlData.Controls.Add(new PrimaryAssetsGrid(AssetManager)
            {
                Dock = DockStyle.Fill,

            });

            dataListForm.MdiParent = this;
            dataListForm.Show();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAssetSupporting_Click(object sender, EventArgs e)
        {
            SupportingAssetManager.LoadAll();
            DataListForm dataListForm = new DataListForm()
            {
                Text = "Správa podpùrných aktiv",
                DataItems = SupportingAssetManager.Items.Values.Cast<IDataItem>().ToList()
            };
            dataListForm.pnlData.Controls.Add(new SupportingAssetsGrid(SupportingAssetManager)
            {
                Dock = DockStyle.Fill,
            });
            dataListForm.MdiParent = this;
            dataListForm.Show();

        }

        private void mnuAssetRelationship_Click(object sender, EventArgs e)
        {
            RelationshipManager.LoadAll();
            DataListForm dataListForm = new DataListForm()
            {
                Text = "Vztahy primárních aktiv",
                DataItems = RelationshipManager.Items.Values.Cast<IDataItem>().ToList()
            };
            dataListForm.pnlData.Controls.Add(new AssetRelationshipsGrid(RelationshipManager, AssetManager, SupportingAssetManager)
            {
                Dock = DockStyle.Fill,
            });
            dataListForm.MdiParent = this;
            dataListForm.Show();

        }
    }
}
