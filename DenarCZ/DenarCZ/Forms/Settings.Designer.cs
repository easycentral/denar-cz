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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(128, 18);
            label1.TabIndex = 0;
            label1.Text = "Kořenová složka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 78);
            label2.Name = "label2";
            label2.Size = new Size(144, 18);
            label2.TabIndex = 0;
            label2.Text = "Název společnosti";
            // 
            // txtRootDataPath
            // 
            txtRootDataPath.Location = new Point(178, 25);
            txtRootDataPath.Name = "txtRootDataPath";
            txtRootDataPath.ReadOnly = true;
            txtRootDataPath.Size = new Size(641, 25);
            txtRootDataPath.TabIndex = 1;
            // 
            // txtOrganizationName
            // 
            txtOrganizationName.Location = new Point(178, 75);
            txtOrganizationName.Name = "txtOrganizationName";
            txtOrganizationName.Size = new Size(641, 25);
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
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 338);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtOrganizationName);
            Controls.Add(txtRootDataPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRootDataPath;
        private TextBox txtOrganizationName;
        private Button button1;
        private Button btnOK;
        private Button btnCancel;
    }
}