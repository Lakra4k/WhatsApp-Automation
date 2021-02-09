using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot
{
    public partial class frmCustomer : Form
    {
        string CLIENTE_ID;
        messageBox message = new messageBox();
        public frmCustomer(String VAR_CLIENTE_ID)
        {
            InitializeComponent();
            CLIENTE_ID = VAR_CLIENTE_ID.ToString();
            txtClienteID.Text = VAR_CLIENTE_ID.ToString();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteDescription()
        {
            try
            {
                clsUtility.ExecuteSQLQuery("SELECT *  FROM  cliente  WHERE Cliente_ID ='" + CLIENTE_ID + "'  ");
                if (clsUtility.sqlDT.Rows.Count > 0)
                {
                    txtClienteName.Text = clsUtility.sqlDT.Rows[0]["ClienteNome"].ToString();
                    txtTelefone.Text = clsUtility.sqlDT.Rows[0]["Telefone"].ToString();
                    txtEmail.Text = clsUtility.sqlDT.Rows[0]["Email"].ToString();
                    txtEndereco.Text = clsUtility.sqlDT.Rows[0]["Endereco"].ToString();
                    cmbGrupo.SelectedValue = clsUtility.sqlDT.Rows[0]["GRUPO_ID"].ToString();
                }

                btnSubmit.Enabled = false;
                btnAlter.Enabled = true;

            }
            catch (Exception) { }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
            if (CLIENTE_ID == "0") { }
            else { ClienteDescription(); }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmGroup frmGroup = Application.OpenForms["frmGroup"] as frmGroup;
            if (frmGroup != null)
            {
                frmGroup.WindowState = FormWindowState.Normal;
                frmGroup.BringToFront();
                frmGroup.Activate();
            }
            else
            {
                frmGroup = new frmGroup();
                frmGroup.MdiParent = this.ParentForm;
                frmGroup.Dock = DockStyle.Fill;
                frmGroup.Show();
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////
            if (string.IsNullOrWhiteSpace(this.txtClienteName.Text) | string.IsNullOrWhiteSpace(this.txtTelefone.Text) | cmbGrupo.SelectedValue == null | cmbGrupo.SelectedIndex == -1)
            {
                errorProvider.SetError(txtClienteName, "Required");
                errorProvider.SetError(txtTelefone, "Required");
                errorProvider.SetError(cmbGrupo, "Required");
            }
            else
            {

                if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
                {
                    clsUtility.ExecuteSQLQuery(" INSERT INTO cliente(ClienteNome,Telefone,Email,Endereco,GRUPO_ID) VALUES " +
                                               "  ('" + txtClienteName.Text + "','" + txtTlfSufixo.Text + txtTelefone.Text + "','" + txtEmail.Text + "','" + txtEndereco.Text + "','" + cmbGrupo.SelectedValue.ToString() + "') ");
                    clsUtility.ExecuteSQLQuery("SELECT  Cliente_ID   FROM   cliente  ORDER BY Cliente_ID DESC");
                    CLIENTE_ID = clsUtility.sqlDT.Rows[0]["Cliente_ID"].ToString();


                    bunifuSnackbar.Show(this, message.MessageShow("Saved"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    ///////////////////////////
                    Regex mRegxExpression;
                    if (txtEmail.Text.Trim() != string.Empty)
                    {
                        mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                        if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                        {
                            bunifuSnackbar.Show(this, "Campo Email incorrecto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                            txtEmail.Focus();
                        }
                        else
                        {
                            clsUtility.ExecuteSQLQuery(" INSERT INTO cliente(ClienteNome,Telefone,Email,Endereco,GRUPO_ID) VALUES " +
                                               "  ('" + txtClienteName.Text + "','" + txtTlfSufixo.Text + txtTelefone.Text + "','" + txtEmail.Text + "','" + txtEndereco.Text + "','" + cmbGrupo.SelectedValue.ToString() + "') ");
                            clsUtility.ExecuteSQLQuery("SELECT  Cliente_ID   FROM   cliente  ORDER BY Cliente_ID DESC");
                            CLIENTE_ID = clsUtility.sqlDT.Rows[0]["Cliente_ID"].ToString();

                            bunifuSnackbar.Show(this, message.MessageShow("Saved"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        }
                    }
                }

            }
            ///////////////////////////////////////////
        }


        private void LoadData()
        {
            clsUtility.FillComboBox("SELECT  GRUPO_ID, GRUPO_NOME  FROM  grupo  ORDER BY GRUPO_NOME", "GRUPO_ID", "GRUPO_NOME", cmbGrupo);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtClienteName.Text) | string.IsNullOrWhiteSpace(this.txtTelefone.Text) | cmbGrupo.SelectedValue == null | cmbGrupo.SelectedIndex == -1)
            {
                errorProvider.SetError(txtClienteName, "Required");
                errorProvider.SetError(txtTelefone, "Required");
                errorProvider.SetError(cmbGrupo, "Required");
            }
            else
            {
                ///////////////////////////////

                try

                {
                    clsUtility.ExecuteSQLQuery(" UPDATE  cliente SET  ClienteNome='" + txtClienteName.Text + "',Telefone='" + txtTlfSufixo.Text + txtTelefone.Text + "',Email='" + txtEmail.Text + "',Endereco='" + txtEndereco.Text + "',GRUPO_ID='" + cmbGrupo.SelectedValue.ToString() + "' " +
                               " WHERE Cliente_ID ='" + CLIENTE_ID + "'  ");

                    txtClienteID.Text = "";

                    bunifuSnackbar.Show(this, message.MessageShow("Update"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                }
                catch (Exception ex)
                {
                    bunifuSnackbar.Show(this, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                //////////////////////////////
            }
        }
    }
}
