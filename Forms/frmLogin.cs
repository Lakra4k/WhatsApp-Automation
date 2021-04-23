using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Bunifu.UI.WinForms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot
{
    public partial class frmLogin : Form
    {
        Timer frmOpem = new Timer();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmOpem.Interval = 4000; //um segundos
            frmOpem.Tick += new EventHandler(frmOpem_Tick);
            btnEyeNo.Visible = true;
            btnEye.Visible = false;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnEyeNo.Visible = true;
            btnEye.Visible = false;
        }

        private void btnEyeNo_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnEyeNo.Visible = false;
            btnEye.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.radPanel1.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        this.radValidationProvider1.Validate(editorControl);
                    }
                }
            }*/
            errorProvider.Clear();

            frmOpem.Start();
            radWaitingBar.StartWaiting();

            if (radWaitingBar.IsWaiting)
            {
                radWaitingBar.StopWaiting();
            }
            else
            {
                radWaitingBar.StartWaiting();
            }


        }

        void frmOpem_Tick(object sender, EventArgs e)
        {

            if (txtUser.Text == "123" & txtPass.Text == "123")
            {
                frmOpem.Stop();
                radWaitingBar.Visible = true;

                frmOpem.Tick -= new EventHandler(frmOpem_Tick);
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else if (string.IsNullOrEmpty(txtUser.Text))
            {
                frmOpem.Stop();
                radWaitingBar.Visible = true;

                errorProvider.SetError(txtUser, "Required");
                txtUser.BorderColorActive = Color.FromArgb(244, 33, 33);
                txtUser.Focus();
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                frmOpem.Stop();
                radWaitingBar.Visible = true;

                errorProvider.SetError(txtPass, "Required");
                txtPass.BorderColorActive = Color.FromArgb(244, 33, 33);
                txtPass.Focus();
            }
            else if (string.IsNullOrEmpty(txtUser.Text) | string.IsNullOrEmpty(txtPass.Text))
            {
                frmOpem.Stop();
                radWaitingBar.Visible = true;

                errorProvider.SetError(txtUser, "Required");
                errorProvider.SetError(txtPass, "Required");
            }
            else
            {
                frmOpem.Stop();
                radWaitingBar.Visible = true;

                txtUser.BorderColorActive = Color.FromArgb(3, 255, 175);
                //Error.Visible = false;
                bunifuSnackbarLogin.Show(this, "Usuário ou Senha Errada!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

            /*frmOpem.Stop();
            frmOpem.Tick -= new EventHandler(frmOpem_Tick);
            Main main = new Main();
            this.Hide();
            main.Show();*/

        }

        private void btnAboutApp_Click(object sender, EventArgs e)
        {
            new WhatsApp_Robot.Popup.transparentBg1(this, new WhatsApp_Robot.Forms.frmAbout());
        }


        private void txtUser_TextChange(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtUser.BorderColorActive = Color.FromArgb(3, 255, 175);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtPass.BorderColorActive = Color.FromArgb(3, 255, 175);
        }

    }
}
