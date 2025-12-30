
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DenarForms.Common
{
    public class MultilineTextEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            => UITypeEditorEditStyle.Modal;

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var svc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (svc == null) return value;

            using var form = new Form
            {
                Text = "Editace textu",
                StartPosition = FormStartPosition.CenterParent,
                Width = 700,
                Height = 500
            };

            var tb = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Both,
                WordWrap = false,
                Dock = DockStyle.Fill,
                AcceptsReturn = true,
                AcceptsTab = true,
                Text = value as string ?? string.Empty
            };

            var ok = new Button { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Right, Width = 100 };
            var cancel = new Button { Text = "Zrušit", DialogResult = DialogResult.Cancel, Dock = DockStyle.Right, Width = 100 };

            var buttons = new Panel { Dock = DockStyle.Bottom, Height = 40 };
            buttons.Controls.Add(cancel);
            buttons.Controls.Add(ok);

            form.Controls.Add(tb);
            form.Controls.Add(buttons);

            return form.ShowDialog() == DialogResult.OK ? tb.Text : value;
        }
    }
}