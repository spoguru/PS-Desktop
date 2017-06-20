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

    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dependency subform = new Dependency();
            subform.MdiParent = this;
            subform.BringToFront();
            subform.TopMost = true;
            subform.evtFrm += new ShowFrm(subform_evtFrm);
            subform.Show();

            btDependency.Visible = false;
            btReporting.Visible = false;
            btAgile.Visible = false;
            btProjAssur.Visible = false;
            btFinancial.Visible = false;
            btWorkviewer.Visible = false;
            btRiskMatrix.Visible = false;
            btTSOff.Visible = false;
            btRiskIssue.Visible = false;
            btSwimlane.Visible = false;
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Reporting subform1 = new Reporting();
            subform1.MdiParent = this;
            subform1.BringToFront();
            subform1.TopMost = true;
            subform1.evtFrm += new ShowFrm1(subform_evtFrm);
            subform1.Show();

            btDependency.Visible = false;
            btReporting.Visible = false;
            btAgile.Visible = false;
            btProjAssur.Visible = false;
            btFinancial.Visible = false;
            btWorkviewer.Visible = false;
            btRiskMatrix.Visible = false;
            btTSOff.Visible = false;
            btRiskIssue.Visible = false;
            btSwimlane.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Agile subform2 = new Agile();
            subform2.MdiParent = this;
            subform2.BringToFront();
            subform2.TopMost = true;
            subform2.evtFrm += new ShowFrm2(subform_evtFrm);
            subform2.Show();

            btDependency.Visible = false;
            btReporting.Visible = false;
            btAgile.Visible = false;
            btProjAssur.Visible = false;
            btFinancial.Visible = false;
            btWorkviewer.Visible = false;
            btRiskMatrix.Visible = false;
            btTSOff.Visible = false;
            btRiskIssue.Visible = false;
            btSwimlane.Visible = false;
        }

        void subform_evtFrm()
        {
            btDependency.Visible = true;
            btReporting.Visible = true;
            btAgile.Visible = true;
            btProjAssur.Visible = true;
            btFinancial.Visible = true;
            btWorkviewer.Visible = true;
            btRiskMatrix.Visible = true;
            btTSOff.Visible = true;
            btRiskIssue.Visible = true;
            btSwimlane.Visible = true;
        }
        
    }

    //public class PasswordRepository
    //{
    //    private const string PasswordName = "ServerPassword";

    //    public void SavePassword(string password)
    //    {
    //        using (var cred = new Credential())
    //        {
    //            cred.Password = password;
    //            cred.Target = PasswordName;
    //            cred.Type = CredentialType.Generic;
    //            cred.PersistanceType = PersistanceType.LocalComputer;
    //            cred.Save();
    //        }
    //    }

    //    public string GetPassword()
    //    {
    //        using (var cred = new Credential())
    //        {
    //            cred.Target = PasswordName;
    //            cred.Load();
    //            return cred.Password;
    //        }
    //    }
    //}
}
