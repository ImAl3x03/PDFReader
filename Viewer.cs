using System.Windows.Forms;

namespace PDFReader
{
    public partial class Viewer : Form
    {
        public Viewer(string path)
        {
            InitializeComponent();
            this.WebBrowser.Navigate(path);
        }
    }
}
