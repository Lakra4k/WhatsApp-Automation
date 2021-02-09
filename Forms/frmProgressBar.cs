using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }
        private void ProgressBar_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.App_Default_Conn)
            {
                clsUtility.DBConnectionInitializing();
            }
            else
            {
                Properties.Settings.Default.App_Conn_string = "Data Source=(local);Initial Catalog=uMarketing;Integrated Security=True";
                Properties.Settings.Default.App_Default_Conn = true;
                Properties.Settings.Default.Save();
            }

            bunifuProgressBar.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuProgressBar.Value += 2;
            if (bunifuProgressBar.Value == 100)
            {
                timer1.Stop();
                ChamarTela();
            }
        }

        private void ChamarTela()
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
