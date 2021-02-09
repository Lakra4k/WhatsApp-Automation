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
    public partial class frmGroup : Form
    {
        messageBox message = new messageBox();
        public frmGroup()
        {
            InitializeComponent();
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            clsUtility.FillDataGrid("SELECT GRUPO_ID ,GRUPO_NOME, GRUPO_DESCRICAO  FROM grupo ORDER BY  GRUPO_NOME, GRUPO_DESCRICAO ASC", DgvGrupo);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAlter.Enabled = false;
            btnSubmit.Enabled = true;
            txtGrupoID.Text = "";
            txtGrupoName.Text = "";
            txtGrupoDesc.Text = "";
            LoadData();
        }

        private void DgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGrupoID.Text = DgvGrupo.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            txtGrupoName.Text = DgvGrupo.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            txtGrupoDesc.Text = DgvGrupo.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            btnSubmit.Enabled = false;
            btnDelete.Enabled = true;
            btnAlter.Enabled = true;
            txtGrupoName.Select();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////
            if (string.IsNullOrWhiteSpace(this.txtGrupoName.Text))
            { errorProvider.SetError(txtGrupoName, "Required"); }
            else
            {
                errorProvider.Clear();
                try
                {
                    clsUtility.ExecuteSQLQuery(" INSERT INTO grupo (GRUPO_NOME, GRUPO_DESCRICAO) VALUES ('" + txtGrupoName.Text + "','" + txtGrupoDesc.Text + "') ");
                    LoadData();
                    //btnReset.PerformClick();
                    bunifuSnackbar.Show(this, message.MessageShow("Saved"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            ///////////////////////////////////////////

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////
            if (string.IsNullOrWhiteSpace(this.txtGrupoName.Text) | string.IsNullOrWhiteSpace(this.txtGrupoID.Text))
            { errorProvider.SetError(txtGrupoName, "Required"); }
            else
            {
                errorProvider.Clear();
                try
                {
                    clsUtility.ExecuteSQLQuery("UPDATE  grupo SET GRUPO_NOME='" + txtGrupoName.Text + "',GRUPO_DESCRICAO='" + txtGrupoDesc.Text + "'" + " WHERE  GRUPO_ID='" + txtGrupoID.Text + "'  ");
                    //btnReset.PerformClick();
                    bunifuSnackbar.Show(this, message.MessageShow("Update"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            ///////////////////////////////////////////
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////
            if (string.IsNullOrWhiteSpace(this.txtGrupoID.Text))
            { errorProvider.SetError(txtGrupoName, "Required"); }
            else
            {
                errorProvider.Clear();
                try
                {
                    clsUtility.ExecuteSQLQuery("DELETE FROM  grupo WHERE  GRUPO_ID='" + txtGrupoID.Text + "'  ");
                    //btnReset.PerformClick();
                    bunifuSnackbar.Show(this, message.MessageShow("Delete"), Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            ///////////////////////////////////////////
        }
    }
}
