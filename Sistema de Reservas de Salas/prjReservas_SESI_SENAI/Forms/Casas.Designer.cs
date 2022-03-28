namespace prjReservas_SESI_SENAI.Forms
{
    partial class Casas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casas));
            this.dgvCasa = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionarSalvar = new System.Windows.Forms.Button();
            this.btnAlterarCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCasa
            // 
            this.dgvCasa.AllowUserToAddRows = false;
            this.dgvCasa.AllowUserToDeleteRows = false;
            this.dgvCasa.AllowUserToResizeColumns = false;
            this.dgvCasa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCasa.Location = new System.Drawing.Point(12, 11);
            this.dgvCasa.MultiSelect = false;
            this.dgvCasa.Name = "dgvCasa";
            this.dgvCasa.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCasa.Size = new System.Drawing.Size(391, 164);
            this.dgvCasa.TabIndex = 30;
            this.dgvCasa.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(26, 255);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(29, 276);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 27);
            this.txtNome.TabIndex = 1;
            // 
            // btnAdicionarSalvar
            // 
            this.btnAdicionarSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdicionarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarSalvar.FlatAppearance.BorderSize = 0;
            this.btnAdicionarSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdicionarSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAdicionarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarSalvar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarSalvar.Location = new System.Drawing.Point(17, 187);
            this.btnAdicionarSalvar.Name = "btnAdicionarSalvar";
            this.btnAdicionarSalvar.Size = new System.Drawing.Size(109, 39);
            this.btnAdicionarSalvar.TabIndex = 2;
            this.btnAdicionarSalvar.Text = "Adicionar";
            this.btnAdicionarSalvar.UseVisualStyleBackColor = false;
            this.btnAdicionarSalvar.Click += new System.EventHandler(this.btnAdicionarSalvar_Click);
            // 
            // btnAlterarCancelar
            // 
            this.btnAlterarCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAlterarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterarCancelar.FlatAppearance.BorderSize = 0;
            this.btnAlterarCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlterarCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAlterarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCancelar.ForeColor = System.Drawing.Color.White;
            this.btnAlterarCancelar.Location = new System.Drawing.Point(152, 187);
            this.btnAlterarCancelar.Name = "btnAlterarCancelar";
            this.btnAlterarCancelar.Size = new System.Drawing.Size(109, 39);
            this.btnAlterarCancelar.TabIndex = 3;
            this.btnAlterarCancelar.Text = "Alterar";
            this.btnAlterarCancelar.UseVisualStyleBackColor = false;
            this.btnAlterarCancelar.Click += new System.EventHandler(this.btnAlterarCancelar_Click);
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
            this.btnVoltar.Location = new System.Drawing.Point(287, 187);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 39);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjReservas_SESI_SENAI.Properties.Resources.carregando_casa;
            this.pictureBox1.Location = new System.Drawing.Point(280, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // Casas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterarCancelar);
            this.Controls.Add(this.btnAdicionarSalvar);
            this.Controls.Add(this.dgvCasa);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(436, 370);
            this.MinimumSize = new System.Drawing.Size(436, 370);
            this.Name = "Casas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Casas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCasa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarSalvar;
        private System.Windows.Forms.Button btnAlterarCancelar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}