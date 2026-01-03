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
            chkReadOnly = new CheckBox();
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
            grdData.Size = new Size(1041, 681);
            grdData.TabIndex = 0;
            grdData.CellParsing += grdData_CellParsing;
            grdData.CellValidating += grdData_CellValidating;
            grdData.ColumnAdded += grdData_ColumnAdded;
            grdData.CurrentCellDirtyStateChanged += grdData_CurrentCellDirtyStateChanged;
            grdData.DataError += grdData_DataError;
            grdData.RowsRemoved += grdData_RowsRemoved;
            grdData.RowValidated += grdData_RowValidated;
            grdData.RowValidating += grdData_RowValidating;
            grdData.UserAddedRow += grdData_UserAddedRow;
            grdData.UserDeletingRow += grdData_UserDeletingRow;
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
            btnEdit.Click += btnEdit_Click;
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
            btnDelete.Click += btnDelete_Click;
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
            btnNew.Click += btnNew_Click;
            // 
            // chkReadOnly
            // 
            chkReadOnly.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkReadOnly.AutoSize = true;
            chkReadOnly.Checked = true;
            chkReadOnly.CheckState = CheckState.Checked;
            chkReadOnly.Location = new Point(17, 748);
            chkReadOnly.Name = "chkReadOnly";
            chkReadOnly.Size = new Size(147, 22);
            chkReadOnly.TabIndex = 3;
            chkReadOnly.Text = "Pouze pro čtení";
            chkReadOnly.UseVisualStyleBackColor = true;
            chkReadOnly.CheckedChanged += chkReadOnly_CheckedChanged;
            // 
            // BaseDataListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkReadOnly);
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
            PerformLayout();
        }

        #endregion

        internal DataGridView grdData;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnNew;
        private CheckBox chkReadOnly;
    }
}
