namespace DenarCZ.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtRootDataPath = new TextBox();
            txtOrganizationName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            tabSettings = new TabControl();
            tabSetGeneral = new TabPage();
            tabSetLevels = new TabPage();
            label9 = new Label();
            txtAvailabilityLevels = new TextBox();
            txtIntegrityLabels = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtAvailabilityLabels = new TextBox();
            txtConfidentialityLabels = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtIntegrityLevels = new TextBox();
            label3 = new Label();
            txtConfidentialityLevels = new TextBox();
            tabSetCategories = new TabPage();
            txtCategory = new TextBox();
            btnRemove = new Button();
            btnAdd = new Button();
            lstCategories = new ListBox();
            tabSettings.SuspendLayout();
            tabSetGeneral.SuspendLayout();
            tabSetLevels.SuspendLayout();
            tabSetCategories.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(128, 18);
            label1.TabIndex = 0;
            label1.Text = "Kořenová složka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 71);
            label2.Name = "label2";
            label2.Size = new Size(144, 18);
            label2.TabIndex = 0;
            label2.Text = "Název společnosti";
            // 
            // txtRootDataPath
            // 
            txtRootDataPath.Location = new Point(173, 18);
            txtRootDataPath.Name = "txtRootDataPath";
            txtRootDataPath.ReadOnly = true;
            txtRootDataPath.Size = new Size(630, 25);
            txtRootDataPath.TabIndex = 1;
            // 
            // txtOrganizationName
            // 
            txtOrganizationName.Location = new Point(173, 68);
            txtOrganizationName.Name = "txtOrganizationName";
            txtOrganizationName.Size = new Size(630, 25);
            txtOrganizationName.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(663, 297);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(744, 297);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tabSettings
            // 
            tabSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabSettings.Controls.Add(tabSetGeneral);
            tabSettings.Controls.Add(tabSetLevels);
            tabSettings.Controls.Add(tabSetCategories);
            tabSettings.Location = new Point(12, 12);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(820, 279);
            tabSettings.TabIndex = 4;
            // 
            // tabSetGeneral
            // 
            tabSetGeneral.BackColor = SystemColors.Control;
            tabSetGeneral.Controls.Add(label1);
            tabSetGeneral.Controls.Add(label2);
            tabSetGeneral.Controls.Add(txtRootDataPath);
            tabSetGeneral.Controls.Add(txtOrganizationName);
            tabSetGeneral.Location = new Point(4, 27);
            tabSetGeneral.Name = "tabSetGeneral";
            tabSetGeneral.Padding = new Padding(3);
            tabSetGeneral.Size = new Size(812, 248);
            tabSetGeneral.TabIndex = 0;
            tabSetGeneral.Text = "Obecné";
            // 
            // tabSetLevels
            // 
            tabSetLevels.BackColor = SystemColors.Control;
            tabSetLevels.Controls.Add(label9);
            tabSetLevels.Controls.Add(txtAvailabilityLevels);
            tabSetLevels.Controls.Add(txtIntegrityLabels);
            tabSetLevels.Controls.Add(label8);
            tabSetLevels.Controls.Add(label6);
            tabSetLevels.Controls.Add(label4);
            tabSetLevels.Controls.Add(txtAvailabilityLabels);
            tabSetLevels.Controls.Add(txtConfidentialityLabels);
            tabSetLevels.Controls.Add(label7);
            tabSetLevels.Controls.Add(label5);
            tabSetLevels.Controls.Add(txtIntegrityLevels);
            tabSetLevels.Controls.Add(label3);
            tabSetLevels.Controls.Add(txtConfidentialityLevels);
            tabSetLevels.Location = new Point(4, 24);
            tabSetLevels.Name = "tabSetLevels";
            tabSetLevels.Padding = new Padding(3);
            tabSetLevels.Size = new Size(812, 251);
            tabSetLevels.TabIndex = 1;
            tabSetLevels.Text = "Úrovně";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(226, 16);
            label9.Name = "label9";
            label9.Size = new Size(376, 18);
            label9.TabIndex = 61;
            label9.Text = "Všechny položky jsou seznam oddělený středníky";
            // 
            // txtAvailabilityLevels
            // 
            txtAvailabilityLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAvailabilityLevels.Location = new Point(226, 178);
            txtAvailabilityLevels.Name = "txtAvailabilityLevels";
            txtAvailabilityLevels.Size = new Size(574, 25);
            txtAvailabilityLevels.TabIndex = 50;
            // 
            // txtIntegrityLabels
            // 
            txtIntegrityLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIntegrityLabels.Location = new Point(226, 147);
            txtIntegrityLabels.Name = "txtIntegrityLabels";
            txtIntegrityLabels.Size = new Size(574, 25);
            txtIntegrityLabels.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 215);
            label8.Name = "label8";
            label8.Size = new Size(200, 18);
            label8.TabIndex = 2;
            label8.Text = "Názvy úrovní dostupnosti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 150);
            label6.Name = "label6";
            label6.Size = new Size(184, 18);
            label6.TabIndex = 2;
            label6.Text = "Názvy úrovní integrity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 83);
            label4.Name = "label4";
            label4.Size = new Size(192, 18);
            label4.TabIndex = 2;
            label4.Text = "Názvy úrovní důvěrnosti";
            // 
            // txtAvailabilityLabels
            // 
            txtAvailabilityLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAvailabilityLabels.Location = new Point(226, 212);
            txtAvailabilityLabels.Name = "txtAvailabilityLabels";
            txtAvailabilityLabels.Size = new Size(574, 25);
            txtAvailabilityLabels.TabIndex = 60;
            // 
            // txtConfidentialityLabels
            // 
            txtConfidentialityLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfidentialityLabels.Location = new Point(226, 80);
            txtConfidentialityLabels.Name = "txtConfidentialityLabels";
            txtConfidentialityLabels.Size = new Size(574, 25);
            txtConfidentialityLabels.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 183);
            label7.Name = "label7";
            label7.Size = new Size(152, 18);
            label7.TabIndex = 2;
            label7.Text = "Úrovně dostupnosti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 118);
            label5.Name = "label5";
            label5.Size = new Size(136, 18);
            label5.TabIndex = 2;
            label5.Text = "Úrovně integrity";
            // 
            // txtIntegrityLevels
            // 
            txtIntegrityLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIntegrityLevels.Location = new Point(226, 115);
            txtIntegrityLevels.Name = "txtIntegrityLevels";
            txtIntegrityLevels.Size = new Size(574, 25);
            txtIntegrityLevels.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 51);
            label3.Name = "label3";
            label3.Size = new Size(144, 18);
            label3.TabIndex = 2;
            label3.Text = "Úrovně důvěrnosti";
            // 
            // txtConfidentialityLevels
            // 
            txtConfidentialityLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfidentialityLevels.Location = new Point(226, 48);
            txtConfidentialityLevels.Name = "txtConfidentialityLevels";
            txtConfidentialityLevels.Size = new Size(574, 25);
            txtConfidentialityLevels.TabIndex = 10;
            // 
            // tabSetCategories
            // 
            tabSetCategories.BackColor = SystemColors.Control;
            tabSetCategories.Controls.Add(txtCategory);
            tabSetCategories.Controls.Add(btnRemove);
            tabSetCategories.Controls.Add(btnAdd);
            tabSetCategories.Controls.Add(lstCategories);
            tabSetCategories.Location = new Point(4, 27);
            tabSetCategories.Name = "tabSetCategories";
            tabSetCategories.Padding = new Padding(3);
            tabSetCategories.Size = new Size(812, 248);
            tabSetCategories.TabIndex = 2;
            tabSetCategories.Text = "Kategorie aktiv";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(15, 34);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(658, 25);
            txtCategory.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(683, 64);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 28);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Odebrat";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(683, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 28);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Přidat";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.Location = new Point(15, 64);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(658, 166);
            lstCategories.TabIndex = 0;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 338);
            Controls.Add(tabSettings);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            tabSettings.ResumeLayout(false);
            tabSetGeneral.ResumeLayout(false);
            tabSetGeneral.PerformLayout();
            tabSetLevels.ResumeLayout(false);
            tabSetLevels.PerformLayout();
            tabSetCategories.ResumeLayout(false);
            tabSetCategories.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRootDataPath;
        private TextBox txtOrganizationName;
        private Button btnAdd;
        private Button btnOK;
        private Button btnCancel;
        private TabControl tabSettings;
        private TabPage tabSetGeneral;
        private TabPage tabSetLevels;
        private Label label8;
        private Label label6;
        private Label label4;
        private TextBox txtAvailabilityLabels;
        private TextBox textBox2;
        private TextBox txtConfidentialityLabels;
        private Label label7;
        private TextBox textBox3;
        private Label label5;
        private TextBox txtIntegrityLevels;
        private Label label3;
        private TextBox txtConfidentialityLevels;
        private TextBox txtIntegrityLabels;
        private TextBox txtAvailabilityLevels;
        private Label label9;
        private TabPage tabSetCategories;
        private TextBox txtCategory;
        private Button btnRemove;
        private ListBox lstCategories;
    }
}