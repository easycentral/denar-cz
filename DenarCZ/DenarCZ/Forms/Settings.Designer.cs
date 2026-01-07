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
            txtCriticalityLabels = new TextBox();
            txtCriticalityLevels = new TextBox();
            label10 = new Label();
            label11 = new Label();
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
            label12 = new Label();
            txtCategory = new TextBox();
            btnRemove = new Button();
            btnAdd = new Button();
            lstCategories = new ListBox();
            tabSetSATypes = new TabPage();
            label13 = new Label();
            txtType = new TextBox();
            btnTypeRemove = new Button();
            btnAddType = new Button();
            lstTypes = new ListBox();
            label14 = new Label();
            label15 = new Label();
            txtImportanceLevels = new TextBox();
            txtImportanceLabels = new TextBox();
            tabSettings.SuspendLayout();
            tabSetGeneral.SuspendLayout();
            tabSetLevels.SuspendLayout();
            tabSetCategories.SuspendLayout();
            tabSetSATypes.SuspendLayout();
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
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOK.Location = new Point(663, 444);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 29);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Location = new Point(744, 444);
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
            tabSettings.Controls.Add(tabSetSATypes);
            tabSettings.Location = new Point(12, 12);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(820, 426);
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
            tabSetGeneral.Size = new Size(812, 317);
            tabSetGeneral.TabIndex = 0;
            tabSetGeneral.Text = "Obecné";
            // 
            // tabSetLevels
            // 
            tabSetLevels.BackColor = SystemColors.Control;
            tabSetLevels.Controls.Add(txtImportanceLabels);
            tabSetLevels.Controls.Add(txtImportanceLevels);
            tabSetLevels.Controls.Add(txtCriticalityLabels);
            tabSetLevels.Controls.Add(label15);
            tabSetLevels.Controls.Add(txtCriticalityLevels);
            tabSetLevels.Controls.Add(label14);
            tabSetLevels.Controls.Add(label10);
            tabSetLevels.Controls.Add(label11);
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
            tabSetLevels.Location = new Point(4, 27);
            tabSetLevels.Name = "tabSetLevels";
            tabSetLevels.Padding = new Padding(3);
            tabSetLevels.Size = new Size(812, 395);
            tabSetLevels.TabIndex = 1;
            tabSetLevels.Text = "Úrovně";
            // 
            // txtCriticalityLabels
            // 
            txtCriticalityLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCriticalityLabels.Location = new Point(226, 277);
            txtCriticalityLabels.Name = "txtCriticalityLabels";
            txtCriticalityLabels.Size = new Size(574, 25);
            txtCriticalityLabels.TabIndex = 65;
            // 
            // txtCriticalityLevels
            // 
            txtCriticalityLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCriticalityLevels.Location = new Point(226, 243);
            txtCriticalityLevels.Name = "txtCriticalityLevels";
            txtCriticalityLevels.Size = new Size(574, 25);
            txtCriticalityLevels.TabIndex = 64;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 280);
            label10.Name = "label10";
            label10.Size = new Size(200, 18);
            label10.TabIndex = 62;
            label10.Text = "Názvy úrovní kritičnosti";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 248);
            label11.Name = "label11";
            label11.Size = new Size(152, 18);
            label11.TabIndex = 63;
            label11.Text = "Úrovně kritičnosti";
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
            tabSetCategories.Controls.Add(label12);
            tabSetCategories.Controls.Add(txtCategory);
            tabSetCategories.Controls.Add(btnRemove);
            tabSetCategories.Controls.Add(btnAdd);
            tabSetCategories.Controls.Add(lstCategories);
            tabSetCategories.Location = new Point(4, 24);
            tabSetCategories.Name = "tabSetCategories";
            tabSetCategories.Padding = new Padding(3);
            tabSetCategories.Size = new Size(812, 320);
            tabSetCategories.TabIndex = 2;
            tabSetCategories.Text = "Primární aktiva";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 13);
            label12.Name = "label12";
            label12.Size = new Size(216, 18);
            label12.TabIndex = 3;
            label12.Text = "Kategorie primárních aktiv";
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
            lstCategories.Size = new Size(658, 220);
            lstCategories.TabIndex = 0;
            // 
            // tabSetSATypes
            // 
            tabSetSATypes.BackColor = SystemColors.Control;
            tabSetSATypes.Controls.Add(label13);
            tabSetSATypes.Controls.Add(txtType);
            tabSetSATypes.Controls.Add(btnTypeRemove);
            tabSetSATypes.Controls.Add(btnAddType);
            tabSetSATypes.Controls.Add(lstTypes);
            tabSetSATypes.Location = new Point(4, 24);
            tabSetSATypes.Name = "tabSetSATypes";
            tabSetSATypes.Size = new Size(812, 320);
            tabSetSATypes.TabIndex = 3;
            tabSetSATypes.Text = "Podpůrná aktiva";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 23);
            label13.Name = "label13";
            label13.Size = new Size(176, 18);
            label13.TabIndex = 8;
            label13.Text = "Typy podpůrných aktiv";
            // 
            // txtType
            // 
            txtType.Location = new Point(12, 44);
            txtType.Name = "txtType";
            txtType.Size = new Size(658, 25);
            txtType.TabIndex = 7;
            // 
            // btnTypeRemove
            // 
            btnTypeRemove.Location = new Point(680, 74);
            btnTypeRemove.Name = "btnTypeRemove";
            btnTypeRemove.Size = new Size(120, 28);
            btnTypeRemove.TabIndex = 5;
            btnTypeRemove.Text = "Odebrat";
            btnTypeRemove.UseVisualStyleBackColor = true;
            btnTypeRemove.Click += btnTypeRemove_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(680, 41);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(120, 28);
            btnAddType.TabIndex = 6;
            btnAddType.Text = "Přidat";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // lstTypes
            // 
            lstTypes.FormattingEnabled = true;
            lstTypes.Location = new Point(12, 74);
            lstTypes.Name = "lstTypes";
            lstTypes.Size = new Size(658, 220);
            lstTypes.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 316);
            label14.Name = "label14";
            label14.Size = new Size(152, 18);
            label14.TabIndex = 63;
            label14.Text = "Úrovně důležitosti";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 348);
            label15.Name = "label15";
            label15.Size = new Size(200, 18);
            label15.TabIndex = 62;
            label15.Text = "Názvy úrovní důležitosti";
            // 
            // txtImportanceLevels
            // 
            txtImportanceLevels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImportanceLevels.Location = new Point(226, 311);
            txtImportanceLevels.Name = "txtImportanceLevels";
            txtImportanceLevels.Size = new Size(574, 25);
            txtImportanceLevels.TabIndex = 64;
            // 
            // txtImportanceLabels
            // 
            txtImportanceLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImportanceLabels.Location = new Point(226, 345);
            txtImportanceLabels.Name = "txtImportanceLabels";
            txtImportanceLabels.Size = new Size(574, 25);
            txtImportanceLabels.TabIndex = 65;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 485);
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
            tabSetSATypes.ResumeLayout(false);
            tabSetSATypes.PerformLayout();
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
        private TextBox txtImportanceLabels;
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
        private TextBox txtCriticalityLevels;
        private Label label10;
        private Label label11;
        private TextBox txtCriticalityLabels;
        private Label label12;
        private TabPage tabSetSATypes;
        private Label label13;
        private TextBox txtType;
        private Button btnTypeRemove;
        private Button btnAddType;
        private ListBox lstTypes;
        private TextBox txtImportanceLevels;
        private Label label15;
        private Label label14;
    }
}