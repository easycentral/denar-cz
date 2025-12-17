namespace DenarCZ
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            mnuFileExit = new ToolStripMenuItem();
            mnuOptions = new ToolStripMenuItem();
            mnuOptionsSettings = new ToolStripMenuItem();
            mnuAsset = new ToolStripMenuItem();
            mnuAssetPrimary = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuOptions, mnuAsset });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(7, 2, 0, 2);
            mnuMain.Size = new Size(914, 26);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSaveAs, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(68, 22);
            mnuFile.Text = "&Soubor";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(164, 22);
            mnuFileNew.Text = "&Nový";
            mnuFileNew.Click += mnuFileNew_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(164, 22);
            mnuFileOpen.Text = "&Otevřít";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(164, 22);
            mnuFileSaveAs.Text = "U&ložit jako";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(164, 22);
            mnuFileExit.Text = "&Konec";
            // 
            // mnuOptions
            // 
            mnuOptions.DropDownItems.AddRange(new ToolStripItem[] { mnuOptionsSettings });
            mnuOptions.Name = "mnuOptions";
            mnuOptions.Size = new Size(84, 22);
            mnuOptions.Text = "&Možnosti";
            // 
            // mnuOptionsSettings
            // 
            mnuOptionsSettings.Name = "mnuOptionsSettings";
            mnuOptionsSettings.Size = new Size(148, 22);
            mnuOptionsSettings.Text = "&Nastavení";
            mnuOptionsSettings.Click += mnuOptionsSettings_Click;
            // 
            // mnuAsset
            // 
            mnuAsset.DropDownItems.AddRange(new ToolStripItem[] { mnuAssetPrimary });
            mnuAsset.Name = "mnuAsset";
            mnuAsset.Size = new Size(68, 22);
            mnuAsset.Text = "&Aktiva";
            // 
            // mnuAssetPrimary
            // 
            mnuAssetPrimary.Name = "mnuAssetPrimary";
            mnuAssetPrimary.Size = new Size(196, 22);
            mnuAssetPrimary.Text = "Primární aktiva";
            mnuAssetPrimary.Click += mnuAssetPrimary_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(mnuMain);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Desktopový nástroj pro analýzu rizik";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuOptionsSettings;
        private ToolStripMenuItem mnuAsset;
        private ToolStripMenuItem mnuAssetPrimary;
    }
}
