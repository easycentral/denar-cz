using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DenarForms.Common
{
    public partial class BaseDataListControl : UserControl
    {
        protected BindingSource Source { get; } = new BindingSource();
        public BaseDataListControl()
        {
            InitializeComponent();
        }

        public void BindList(object list)
        {
            Source.DataSource = list;
        }


        public void CommitEdits()
        {
            grdData.EndEdit();
            Source.EndEdit();
        }




        protected virtual void grdData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            grdData.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        protected virtual void grdData_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        protected virtual void grdData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            e.Cancel = false;
            var msg = e.Exception?.Message ?? "Chyba dat";
            if (e.RowIndex >= 0 && e.RowIndex < grdData.Rows.Count)
                grdData.Rows[e.RowIndex].ErrorText = msg;

        }

        protected virtual void grdData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            //if (grdData.IsCurrentCellDirty)
            //    grdData.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        protected virtual void grdData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        protected virtual void grdData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void grdData_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {


            //e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        protected virtual void grdData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        protected virtual void grdData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        protected virtual void grdData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            grdData.ReadOnly = chkReadOnly.Checked;
        }

        protected virtual void btnNew_Click(object sender, EventArgs e)
        {
            

        }
    }
}
