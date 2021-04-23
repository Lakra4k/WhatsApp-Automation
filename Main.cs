using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System.Media;
using System.Globalization;
using Guna.UI2.WinForms;
using WhatsApp_Robot.Model;
using System.Data;

namespace WhatsApp_Robot
{
    public partial class Main : Form
    {
        //new Bunifu.UI.WinForms.BunifuPictureBox PicBox;

        private IWebDriver Driver;
        private List<string> list = new List<string>();

        public Main()
        {
            InitializeComponent();
            /*
            chkSendImage.Name = "chkSendImage";
            btnOpenImage.Name = "btnOpenImage";
            chkCaption.Name = "chkCaption";
            chkFile.Name = "chkFile";
            btnOpenFile.Name = "btnOpenFile";
            //btnExport.Name = "btnExport";
            btnStart.Name = "btnStart";
            btnEnviar.Name = "btnEnviar";*/
        }


        private bool cekAlert()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch //(Exception ex)
            {
                return false;
            }
        }

        private void AddToList()
        {
            list.Clear();
            for (int i = 0, loopTo = Dgv.Rows.Count - 1; i <= loopTo; i++)
                list.Add(Conversions.ToString(Dgv.Rows[i].Cells["DgvNoHp"].Value));
            for (int i = 0, loopTo1 = Dgv.Rows.Count - 1; i <= loopTo1; i++)
                Dgv.Rows[i].Cells["DgvStatus"].Value = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*Bitmap b = new Bitmap(@"ahegao.png");
            var radios = 10;
            StackBlur.StackBlur.Process(b, radios);
            Emojis1.BackgroundImage = b;*/

            bunifuSnackbar.Show(this, "La***4k@outlook.com, Seja Bem-vindo(a)!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000);

            pbProfileImage.BorderRadius = 10;
            PicBox.Image = null;
            /*PicBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            PicBox.BorderRadius = 5;
            PicBox.Location = new Point(321, 233);
            PicBox.Size = new Size(207, 128);*/
            //bunifuPanel1.BackColor = Color.FromArgb(150, 0, 0, 0);


            /*Progress loading start code*/
            pnProcess.Enabled = false;
            pnProcess.Visible = false;
            PicBlur.Enabled = false;
            PicBlur.Visible = false;
            PBB.Animated = false;
            PBB.Visible = false;
            /*Progress loading end code*/



            //////////////////////////////////////
            LoadData();
            //////////////////////////////////////

            CheckForIllegalCrossThreadCalls = false;
            BackgroundWorker BGW;
            BGW = new BackgroundWorker();
            //picTransparent.BackColor = Color.FromArgb(100, 0, 0, 0);
            //PBB
            txtPathImage.ReadOnly = true;
            txtPathFile.ReadOnly = true;
            chkCaption.Enabled = true;
            txtCaption.Enabled = true;
            btnOpenImage.Enabled = false;
            btnOpenFile.Enabled = false;
            btnEnviar.Enabled = false;
        }

        private void LoadData()
        {
            clsUtility.FillComboBox(" SELECT  GRUPO_ID, GRUPO_NOME  FROM  grupo  ORDER BY GRUPO_NOME", "GRUPO_ID", "GRUPO_NOME", cmbGroup);

            clsUtility.FillDataGrid("SELECT ClienteNome, Telefone " +
                                    " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) ORDER BY ClienteNome ", Dgv);
        }

        #region Connect
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Conectar")
            {
                Driver = new ChromeDriver();
                //abrir o browser
                try
                {
                    Driver.Navigate().GoToUrl("https://web.whatsapp.com/");
                    btnStart.IdleIconRightImage = Properties.Resources.Grupo_7;
                    btnStart.Text = "Desconectar";
                    btnEnviar.Enabled = true;
                }
                catch (Exception erro)
                {
                    bunifuSnackbar.Show(this, erro.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
            }
            else
            {
                Driver.Quit();
                btnStart.Text = "Conectar";
                btnStart.IdleIconRightImage = Properties.Resources.conn;
                btnEnviar.Enabled = false;
            }
        }
        #endregion

        private void chkGambar_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkSendImage.Checked == true)
            {
                btnOpenImage.Enabled = true;
                chkCaption.Enabled = true;
            }
            else
            {
                txtPathImage.Clear();
                txtPathFile.Clear();
                btnOpenImage.Enabled = false;
                chkCaption.ForeColor = Color.Silver;
                chkCaption.Enabled = false;
                chkCaption.Checked = false;
                PicBox.Image = null;
            }
        }
        private void chkGambar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSendImage.Checked == true)
            {
                btnOpenImage.Enabled = true;
                chkCaption.Enabled = true;
            }
            else
            {
                txtPathFile.Clear();
                btnOpenImage.Enabled = false;
                chkCaption.ForeColor = Color.Silver;
                chkCaption.Enabled = false;
                chkCaption.Checked = false;
                PicBox.Image = null;
            }
        }
        private void chkCaption_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkCaption.Checked == true)
            {
                txtCaption.Enabled = true;
            }
            else
            {
                txtCaption.Enabled = false;
                txtCaption.Clear();
            }
        }

        #region Open Image
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OFD.Title = "Carregar Imagem";
            OFD.Multiselect = true;
            OFD.Filter = "Image Files (*.png *.jpg *.bmp) |*png; *.jpg; *.bmp";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtPathImage.Text = OFD.FileName;
                foreach (var myFile in OFD.FileNames)
                {
                    // Criar um novo fluxo para carregar esta foto em
                    var MyStream = new FileStream(myFile, FileMode.Open, FileAccess.Read);
                    // Criar um buffer para armazenar o fluxo de bytes
                    var myImageBuffer = new byte[(int)(MyStream.Length + 1)];

                    // Leia os bytes deste fluxo e colocá-lo no buffer de imagem
                    MyStream.Read(myImageBuffer, 0, Convert.ToInt32(MyStream.Length));
                    // Fechar o fluxo
                    MyStream.Close();
                    var Streamed = new MemoryStream(myImageBuffer);
                    PicBox.Image = Image.FromStream(Streamed);
                    Streamed.Close();
                    myImageBuffer = null;
                }
            }
        }
        #endregion

        #region Open File
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OFD.Title = "Anexar Ficheiro";
            OFD.Multiselect = true;
            OFD.Filter = "All files (*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = OFD.FileName;
            }
        }
        #endregion

        #region use excel file
        private void btnExport_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(op.FileName))
                {
                    string[] Arr = null;
                    Arr = op.FileName.Split('.');
                    if (Arr.Length > 0)
                    {
                        if (Arr[Arr.Length - 1] == "xls")
                        {
                            sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + op.FileName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                        }
                        else if (Arr[Arr.Length - 1] == "xlsx")
                        {
                            sConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + op.FileName + "';Extended Properties=Excel 8.0;";
                        }
                    }
                    FillData();
                }
            }*/
            //    OleDbConnection CONN;
            //    OleDbDataAdapter DA;
            //    var DS = new DataSet();

            //    OFD.Title = "Importar Lista do Excel";
            //    OFD.Multiselect = false;
            //    OFD.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*";
            //    if (OFD.ShowDialog() == DialogResult.OK)
            //    {
            //        CONN = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "data source='" + OFD.FileName + "';Extended Properties=Excel 8.0;");
            //        DA = new OleDbDataAdapter("select * from [Sheet1$]", CONN);
            //        try
            //        {
            //            CONN.Open();
            //            DS.Clear();
            //            DA.Fill(DS);
            //            Dgv.Rows.Clear();
            //            for (int i = 0, loopTo = DS.Tables[0].Rows.Count - 1; i <= loopTo; i++)
            //            {
            //                Dgv.Rows.Add();
            //                Dgv.Rows[Dgv.Rows.Count - 1].Cells["DgvNoHP"].Value = DS.Tables[0].Rows[i]["Lista dos Contactos"];
            //                modelContacts.Add(new ModelContacts(DS.Tables[0].Rows[i]["Lista dos Contactos"].ToString(), ""));
            //            }

            //            CONN.Close();

            //            btnEnviar.Enabled = true;
            //        }
            //        catch
            //        {
            //            Bunifu.Snackbar.Show(this.FindForm(), "A tabela externa não esta aberta, tente novamente.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
            //        }
            //    }
        }
        public string sConnectionString;
        private void FillData()
        {
            /*
            if (sConnectionString.Length > 0)
            {
                OleDbConnection cn = new OleDbConnection(sConnectionString);
                try
                {
                    cn.Open();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter Adpt = new OleDbDataAdapter("select * from [sheet1$]", cn);
                    Adpt.Fill(dt);
                    Dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        #endregion


        private void chkFile_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkFile.Checked == true)
            {
                btnOpenFile.Enabled = true;
            }
            else
            {
                txtPathFile.Clear();
                btnOpenFile.Enabled = false;
            }
        }

        #region Send Mensage
        private void BroadCast()
        {
            //PB.Value = 0;
            //PB.Maximum = list.Count;
            lblProses.Text = "0 / " + list.Count;
            for (int i = 0, loopTo = list.Count - 1; i <= loopTo; i++)
            {
                string URL = "https://web.whatsapp.com/send?phone=" + list[i] + "&text=" + txtMsg.Text + "&source&data&app_absent";
                Driver.Navigate().GoToUrl(URL);
                if (cekAlert() == true)
                    Driver.SwitchTo().Alert().Accept();
                try
                {
                    System.Threading.Thread.Sleep(17000); //17 segundos
                    // verifique se o número do celular não está cadastrado
                    if (txtMsg.Text != null)
                    {
                        Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click();
                    }

                    if (chkSendImage.Checked == true)
                    {
                        // Clique no botão Attach Image
                        Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click();
                        // adicionar arquivo para enviar por file path
                        // Driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(txtPathFilr.Text)
                        Driver.FindElement(By.CssSelector("input[accept='image/*,video/mp4,video/3gpp,video/quicktime']")).SendKeys(txtPathImage.Text);
                        if (chkCaption.Checked == true)
                        {
                            // Tipo options
                            System.Threading.Thread.Sleep(2000);
                            Driver.FindElement(By.CssSelector("div[contenteditable='true']")).SendKeys(txtCaption.Text);
                        }

                        // Click to send
                        System.Threading.Thread.Sleep(1000);
                        Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click();
                        System.Threading.Thread.Sleep(3000);
                    }

                    if (chkFile.Checked == true)
                    {
                        // Clique no botão attach Image
                        Driver.FindElement(By.CssSelector("span[data-icon='clip']")).Click();
                        // add file to send by file path

                        Driver.FindElement(By.CssSelector("input[accept='*']")).SendKeys(txtPathFile.Text);
                        System.Threading.Thread.Sleep(1000);
                        Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click();
                        System.Threading.Thread.Sleep(3000);
                    }
                    Dgv.Rows[i].Cells["DgvStatus"].Value = "Sucesso";
                }
                catch //(Exception ex)
                {
                    Dgv.Rows[i].Cells["DgvStatus"].Value = "Falha";
                }

                //PB.Value = 1 + 1;
                lblProses.Text = i + 1 + "/ " + list.Count;
            }
        }
        #endregion

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            BroadCast();
            /*Progress loading start code*/
            pnProcess.Enabled = false;
            pnProcess.Visible = false;
            PicBlur.Enabled = false;
            PicBlur.Visible = false;
            PBB.Animated = false;
            PBB.Visible = false;
            PicBlur.SendToBack();
            pnProcess.SendToBack();
        }

        #region Send Message

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMsg.Text))
            {
                bunifuSnackbar.Show(this, "Digite qualquer coisa", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
            }
            else
            {
                if (btnStart.Text == "Conectar")
                {
                    bunifuSnackbar.Show(this, "Conecte Primeiro ao seu WhatsApp", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                }
                else
                {
                    AddToList();
                    /*Progress loading start code*/
                    pnProcess.Enabled = true;
                    pnProcess.Visible = true;
                    PicBlur.Enabled = true;
                    PicBlur.Visible = true;
                    PBB.Animated = true;
                    PBB.Visible = true;
                    PicBlur.BringToFront();
                    pnProcess.BringToFront();
                    pnHeader.BringToFront();
                    /*Progress loading end code*/
                    BGW.RunWorkerAsync();/* TODO ERROR: Progress linear */
                }
            }
        }

        #endregion

        private void Dgv_Resize(object sender, EventArgs e)
        {
            //if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Visible == true)
            {
                if (!txtPesquisar.Visible) bunifuTransition2.HideSync(lbListadosConta);
                else bunifuTransition1.ShowSync(lbListadosConta);

                if (!txtPesquisar.Visible) bunifuTransition1.ShowSync(txtPesquisar);
                else bunifuTransition1.HideSync(txtPesquisar);
                btnSearch.Text = "search";
                txtPesquisar.Clear();
            }
            else
            {
                if (!txtPesquisar.Visible) bunifuTransition1.ShowSync(txtPesquisar);
                else bunifuTransition1.HideSync(txtPesquisar);

                if (!txtPesquisar.Visible) bunifuTransition2.HideSync(lbListadosConta);
                else bunifuTransition1.ShowSync(lbListadosConta);
                btnSearch.Text = "";
                txtPesquisar.Focus();
            }
        }

        private void btnEmojiFulList_Click(object sender, EventArgs e)
        {
            if (!pnEmojiList.Visible)
            {
                btnTextStyleList.Text = "";
                bunifuTransition3.ShowSync(pnEmojiList);
                //txtMsg.Focus();
            }
            else
                bunifuTransition3.HideSync(pnEmojiList);
        }

        // Verificar se e number
        static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(txtPesquisar.Text))
            {
                clsUtility.FillDataGrid("SELECT ClienteNome, Telefone " +
                                               " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) WHERE   (Telefone LIKE '%" + txtPesquisar.Text + "%') ORDER BY ClienteNome ", Dgv);
            }
            else
            {
                clsUtility.FillDataGrid("SELECT ClienteNome, Telefone " +
                                               " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) WHERE   (ClienteNome LIKE '%" + txtPesquisar.Text + "%') ORDER BY ClienteNome ", Dgv);
            }
        }

        private void btnEmojiList1_Click(object sender, EventArgs e)
        {
            EmojiListPages.SetPage("Emojis1");
        }

        private void btnEmojiList2_Click(object sender, EventArgs e)
        {
            EmojiListPages.SetPage("Emojis2");
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            /*if(txtMsg.SelectedText.Length > 0) { 
            txtMsg.Text.Remove(txtMsg.SelectionStart, txtMsg.SelectionLength);
             
            Console.WriteLine(txtMsg.SelectionStart.ToString());
            Console.WriteLine(txtMsg.SelectionLength.ToString());*/


            // txtMsg.Text.Insert(txtMsg.SelectionStart, txtMsg.SelectionLength) += temporary.Text;
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            txtMsg.Font = new Font(txtMsg.Font.FontFamily, txtMsg.Font.Size, FontStyle.Italic);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            txtMsg.Font = new Font(txtMsg.Font.FontFamily, txtMsg.Font.Size, FontStyle.Underline);
        }

        private void btnLineInText_Click(object sender, EventArgs e)
        {
            txtMsg.Font = new Font(txtMsg.Font.FontFamily, txtMsg.Font.Size, FontStyle.Strikeout);
        }

        private void btnTextStyleList_Click(object sender, EventArgs e)
        {
            /*if (!pnStyleText.Visible)
            {
                btnTextStyleList.Text = "";
                bunifuTransition2.HideSync(pnEmojiList);
                bunifuTransition4.ShowSync(pnStyleText);
            }
            else
            {
                btnTextStyleList.Text = ""; 
                bunifuTransition4.HideSync(pnStyleText);
            }*/
        }

        private void btnHidenStyle_Click(object sender, EventArgs e)
        {
            btnTextStyleList.Text = "";
            //bunifuTransition2.HideSync(pnStyleText);
        }

        #region Send Mensage to contact
        private void Dgv_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    ContextMenuStrip op_lista = new ContextMenuStrip();

                    //Primeiro item da ista
                    ToolStripMenuItem send = new ToolStripMenuItem();
                    send.Name = "send";
                    send.Text = "Enviar mensagem a este contacto";
                    //send.ForeColor = Color.White;
                    send.BackColor = Color.Black;

                    ToolStripMenuItem del = new ToolStripMenuItem();
                    del.Name = "del";
                    del.Text = "Apagar contacto";
                    del.BackColor = Color.Black;


                    int posicao = Dgv.HitTest(e.X, e.Y).RowIndex;

                    op_lista.BackColor = Color.FromArgb(22, 23, 23);
                    op_lista.Font = new Font("Rubik", 9, FontStyle.Regular);
                    op_lista.ForeColor = Color.White;
                    if (posicao >= 0)
                    {
                        op_lista.Items.Add(send);
                        op_lista.Items.Add(del);
                        //op_lista.Items.Add("Deletar").BackColor = Color.Black;
                    }
                    op_lista.Show(Dgv, new Point(e.X, e.Y));

                    //Chamar evento ao clicar o item
                    op_lista.ItemClicked += Op_lista_ItemClicked;

                }
            }

        }

        private void Op_lista_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString())
            {
                case "send":

                    PicBlur.SendToBack();

                    bunifuSnackbar.Show(this, "Conecte Primeiro ao seu WhatsApp", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                    break;

                case "del":

                    bunifuSnackbar.Show(this, "Apagado", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                    break;
            }
        }

        #endregion

        private void btnOpenContact_Click(object sender, EventArgs e)
        {
            if (!pnContactAction.Visible)
            {
                btnOpenContact.Text = "angle-left";
                bunifuTransition2.HideSync(pnEmojiList);
                bunifuTransition4.ShowSync(pnContactAction);
            }
            else
            {
                btnOpenContact.Text = "angle-right";
                bunifuTransition4.HideSync(pnContactAction);
            }
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmGroup frmGroup = new frmGroup();
            frmGroup.ShowDialog();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer("0");
            frmCustomer.ShowDialog();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            frmListCustomer frmListCustomer = new frmListCustomer();
            frmListCustomer.ShowDialog();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue == null | cmbGroup.SelectedIndex == -1)
            {
                LoadData();
            }
            else
            {
                try
                {
                    clsUtility.FillDataGrid(" SELECT ClienteNome, Telefone " +
                                            " FROM cliente  LEFT OUTER JOIN grupo ON (grupo.GRUPO_ID = cliente.GRUPO_ID) WHERE   (cliente.GRUPO_ID='" + cmbGroup.SelectedValue.ToString() + "') ORDER BY ClienteNome ", Dgv);

                    //Back All
                    imgShadow.Visible = false;
                    pnOpenAllContact.Enabled = false;
                    pnOpenAllContact.Visible = false;
                    PicBlur.Enabled = false;
                    PicBlur.Visible = false;
                    btnHideSelectGroup.Enabled = false;
                    btnHideSelectGroup.Visible = false;
                    imgShadow.SendToBack();
                    pnOpenAllContact.SendToBack();
                    btnHideSelectGroup.SendToBack();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void btnSendMessageToAll_Click(object sender, EventArgs e)
        {
            clsUtility.FillDataGrid(" SELECT ClienteNome, Telefone FROM cliente ORDER BY  ClienteNome, Telefone ASC", Dgv);

            //Back All
            imgShadow.Visible = false;
            pnOpenAllContact.Enabled = false;
            pnOpenAllContact.Visible = false;
            PicBlur.Enabled = false;
            PicBlur.Visible = false;
            btnHideSelectGroup.Enabled = false;
            btnHideSelectGroup.Visible = false;
            imgShadow.SendToBack();
            pnOpenAllContact.SendToBack();
            btnHideSelectGroup.SendToBack();
        }

        private void btnOpenContactToSend_Click(object sender, EventArgs e)
        {
            imgShadow.Visible = true;
            pnOpenAllContact.Enabled = true;
            pnOpenAllContact.Visible = true;
            PicBlur.Enabled = true;
            PicBlur.Visible = true;
            btnHideSelectGroup.Enabled = true;
            btnHideSelectGroup.Visible = true;
            imgShadow.BringToFront();
            pnOpenAllContact.BringToFront();
            btnHideSelectGroup.BringToFront();
        }

        private void btnHideSelectGroup_Click(object sender, EventArgs e)
        {
            //Back All
            imgShadow.Visible = false;
            pnOpenAllContact.Enabled = false;
            pnOpenAllContact.Visible = false;
            PicBlur.Enabled = false;
            PicBlur.Visible = false;
            btnHideSelectGroup.Enabled = false;
            btnHideSelectGroup.Visible = false;
            imgShadow.SendToBack();
            pnOpenAllContact.SendToBack();
            btnHideSelectGroup.SendToBack();
        }

        private void btnRefreshDgv_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        int dir = 1;
        private void stretch_Tick(object sender, EventArgs e)
        {
            if (PBB.Value == 90)
            {
                dir = -1;  // reduce
                PBB.AnimationInterval = 4;
            }
            else if (PBB.Value == 10)
            {
                dir = +1; //expand
                PBB.AnimationInterval = 2;
            }

            PBB.Value += dir;
        }
    }

}
