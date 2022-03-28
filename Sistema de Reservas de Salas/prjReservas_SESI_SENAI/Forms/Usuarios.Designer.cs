namespace prjReservas_SESI_SENAI.Forms
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnResetarSenha = new System.Windows.Forms.Button();
            this.btnAtivadoDesativado = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnAtivar_Desativar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.Location = new System.Drawing.Point(17, 12);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(515, 202);
            this.dgvUsuario.TabIndex = 93;
            this.dgvUsuario.TabStop = false;
            this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
            // 
            // btnResetarSenha
            // 
            this.btnResetarSenha.BackColor = System.Drawing.Color.SteelBlue;
            this.btnResetarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetarSenha.FlatAppearance.BorderSize = 0;
            this.btnResetarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResetarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnResetarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetarSenha.ForeColor = System.Drawing.Color.White;
            this.btnResetarSenha.Location = new System.Drawing.Point(29, 229);
            this.btnResetarSenha.Name = "btnResetarSenha";
            this.btnResetarSenha.Size = new System.Drawing.Size(139, 38);
            this.btnResetarSenha.TabIndex = 0;
            this.btnResetarSenha.Text = "Resetar senha";
            this.btnResetarSenha.UseVisualStyleBackColor = false;
            this.btnResetarSenha.Click += new System.EventHandler(this.btnResetarSenha_Click);
            // 
            // btnAtivadoDesativado
            // 
            this.btnAtivadoDesativado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtivadoDesativado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivadoDesativado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtivadoDesativado.FlatAppearance.BorderSize = 0;
            this.btnAtivadoDesativado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAtivadoDesativado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAtivadoDesativado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivadoDesativado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivadoDesativado.ForeColor = System.Drawing.Color.White;
            this.btnAtivadoDesativado.Location = new System.Drawing.Point(322, 295);
            this.btnAtivadoDesativado.Name = "btnAtivadoDesativado";
            this.btnAtivadoDesativado.Size = new System.Drawing.Size(210, 38);
            this.btnAtivadoDesativado.TabIndex = 3;
            this.btnAtivadoDesativado.Text = "Ver usuários desativados";
            this.btnAtivadoDesativado.UseVisualStyleBackColor = false;
            this.btnAtivadoDesativado.Click += new System.EventHandler(this.btnAtivadoDesativado_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(379, 229);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(139, 38);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(90, 295);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(210, 38);
            this.btnAdministrador.TabIndex = 2;
            this.btnAdministrador.Text = "Tornar administrador";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnAtivar_Desativar
            // 
            this.btnAtivar_Desativar.BackColor = System.Drawing.Color.White;
            this.btnAtivar_Desativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivar_Desativar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAtivar_Desativar.FlatAppearance.BorderSize = 2;
            this.btnAtivar_Desativar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtivar_Desativar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnAtivar_Desativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivar_Desativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivar_Desativar.ForeColor = System.Drawing.Color.Red;
            this.btnAtivar_Desativar.Location = new System.Drawing.Point(204, 229);
            this.btnAtivar_Desativar.Name = "btnAtivar_Desativar";
            this.btnAtivar_Desativar.Size = new System.Drawing.Size(139, 38);
            this.btnAtivar_Desativar.TabIndex = 1;
            this.btnAtivar_Desativar.Text = "Desativar";
            this.btnAtivar_Desativar.UseVisualStyleBackColor = false;
            this.btnAtivar_Desativar.Click += new System.EventHandler(this.btnAtivar_Desativar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjReservas_SESI_SENAI.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(10, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 346);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtivar_Desativar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtivadoDesativado);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnResetarSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 384);
            this.MinimumSize = new System.Drawing.Size(565, 384);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnResetarSenha;
        private System.Windows.Forms.Button btnAtivadoDesativado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnAtivar_Desativar;
    }
}