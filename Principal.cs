using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFReader
{
    public partial class Form1 : Form
    {
        private string _file;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.TextBox.Text = dialog.FileName;
                    _file = dialog.FileName;
                }
            }
        }

        private void Effect(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void InsertFile(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (files != null && files.Any())
                _file = files.First();

            if (Path.GetExtension(_file) == ".pdf")
                this.TextBox.Text = _file;
            else
                this.TextBox.Text = "";
        }

        private void OpenPdf(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_file))
            {
                var view = new Viewer(_file);
                view.ShowDialog();
            }
        }
    }
}