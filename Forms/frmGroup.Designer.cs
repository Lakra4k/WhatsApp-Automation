
namespace WhatsApp_Robot
{
    partial class frmGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroup));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtGrupoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrupoID = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvGrupo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlter = new Guna.UI2.WinForms.Guna2Button();
            this.GunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.txtGrupoDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtGrupoName
            // 
            this.txtGrupoName.Animated = true;
            this.txtGrupoName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoName.BorderRadius = 8;
            this.txtGrupoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrupoName.DefaultText = "";
            this.txtGrupoName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrupoName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrupoName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoName.DisabledState.Parent = this.txtGrupoName;
            this.txtGrupoName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtGrupoName.FocusedState.Parent = this.txtGrupoName;
            this.txtGrupoName.Font = new System.Drawing.Font("Rubik", 8.9F);
            this.txtGrupoName.ForeColor = System.Drawing.Color.White;
            this.txtGrupoName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txtGrupoName.HoverState.Parent = this.txtGrupoName;
            this.txtGrupoName.Location = new System.Drawing.Point(31, 82);
            this.txtGrupoName.Name = "txtGrupoName";
            this.txtGrupoName.PasswordChar = '\0';
            this.txtGrupoName.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtGrupoName.PlaceholderText = "Nome do Grupo";
            this.txtGrupoName.SelectedText = "";
            this.txtGrupoName.ShadowDecoration.Parent = this.txtGrupoName;
            this.txtGrupoName.Size = new System.Drawing.Size(377, 38);
            this.txtGrupoName.TabIndex = 17;
            this.txtGrupoName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtGrupoID
            // 
            this.txtGrupoID.Animated = true;
            this.txtGrupoID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoID.BorderRadius = 8;
            this.txtGrupoID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrupoID.DefaultText = "";
            this.txtGrupoID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrupoID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrupoID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoID.DisabledState.Parent = this.txtGrupoID;
            this.txtGrupoID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtGrupoID.FocusedState.Parent = this.txtGrupoID;
            this.txtGrupoID.Font = new System.Drawing.Font("Rubik", 8.9F);
            this.txtGrupoID.ForeColor = System.Drawing.Color.White;
            this.txtGrupoID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txtGrupoID.HoverState.Parent = this.txtGrupoID;
            this.txtGrupoID.Location = new System.Drawing.Point(414, 82);
            this.txtGrupoID.Name = "txtGrupoID";
            this.txtGrupoID.PasswordChar = '\0';
            this.txtGrupoID.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtGrupoID.PlaceholderText = "";
            this.txtGrupoID.SelectedText = "";
            this.txtGrupoID.ShadowDecoration.Parent = this.txtGrupoID;
            this.txtGrupoID.Size = new System.Drawing.Size(35, 38);
            this.txtGrupoID.TabIndex = 18;
            this.txtGrupoID.TextOffset = new System.Drawing.Point(5, 0);
            this.txtGrupoID.Visible = false;
            // 
            // DgvGrupo
            // 
            this.DgvGrupo.AllowUserToAddRows = false;
            this.DgvGrupo.AllowUserToDeleteRows = false;
            this.DgvGrupo.AllowUserToResizeColumns = false;
            this.DgvGrupo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DgvGrupo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGrupo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DgvGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvGrupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvGrupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGrupo.ColumnHeadersHeight = 17;
            this.DgvGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rubik", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGrupo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvGrupo.EnableHeadersVisualStyles = false;
            this.DgvGrupo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DgvGrupo.Location = new System.Drawing.Point(31, 265);
            this.DgvGrupo.Name = "DgvGrupo";
            this.DgvGrupo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrupo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvGrupo.RowHeadersVisible = false;
            this.DgvGrupo.RowHeadersWidth = 47;
            this.DgvGrupo.RowTemplate.Height = 25;
            this.DgvGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGrupo.Size = new System.Drawing.Size(445, 352);
            this.DgvGrupo.TabIndex = 26;
            this.DgvGrupo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DgvGrupo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DgvGrupo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvGrupo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvGrupo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvGrupo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvGrupo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.DgvGrupo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DgvGrupo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.DgvGrupo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvGrupo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.DgvGrupo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvGrupo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvGrupo.ThemeStyle.HeaderStyle.Height = 17;
            this.DgvGrupo.ThemeStyle.ReadOnly = true;
            this.DgvGrupo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DgvGrupo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvGrupo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Rubik", 10F);
            this.DgvGrupo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DgvGrupo.ThemeStyle.RowsStyle.Height = 25;
            this.DgvGrupo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.DgvGrupo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            this.DgvGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GRUPO_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GRUPO_NOME";
            this.Column2.HeaderText = "Nome do Grupo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GRUPO_DESCRICAO";
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(0, 56);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(687, 10);
            this.guna2Separator2.TabIndex = 33;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Rubik", 15F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(159, 19);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(180, 27);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Cadastrar Grupos";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            this.btnSubmit.BorderRadius = 13;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnSubmit.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(31, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(89, 29);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Salvar";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            this.btnRefresh.BorderRadius = 13;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnRefresh.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(221, 214);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(89, 29);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.BorderRadius = 13;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnDelete.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(316, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(89, 29);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Animated = true;
            this.btnAlter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(161)))));
            this.btnAlter.BorderRadius = 13;
            this.btnAlter.BorderThickness = 1;
            this.btnAlter.CheckedState.Parent = this.btnAlter;
            this.btnAlter.CustomImages.Parent = this.btnAlter;
            this.btnAlter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnAlter.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold);
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnAlter.HoverState.Parent = this.btnAlter;
            this.btnAlter.Location = new System.Drawing.Point(126, 214);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.ShadowDecoration.Parent = this.btnAlter;
            this.btnAlter.Size = new System.Drawing.Size(89, 29);
            this.btnAlter.TabIndex = 37;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // GunaVScrollBar1
            // 
            this.GunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.GunaVScrollBar1.LargeChange = 10;
            this.GunaVScrollBar1.Location = new System.Drawing.Point(482, 205);
            this.GunaVScrollBar1.Maximum = 100;
            this.GunaVScrollBar1.Name = "GunaVScrollBar1";
            this.GunaVScrollBar1.Radius = 5;
            this.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GunaVScrollBar1.Size = new System.Drawing.Size(10, 412);
            this.GunaVScrollBar1.TabIndex = 46;
            this.GunaVScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // txtGrupoDesc
            // 
            this.txtGrupoDesc.Animated = true;
            this.txtGrupoDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoDesc.BorderRadius = 8;
            this.txtGrupoDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrupoDesc.DefaultText = "";
            this.txtGrupoDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrupoDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrupoDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoDesc.DisabledState.Parent = this.txtGrupoDesc;
            this.txtGrupoDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrupoDesc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.txtGrupoDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtGrupoDesc.FocusedState.Parent = this.txtGrupoDesc;
            this.txtGrupoDesc.Font = new System.Drawing.Font("Rubik", 8.9F);
            this.txtGrupoDesc.ForeColor = System.Drawing.Color.White;
            this.txtGrupoDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.txtGrupoDesc.HoverState.Parent = this.txtGrupoDesc;
            this.txtGrupoDesc.Location = new System.Drawing.Point(31, 126);
            this.txtGrupoDesc.Multiline = true;
            this.txtGrupoDesc.Name = "txtGrupoDesc";
            this.txtGrupoDesc.PasswordChar = '\0';
            this.txtGrupoDesc.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtGrupoDesc.PlaceholderText = "Descrição...";
            this.txtGrupoDesc.SelectedText = "";
            this.txtGrupoDesc.ShadowDecoration.Parent = this.txtGrupoDesc;
            this.txtGrupoDesc.Size = new System.Drawing.Size(377, 75);
            this.txtGrupoDesc.TabIndex = 47;
            this.txtGrupoDesc.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // bunifuSnackbar
            // 
            this.bunifuSnackbar.AllowDragging = false;
            this.bunifuSnackbar.AllowMultipleViews = true;
            this.bunifuSnackbar.ClickToClose = true;
            this.bunifuSnackbar.DoubleClickToClose = true;
            this.bunifuSnackbar.DurationAfterIdle = 3000;
            this.bunifuSnackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.FadeCloseIcon = false;
            this.bunifuSnackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.Margin = 10;
            this.bunifuSnackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar.MaximumViews = 7;
            this.bunifuSnackbar.MessageRightMargin = 15;
            this.bunifuSnackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar.ShowBorders = false;
            this.bunifuSnackbar.ShowCloseIcon = true;
            this.bunifuSnackbar.ShowIcon = true;
            this.bunifuSnackbar.ShowShadows = true;
            this.bunifuSnackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.ViewsMargin = 7;
            this.bunifuSnackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.ZoomCloseIcon = true;
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(508, 629);
            this.Controls.Add(this.txtGrupoDesc);
            this.Controls.Add(this.GunaVScrollBar1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.DgvGrupo);
            this.Controls.Add(this.txtGrupoID);
            this.Controls.Add(this.txtGrupoName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGroup";
            this.Load += new System.EventHandler(this.frmGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtGrupoName;
        private Guna.UI2.WinForms.Guna2TextBox txtGrupoID;
        private Guna.UI2.WinForms.Guna2DataGridView DgvGrupo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAlter;
        internal Guna.UI.WinForms.GunaVScrollBar GunaVScrollBar1;
        private Guna.UI2.WinForms.Guna2TextBox txtGrupoDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
    }
}