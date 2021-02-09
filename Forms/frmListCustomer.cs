using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Bunifu.UI.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot
{
    public partial class frmListCustomer : Form
    {
        public frmListCustomer()
        {
            InitializeComponent();
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            cmbParameter.Text = "ClienteNome";
            clsUtility.FillComboBox(" SELECT  GRUPO_ID, GRUPO_NOME  FROM  grupo  ORDER BY GRUPO_NOME", "GRUPO_ID", "GRUPO_NOME", cmbGroup);
            LoadData();
        }

        private void LoadData()
        {
            clsUtility.FillDataGrid(" SELECT Cliente_ID, ClienteNome, Telefone, Email, Endereco, GRUPO_NOME " +
                                    " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) ORDER BY ClienteNome ", DgvClientes);
        }

        private void btnSearchByGroup_Click(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue == null | cmbGroup.SelectedIndex == -1)
            {
                LoadData();
            }
            else
            {
                try
                {
                    clsUtility.FillDataGrid(" SELECT Cliente_ID, ClienteNome, Telefone, Email, Endereco, GRUPO_NOME " +
                                            " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) WHERE   (cliente.GRUPO_ID='" + cmbGroup.SelectedValue.ToString() + "') ORDER BY ClienteNome ", DgvClientes);
                }
                catch (Exception ex)
                { bunifuSnackbar.Show(this, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error); }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CLIENTE_ID = DgvClientes.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            frmCustomer frmCustomer = Application.OpenForms["frmCustomer"] as frmCustomer;
            if (frmCustomer != null)
            {
                frmCustomer.WindowState = FormWindowState.Normal;
                frmCustomer.BringToFront();
                frmCustomer.Activate();
            }
            else
            {
                frmCustomer = new frmCustomer(CLIENTE_ID);
                frmCustomer.MdiParent = this.ParentForm;
                frmCustomer.Dock = DockStyle.Fill;
                frmCustomer.Show();
            }
        }

        private void cmbParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCriteria.Select();
        }


        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.cmbParameter.Text))
            {
                errorProvider.SetError(cmbParameter, "Required");
                LoadData();
            }

            /*else if (string.IsNullOrWhiteSpace(this.txtCriteria.Text))
            {
                errorProvider.SetError(txtCriteria, "Required");
                LoadData();
            }*/
            else
            {
                try
                {
                    errorProvider.Clear();
                    clsUtility.FillDataGrid(" SELECT Cliente_ID, ClienteNome, Telefone, Email, Endereco, GRUPO_NOME " +
                                            " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) WHERE   (" + cmbParameter.Text + " LIKE '%" + txtCriteria.Text + "%') ORDER BY ClienteNome ", DgvClientes);
                }
                catch (Exception ex)
                { bunifuSnackbar.Show(this, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error); }
            }
        }
    }
}
