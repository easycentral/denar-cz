namespace DenarForms.Common
{
    partial class dataList
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            grdData = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            SuspendLayout();
            // 
            // grdData
            // 
            grdData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdData.Location = new Point(17, 60);
            grdData.Margin = new Padding(3, 4, 3, 4);
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            grdData.Size = new Size(1041, 697);
            grdData.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(17, 25);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 28);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Upravit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(972, 25);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 28);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Smazat";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataList
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(grdData);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dataList";
            Size = new Size(1078, 780);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView grdData;
        private Button btnEdit;
        private Button btnDelete;
    }
}
