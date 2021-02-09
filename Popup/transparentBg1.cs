using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp_Robot.Popup
{
    /// <summary>
    /// Class transparentBg1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class transparentBg1 : Form
    {
        /// <summary>
        /// The child
        /// </summary>
        Form _child = null;
        /// <summary>
        /// Initializes a new instance of the <see cref="transparentBg"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        public transparentBg1(Form parent, Form child)
        {
            InitializeComponent();
            _child = child;

            this.Location = parent.Location;
            this.Size = parent.Size;
            this.ShowDialog();
        }
        public transparentBg1(Form child)
        {
            InitializeComponent();
            _child = child;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        /// <summary>
        /// Handles the Load event of the transparentForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void transparentForm_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

        private void formLauncher_Tick(object sender, EventArgs e)
        {
            formLauncher.Stop();
            _child.ShowDialog();
            this.Close();
        }

    }
}
