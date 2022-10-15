using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meelo_Browser
{
    public partial class PdfViewer : UserControl
    {
        public PdfViewer()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser chromeViewer;
        public bool TopLevel { get; internal set; }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //using open dialog to browse the pdf file
            using (OpenFileDialog open = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect = false,
                Filter = "PDF|*.pdf"    //required to select pdf file only
            })
            {
                if(open.ShowDialog()== DialogResult.OK)
                {
                    chromeViewer = new ChromiumWebBrowser(open.FileName); //using cef to load the pdf
                    chromeViewer.Load(open.FileName);
                    chromeViewer.Dock = DockStyle.Fill;
                    pdfPanel.Controls.Add(chromeViewer);
                    btnSelect.Visible = false;
                    btnClear.Visible = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pdfPanel.Controls.Clear();
            btnSelect.Visible = true;
            btnClear.Visible = false;
        }
    }
}
