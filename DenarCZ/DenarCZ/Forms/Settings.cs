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
            var config = AppConfig.Instance.GetSaveData();
            var json = System.Text.Json.JsonSerializer.Serialize(config, config.GetType(), new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(AppConfig.Instance.RootDataPath,AppConfig.Instance.DataFileName), json);
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
        }
    }
}
