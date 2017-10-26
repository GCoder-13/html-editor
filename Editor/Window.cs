using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Window : Form
    {
        private Form app = default(Form);
        private static int countForm = 0; 

        public Window(Form main)
        {
            countForm++;
            InitializeComponent();
            this.app = main;
            this.BackColor = ColorTranslator.FromHtml("#1e1e1e");
            this.textArea.BackColor = ColorTranslator.FromHtml("#1e1e1e");
        }

        private void fileMenuItemNewWindow_Click(object sender, EventArgs e)
        {
            Window newWindow = new Window(this.app);
            newWindow.WindowState = FormWindowState.Normal;
            newWindow.Show();
        }

        private void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (--countForm == 0)
                Application.Exit();
        }

        private void fileMenuItemOpen_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textArea.LoadFile(this.openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }

        private void fileMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textArea.SaveFile(this.saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }

        private void editMenuItemCut_Click(object sender, EventArgs e)
        {
            this.textArea.Cut();
        }

        private void editMenuItemCopy_Click(object sender, EventArgs e)
        {
            this.textArea.Copy();
        }

        private void editMenuItemPaste_Click(object sender, EventArgs e)
        {
            this.textArea.Paste();
        }

        private void editMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            this.textArea.SelectAll();
        }

        private void editMenuItemUndo_Click(object sender, EventArgs e)
        {
            this.textArea.Undo();
        }

        private void editMenuItemRedo_Click(object sender, EventArgs e)
        {
            this.textArea.Redo();
        }

        private void fileMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
