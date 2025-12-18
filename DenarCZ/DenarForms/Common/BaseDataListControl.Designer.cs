namespace DenarForms.Common
{
    partial class BaseDataListControl
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
            btnNew = new Button();
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
            grdData.Size = new Size(1041, 697);
            grdData.TabIndex = 0;
            grdData.CellParsing += grdData_CellParsing;
            grdData.CellValidating += grdData_CellValidating;
            grdData.ColumnAdded += grdData_ColumnAdded;
            grdData.CurrentCellDirtyStateChanged += grdData_CurrentCellDirtyStateChanged;
            grdData.DataError += grdData_DataError;
            grdData.RowValidated += grdData_RowValidated;
            grdData.RowValidating += grdData_RowValidating;
            grdData.UserAddedRow += grdData_UserAddedRow;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 25);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 28);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Upravit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(972, 25);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 28);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Smazat";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(17, 24);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(111, 28);
            btnNew.TabIndex = 1;
            btnNew.Text = "Nový záznam";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // BaseDataListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnEdit);
            Controls.Add(grdData);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BaseDataListControl";
            Size = new Size(1078, 780);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView grdData;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnNew;
    }
}
