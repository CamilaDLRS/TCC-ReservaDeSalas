namespace prjReservas_SESI_SENAI.Forms
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.label2 = new System.Windows.Forms.Label();
            this.cbCasa = new System.Windows.Forms.ComboBox();
            this.btnAlterarCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 54;
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
            this.cbCasa.Size = new System.Drawing.Size(230, 26);
            this.cbCasa.TabIndex = 1;
            this.cbCasa.SelectionChangeCommitted += new System.EventHandler(this.cbCasa_SelectionChangeCommitted);
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
            this.btnAlterarCancelar.TabIndex = 5;
            this.btnAlterarCancelar.Text = "Alterar";
            this.btnAlterarCancelar.UseVisualStyleBackColor = false;
            this.btnAlterarCancelar.Click += new System.EventHandler(this.btnAlterarCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(29, 443);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 27);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Modalidade:";
            // 
            // cbModalidade
            // 
            this.cbModalidade.BackColor = System.Drawing.Color.White;
            this.cbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(29, 379);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(230, 26);
            this.cbModalidade.TabIndex = 2;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursos.Location = new System.Drawing.Point(17, 12);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(515, 202);
            this.dgvCursos.TabIndex = 94;
            this.dgvCursos.TabStop = false;
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
            this.btnAdicionarSalvar.TabIndex = 4;
            this.btnAdicionarSalvar.Text = "Adicionar";
            this.btnAdicionarSalvar.UseVisualStyleBackColor = false;
            this.btnAdicionarSalvar.Click += new System.EventHandler(this.btnAdicionarSalvar_Click);
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
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 420);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 114;
            this.lblNome.Text = "Curso:";
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
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::prjReservas_SESI_SENAI.Properties.Resources.sign_question_icon;
            this.pictureBox2.Location = new System.Drawing.Point(265, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Caso não haja um curso nessa modalidade escreva NA.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjReservas_SESI_SENAI.Properties.Resources.cursos_profissionais_;
            this.pictureBox1.Location = new System.Drawing.Point(338, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 485);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionarSalvar);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCasa);
            this.Controls.Add(this.btnAlterarCancelar);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 524);
            this.MinimumSize = new System.Drawing.Size(565, 524);
            this.Name = "Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCasa;
        private System.Windows.Forms.Button btnAlterarCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAdicionarSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}