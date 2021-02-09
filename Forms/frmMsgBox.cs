using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WhatsApp_Robot
{
    public partial class frmMsgBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMsgBox(string msg, string alertType)
        {
            InitializeComponent();

            if (msg == "msgSaved")
            {
                //////////////////Saved//////////////
                string save_msg = "";
                if (Properties.Settings.Default.App_Default_Language)
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                        XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                        foreach (XmlNode languageNode in languageNodes)
                        {
                            XmlNode l1190 = languageNode["l1190"];
                            save_msg = l1190.InnerText;
                        }
                        lblMsg.Text = save_msg.ToString();
                    }
                    catch (Exception)
                    {
                        lblMsg.Text = "Information has been saved successfully.";
                    }
                }
                else { lblMsg.Text = "Information has been saved successfully."; }
                //////////////////Saved//////////////
            }
            if (msg == "msgUpdate")
            {
                //////////////////Update//////////////
                string update_msg = "";
                if (Properties.Settings.Default.App_Default_Language)
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                        XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                        foreach (XmlNode languageNode in languageNodes)
                        {
                            XmlNode l1191 = languageNode["l1191"];
                            update_msg = l1191.InnerText;
                        }
                        lblMsg.Text = update_msg.ToString();
                    }
                    catch (Exception)
                    {
                        lblMsg.Text = "Information has been updated successfully.";
                    }
                }
                else { lblMsg.Text = "Information has been updated successfully."; }
                //////////////////Update//////////////
            }
            if (msg == "msgDelete")
            {
                //////////////////Delete//////////////
                string delete_msg = "";
                if (Properties.Settings.Default.App_Default_Language)
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                        XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                        foreach (XmlNode languageNode in languageNodes)
                        {
                            XmlNode l1192 = languageNode["l1192"];
                            delete_msg = l1192.InnerText;
                        }
                        lblMsg.Text = delete_msg.ToString();
                    }
                    catch (Exception)
                    {
                        lblMsg.Text = "Information has been deleted successfully.";
                    }
                }
                else { lblMsg.Text = "Information has been deleted successfully."; }
                //////////////////Delete//////////////
            }

            if (msg == "msgNotFound")
            {
                //////////////////Delete//////////////
                string NotFound_msg = "";
                if (Properties.Settings.Default.App_Default_Language)
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(@"Language\" + Properties.Settings.Default.App_Language + ".xml");
                        XmlNodeList languageNodes = xmlDocument.GetElementsByTagName("language");
                        foreach (XmlNode languageNode in languageNodes)
                        {
                            XmlNode l1193 = languageNode["l1193"];
                            NotFound_msg = l1193.InnerText;
                        }
                        lblMsg.Text = NotFound_msg.ToString();
                    }
                    catch (Exception)
                    {
                        lblMsg.Text = "No data found.";
                    }
                }
                else { lblMsg.Text = "No data found."; }
                //////////////////Delete//////////////
            }


            /*if (alertType == "suss") { pictureBox1.Image = Orion.Properties.Resources.Checkmark_28px; lblMsg.ForeColor = Color.White; this.BackColor = this.BackColor = Color.FromArgb(42, 171, 160); System.Media.SystemSounds.Beep.Play(); }
            else if (alertType == "err") { pictureBox1.Image = Orion.Properties.Resources.msg_error; lblMsg.ForeColor = Color.White; this.BackColor = Color.FromArgb(255, 121, 70); System.Media.SystemSounds.Beep.Play(); }
            else if (alertType == "info") { pictureBox1.Image = Orion.Properties.Resources.Info_28px; lblMsg.ForeColor = Color.White; this.BackColor = Color.FromArgb(71, 169, 248); System.Media.SystemSounds.Asterisk.Play(); }
            else if (alertType == "que") { pictureBox1.Image = Orion.Properties.Resources.msg_ques; lblMsg.ForeColor = Color.White; this.BackColor = Color.FromArgb(71, 169, 248); System.Media.SystemSounds.Question.Play(); }
            else if (alertType == "exc") { pictureBox1.Image = Orion.Properties.Resources.Warning_28px; lblMsg.ForeColor = Color.White; this.BackColor = Color.FromArgb(255, 179, 2); System.Media.SystemSounds.Exclamation.Play(); }
            else { pictureBox1.Image = Orion.Properties.Resources.Info_28px; lblMsg.ForeColor = Color.White; this.BackColor = Color.FromArgb(71, 169, 248); System.Media.SystemSounds.Asterisk.Play(); }*/
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
