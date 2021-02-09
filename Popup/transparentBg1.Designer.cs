
namespace WhatsApp_Robot.Popup
{
    partial class transparentBg1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formLauncher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // formLauncher
            // 
            this.formLauncher.Enabled = true;
            this.formLauncher.Tick += new System.EventHandler(this.formLauncher_Tick);
            // 
            // transparentBg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(757, 497);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transparentBg1";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "transparentBg1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer formLauncher;
    }
}