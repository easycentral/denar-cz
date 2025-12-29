namespace DenarForms.Common
{
    partial class BaseDataDetailControl
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
            grdData = new PropertyGrid();
            SuspendLayout();
            // 
            // grdData
            // 
            grdData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdData.BackColor = SystemColors.Control;
            grdData.Location = new Point(13, 14);
            grdData.Name = "grdData";
            grdData.Size = new Size(849, 636);
            grdData.TabIndex = 0;
            // 
            // BaseDataDetailControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grdData);
            Name = "BaseDataDetailControl";
            Size = new Size(880, 666);
            ResumeLayout(false);
        }

        #endregion

        public PropertyGrid grdData;
    }
}
