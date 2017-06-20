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

    public partial class Form1 : Form
    {
        
        public Form1()
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
            Form2 subform = new Form2();
            subform.MdiParent = this;
            subform.BringToFront();
            subform.TopMost = true;
            subform.evtFrm += new ShowFrm(subform_evtFrm);
            subform.Show();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 subform1 = new Form3();
            subform1.MdiParent = this;
            subform1.BringToFront();
            subform1.TopMost = true;
            subform1.evtFrm += new ShowFrm1(subform_evtFrm);
            subform1.Show();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        void subform_evtFrm()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
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
