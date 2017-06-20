using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS__Desktop
{
    public delegate void ShowFrm1();
    public partial class Reporting : Form
    {
        public event ShowFrm1 evtFrm;
        public Reporting()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            webBrowser1.Navigate("https://spe307094-a25663ede8df72.sharepoint.com/sites/pwa/PSPReporting/Pages/ReportPage.aspx?SPHostUrl=https%3A%2F%2Fspe307094%2Esharepoint%2Ecom%2Fsites%2Fpwa&SPLanguage=en-US&SPClientTag=3&SPProductNumber=16%2E0%2E6607%2E1206&SPAppWebUrl=https%3A%2F%2FSPE307094-a25663ede8df72%2Esharepoint%2Ecom%2Fsites%2Fpwa%2FPSPReporting");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (evtFrm != null)
            {
                evtFrm();
            }

            Close();
        }
    }
}
