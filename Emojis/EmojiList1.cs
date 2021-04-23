using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Bunifu.UI;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot
{
    public partial class EmojiList1 : UserControl
    {
        public EmojiList1()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollEmoji;

        private void EmojiList1_Load(object sender, EventArgs e)
        {
            vScrollEmoji = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panelEmojis, gunaVScrollBarEmoji, true);
            vScrollEmoji.UpdateScrollBar();
        }

        private void panelEmojis_Resize(object sender, EventArgs e)
        {
            if (vScrollEmoji != null) vScrollEmoji.UpdateScrollBar();
        }

        private void emojiO1_Click(object sender, EventArgs e)
        {
            try
            {
                Form main = Application.OpenForms["Main"];
                Guna2TextBox send_emoji = (Guna2TextBox)main.Controls["pnFooterMessage"].Controls["txtMsg"];
                send_emoji.Text += "😀";
            }
            catch(Exception erro)
            {
                //Bunifu.Snackbar.Show(this.FindForm(), erro.Message, 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }

        private void emojiO2_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Main"];
            Guna2TextBox send_emoji = (Guna2TextBox)main.Controls["pnFooterMessage"].Controls["txtMsg"];
            send_emoji.Text += "😃";
        }

        private void emojiO3_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Main"];
            Guna2TextBox send_emoji = (Guna2TextBox)main.Controls["pnFooterMessage"].Controls["txtMsg"];
            send_emoji.Text += "😄";
        }
    }
   
}