using DenarCZ.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DenarCZ.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AppConfig.Instance.OrganizationName = txtOrganizationName.Text;
            AppConfig.Instance.ConfidentialityLevels = txtConfidentialityLevels.Text;
            AppConfig.Instance.ConfidentialityLabels = txtConfidentialityLabels.Text;
            AppConfig.Instance.IntegrityLevels = txtIntegrityLevels.Text;
            AppConfig.Instance.IntegrityLabels = txtIntegrityLabels.Text;
            AppConfig.Instance.AvailabilityLevels = txtAvailabilityLevels.Text;
            AppConfig.Instance.AvailabilityLabels = txtAvailabilityLabels.Text;
            AppConfig.Instance.CriticalityLevels = txtCriticalityLevels.Text;
            AppConfig.Instance.CriticalityLabels = txtCriticalityLabels.Text;


            List<string> categories = new List<string>();
            foreach (var item in lstCategories.Items)
            {
                categories.Add(item.ToString());
            }
            categories.Sort();
            AppConfig.Instance.AssetCategories = string.Join(";", categories);
            
            List<string> types = new List<string>();
            foreach (var item in lstTypes.Items)
            {
                types.Add(item.ToString());
            }
            types.Sort();
            AppConfig.Instance.SupportingAssetTypes = string.Join(";", types);


            var config = AppConfig.Instance.GetSaveData();
            var json = System.Text.Json.JsonSerializer.Serialize(config, config.GetType(), new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(AppConfig.Instance.RootDataPath, AppConfig.Instance.DataFileName), json);
            MessageBox.Show("Konfigurace byla úspěšně uložena.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtOrganizationName.Text = AppConfig.Instance.OrganizationName;
            txtRootDataPath.Text = AppConfig.Instance.RootDataPath;
            txtConfidentialityLevels.Text = AppConfig.Instance.ConfidentialityLevels;
            txtConfidentialityLabels.Text = AppConfig.Instance.ConfidentialityLabels;
            txtIntegrityLevels.Text = AppConfig.Instance.IntegrityLevels;
            txtIntegrityLabels.Text = AppConfig.Instance.IntegrityLabels;
            txtAvailabilityLevels.Text = AppConfig.Instance.AvailabilityLevels;
            txtAvailabilityLabels.Text = AppConfig.Instance.AvailabilityLabels;
            txtCriticalityLevels.Text = AppConfig.Instance.CriticalityLevels;
            txtCriticalityLabels.Text = AppConfig.Instance.CriticalityLabels;
            
            string[] categories = AppConfig.Instance.AssetCategories.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            lstCategories.Items.Clear();
            lstCategories.Items.AddRange(categories);
            
            lstTypes.Items.Clear();
            string[] types = AppConfig.Instance.SupportingAssetTypes.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            lstTypes.Items.AddRange(types);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Trim() != "")
            {
                lstCategories.Items.Add(txtCategory.Text.Trim());
                txtCategory.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCategories.SelectedIndex >= 0)
            {
                lstCategories.Items.RemoveAt(lstCategories.SelectedIndex);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Trim() != "")
            {
                lstTypes.Items.Add(txtType.Text.Trim());
                txtType.Text = "";
            }
        }

        private void btnTypeRemove_Click(object sender, EventArgs e)
        {
            if (lstTypes.SelectedIndex >= 0)
            {
                lstTypes.Items.RemoveAt(lstTypes.SelectedIndex);

            }
        }
    }
}
