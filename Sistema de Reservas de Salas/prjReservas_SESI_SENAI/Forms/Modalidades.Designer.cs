namespace prjReservas_SESI_SENAI.Forms
{
    partial class Modalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modalidades));
            this.btnAlterarCancelar = new System.Windows.Forms.Button();
            this.btnAdicionarSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCasa = new System.Windows.Forms.ComboBox();
            this.dgvModalidade = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAlterarCancelar.Location = new System.Drawing.Point(152, 226);
            this.btnAlterarCancelar.Name = "btnAlterarCancelar";
            this.btnAlterarCancelar.Size = new System.Drawing.Size(109, 38);
            this.btnAlterarCancelar.TabIndex = 4;
            this.btnAlterarCancelar.Text = "Alterar";
            this.btnAlterarCancelar.UseVisualStyleBackColor = false;
            this.btnAlterarCancelar.Click += new System.EventHandler(this.btnAlterarCancelar_Click);
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
            this.btnAdicionarSalvar.Location = new System.Drawing.Point(17, 226);
            this.btnAdicionarSalvar.Name = "btnAdicionarSalvar";
            this.btnAdicionarSalvar.Size = new System.Drawing.Size(109, 38);
            this.btnAdicionarSalvar.TabIndex = 3;
            this.btnAdicionarSalvar.Text = "Adicionar";
            this.btnAdicionarSalvar.UseVisualStyleBackColor = false;
            this.btnAdicionarSalvar.Click += new System.EventHandler(this.btnAdicionarSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(26, 356);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 20);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "Modalidade:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(29, 379);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 27);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Casa:";
            // 
            // cbCasa
            // 
            this.cbCasa.BackColor = System.Drawing.Color.White;
            this.cbCasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCasa.FormattingEnabled = true;
            this.cbCasa.Location = new System.Drawing.Point(29, 315);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(227, 26);
            this.cbCasa.TabIndex = 1;
            // 
            // dgvModalidade
            // 
            this.dgvModalidade.AllowUserToAddRows = false;
            this.dgvModalidade.AllowUserToDeleteRows = false;
            this.dgvModalidade.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModalidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModalidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModalidade.Location = new System.Drawing.Point(17, 12);
            this.dgvModalidade.MultiSelect = false;
            this.dgvModalidade.Name = "dgvModalidade";
            this.dgvModalidade.ReadOnly = true;
            this.dgvModalidade.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvModalidade.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidade.Size = new System.Drawing.Size(515, 202);
            this.dgvModalidade.TabIndex = 95;
            this.dgvModalidade.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(287, 226);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 38);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnVoltar.Location = new System.Drawing.Point(422, 226);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 38);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjReservas_SESI_SENAI.Properties.Resources.modalidadeazul;
            this.pictureBox1.Location = new System.Drawing.Point(348, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // Modalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvModalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCasa);
            this.Controls.Add(this.btnAlterarCancelar);
            this.Controls.Add(this.btnAdicionarSalvar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 469);
            this.MinimumSize = new System.Drawing.Size(565, 469);
            this.Name = "Modalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Modalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarCancelar;
        private System.Windows.Forms.Button btnAdicionarSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCasa;
        private System.Windows.Forms.DataGridView dgvModalidade;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}