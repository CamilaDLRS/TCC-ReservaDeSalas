namespace prjReservas_SESI_SENAI.Forms
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnDisciplinas = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnModalidades = new System.Windows.Forms.Button();
            this.btnCasas = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panelCanto = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAtivarFiltros = new System.Windows.Forms.Button();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCasa = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.panelBotoes.SuspendLayout();
            this.panelCanto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelBotoes.Controls.Add(this.btnDisciplinas);
            this.panelBotoes.Controls.Add(this.btnCursos);
            this.panelBotoes.Controls.Add(this.btnModalidades);
            this.panelBotoes.Controls.Add(this.btnCasas);
            this.panelBotoes.Controls.Add(this.btnSalas);
            this.panelBotoes.Controls.Add(this.btnUsuarios);
            this.panelBotoes.Controls.Add(this.btnReservar);
            this.panelBotoes.Controls.Add(this.panelCanto);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(195, 611);
            this.panelBotoes.TabIndex = 0;
            // 
            // btnDisciplinas
            // 
            this.btnDisciplinas.BackColor = System.Drawing.Color.Transparent;
            this.btnDisciplinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisciplinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisciplinas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDisciplinas.FlatAppearance.BorderSize = 0;
            this.btnDisciplinas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDisciplinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisciplinas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisciplinas.ForeColor = System.Drawing.Color.White;
            this.btnDisciplinas.Location = new System.Drawing.Point(0, 394);
            this.btnDisciplinas.Name = "btnDisciplinas";
            this.btnDisciplinas.Size = new System.Drawing.Size(195, 55);
            this.btnDisciplinas.TabIndex = 7;
            this.btnDisciplinas.Text = "      Disciplinas";
            this.btnDisciplinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisciplinas.UseVisualStyleBackColor = false;
            this.btnDisciplinas.Click += new System.EventHandler(this.btnDisciplinas_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Location = new System.Drawing.Point(0, 339);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(195, 55);
            this.btnCursos.TabIndex = 6;
            this.btnCursos.Text = "      Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnModalidades
            // 
            this.btnModalidades.BackColor = System.Drawing.Color.Transparent;
            this.btnModalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModalidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModalidades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModalidades.FlatAppearance.BorderSize = 0;
            this.btnModalidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModalidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModalidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModalidades.ForeColor = System.Drawing.Color.White;
            this.btnModalidades.Location = new System.Drawing.Point(0, 284);
            this.btnModalidades.Name = "btnModalidades";
            this.btnModalidades.Size = new System.Drawing.Size(195, 55);
            this.btnModalidades.TabIndex = 5;
            this.btnModalidades.Text = "      Modalidades";
            this.btnModalidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModalidades.UseVisualStyleBackColor = false;
            this.btnModalidades.Click += new System.EventHandler(this.btnModalidades_Click);
            // 
            // btnCasas
            // 
            this.btnCasas.BackColor = System.Drawing.Color.Transparent;
            this.btnCasas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCasas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCasas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCasas.FlatAppearance.BorderSize = 0;
            this.btnCasas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCasas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCasas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasas.ForeColor = System.Drawing.Color.White;
            this.btnCasas.Location = new System.Drawing.Point(0, 229);
            this.btnCasas.Name = "btnCasas";
            this.btnCasas.Size = new System.Drawing.Size(195, 55);
            this.btnCasas.TabIndex = 4;
            this.btnCasas.Text = "      Casas";
            this.btnCasas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasas.UseVisualStyleBackColor = false;
            this.btnCasas.Click += new System.EventHandler(this.btnCasas_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.Transparent;
            this.btnSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalas.ForeColor = System.Drawing.Color.White;
            this.btnSalas.Location = new System.Drawing.Point(0, 174);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(195, 55);
            this.btnSalas.TabIndex = 3;
            this.btnSalas.Text = "      Salas";
            this.btnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.UseVisualStyleBackColor = false;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 119);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(195, 55);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "      Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(0, 64);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(195, 55);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "      Reservar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // panelCanto
            // 
            this.panelCanto.BackColor = System.Drawing.Color.DarkGray;
            this.panelCanto.Controls.Add(this.pictureBox1);
            this.panelCanto.Controls.Add(this.label1);
            this.panelCanto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCanto.Location = new System.Drawing.Point(0, 0);
            this.panelCanto.Name = "panelCanto";
            this.panelCanto.Size = new System.Drawing.Size(195, 64);
            this.panelCanto.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjReservas_SESI_SENAI.Properties.Resources.agenda_colorido;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservas";
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Silver;
            this.panelTopo.Controls.Add(this.lblNomeUsuario);
            this.panelTopo.Controls.Add(this.menuStrip1);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(195, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(778, 64);
            this.panelTopo.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(372, 18);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNomeUsuario.Size = new System.Drawing.Size(354, 25);
            this.lblNomeUsuario.TabIndex = 20;
            this.lblNomeUsuario.Text = "Nome usuário";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario});
            this.menuStrip1.Location = new System.Drawing.Point(726, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(40, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MenuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarContaToolStripMenuItem,
            this.deslogarToolStripMenuItem});
            this.MenuUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUsuario.ForeColor = System.Drawing.Color.White;
            this.MenuUsuario.Image = global::prjReservas_SESI_SENAI.Properties.Resources.linhas_branco;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MenuUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuUsuario.RightToLeftAutoMirrorImage = true;
            this.MenuUsuario.Size = new System.Drawing.Size(32, 26);
            // 
            // alterarContaToolStripMenuItem
            // 
            this.alterarContaToolStripMenuItem.Name = "alterarContaToolStripMenuItem";
            this.alterarContaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.alterarContaToolStripMenuItem.Text = "Alterar perfil";
            this.alterarContaToolStripMenuItem.Click += new System.EventHandler(this.alterarContaToolStripMenuItem_Click);
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.btnExcluir);
            this.panelPrincipal.Controls.Add(this.btnAlterar);
            this.panelPrincipal.Controls.Add(this.groupBox);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.dgvReservas);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(195, 64);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(778, 547);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.Location = new System.Drawing.Point(413, 496);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(334, 36);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.Location = new System.Drawing.Point(36, 496);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(355, 36);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnAtivarFiltros);
            this.groupBox.Controls.Add(this.btnLimparFiltros);
            this.groupBox.Controls.Add(this.lblSala);
            this.groupBox.Controls.Add(this.cbSala);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.dtpFim);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.cbUsuario);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.cbCasa);
            this.groupBox.Controls.Add(this.dtpInicio);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(20, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(746, 151);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filtros";
            // 
            // btnAtivarFiltros
            // 
            this.btnAtivarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnAtivarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAtivarFiltros.FlatAppearance.BorderSize = 2;
            this.btnAtivarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtivarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAtivarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarFiltros.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAtivarFiltros.Location = new System.Drawing.Point(602, 41);
            this.btnAtivarFiltros.Name = "btnAtivarFiltros";
            this.btnAtivarFiltros.Size = new System.Drawing.Size(125, 36);
            this.btnAtivarFiltros.TabIndex = 28;
            this.btnAtivarFiltros.Text = "Filtrar";
            this.btnAtivarFiltros.UseVisualStyleBackColor = false;
            this.btnAtivarFiltros.Click += new System.EventHandler(this.btnAtivarFiltros_Click);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltros.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLimparFiltros.FlatAppearance.BorderSize = 2;
            this.btnLimparFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimparFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLimparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFiltros.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLimparFiltros.Location = new System.Drawing.Point(602, 101);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(125, 36);
            this.btnLimparFiltros.TabIndex = 16;
            this.btnLimparFiltros.Text = "Limpar filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = false;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.BackColor = System.Drawing.Color.Transparent;
            this.lblSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(12, 26);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(45, 20);
            this.lblSala.TabIndex = 27;
            this.lblSala.Text = "Sala:";
            // 
            // cbSala
            // 
            this.cbSala.BackColor = System.Drawing.Color.White;
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(16, 49);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(176, 24);
            this.cbSala.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Início:";
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Location = new System.Drawing.Point(304, 115);
            this.dtpFim.MinDate = new System.DateTime(2017, 6, 3, 0, 0, 0, 0);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFim.Size = new System.Drawing.Size(273, 22);
            this.dtpFim.TabIndex = 15;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuário:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.White;
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(380, 49);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(197, 24);
            this.cbUsuario.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Casa:";
            // 
            // cbCasa
            // 
            this.cbCasa.BackColor = System.Drawing.Color.White;
            this.cbCasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCasa.FormattingEnabled = true;
            this.cbCasa.Location = new System.Drawing.Point(217, 49);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(122, 24);
            this.cbCasa.TabIndex = 11;
            this.cbCasa.SelectionChangeCommitted += new System.EventHandler(this.cbCasa_SelectionChangeCommitted);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(12, 115);
            this.dtpInicio.MinDate = new System.DateTime(2017, 6, 3, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpInicio.Size = new System.Drawing.Size(273, 22);
            this.dtpInicio.TabIndex = 14;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(17, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 2);
            this.panel2.TabIndex = 13;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(32, 180);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(715, 295);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelBotoes.ResumeLayout(false);
            this.panelCanto.ResumeLayout(false);
            this.panelCanto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel panelCanto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem alterarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnCasas;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnDisciplinas;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnModalidades;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCasa;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Button btnAtivarFiltros;
    }
}