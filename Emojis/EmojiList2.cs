using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace WhatsApp_Robot.Emojis
{
    public partial class EmojiList2 : UserControl
    {
        public EmojiList2()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollEmoji;

        private void EmojiList2_Load(object sender, EventArgs e)
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
            Form main = Application.OpenForms["Main"];
            Guna2TextBox send_emoji = (Guna2TextBox)main.Controls["guna2Panel2"].Controls["txtMsg"];
            send_emoji.Text += "🐵";
        }
    }
}
