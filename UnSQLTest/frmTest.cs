using System;
using System.Windows.Forms;
using UnSQL.MySQL;

namespace UnSQLTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new Controller();
            x.InstallComplete += x_installcomplete;
            x.Install(Application.StartupPath + "\\db\\");
        }

        private void x_installcomplete()
        {
            MessageBox.Show("INSTALL OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new Controller();
            x.StartComplete += x_RunComplete;
            x.StartService(Application.StartupPath + "\\db\\");
        }

        private void x_RunComplete()
        {
            MessageBox.Show("Run OK");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new Controller();
            x.StopComplete += x_StopComplete;
            x.StopService(Application.StartupPath + "\\db\\", "9998");
        }

        private void x_StopComplete()
        {
            MessageBox.Show("Stopped");
        }
    }
}