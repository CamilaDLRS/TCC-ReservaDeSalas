namespace prjReservas_SESI_SENAI.Forms
{
    partial class Reservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservar));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dudSaida = new System.Windows.Forms.DomainUpDown();
            this.dudEntrada = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(21, 181);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 5;
            // 
            // dudSaida
            // 
            this.dudSaida.BackColor = System.Drawing.Color.White;
            this.dudSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudSaida.Items.Add("7:15");
            this.dudSaida.Items.Add("8:05");
            this.dudSaida.Items.Add("9:45");
            this.dudSaida.Items.Add("10:00");
            this.dudSaida.Items.Add("10:50");
            this.dudSaida.Items.Add("11:40");
            this.dudSaida.Items.Add("13:00");
            this.dudSaida.Items.Add("13:50");
            this.dudSaida.Items.Add("14:40");
            this.dudSaida.Items.Add("15:30");
            this.dudSaida.Items.Add("15:45");
            this.dudSaida.Items.Add("16:35");
            this.dudSaida.Items.Add("17:25");
            this.dudSaida.Items.Add("18:30");
            this.dudSaida.Items.Add("22:40");
            this.dudSaida.Location = new System.Drawing.Point(299, 310);
            this.dudSaida.Name = "dudSaida";
            this.dudSaida.ReadOnly = true;
            this.dudSaida.Size = new System.Drawing.Size(227, 24);
            this.dudSaida.TabIndex = 7;
            // 
            // dudEntrada
            // 
            this.dudEntrada.BackColor = System.Drawing.Color.White;
            this.dudEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudEntrada.Items.Add("7:15");
            this.dudEntrada.Items.Add("8:05");
            this.dudEntrada.Items.Add("9:45");
            this.dudEntrada.Items.Add("10:00");
            this.dudEntrada.Items.Add("10:50");
            this.dudEntrada.Items.Add("11:40");
            this.dudEntrada.Items.Add("13:00");
            this.dudEntrada.Items.Add("13:50");
            this.dudEntrada.Items.Add("14:40");
            this.dudEntrada.Items.Add("15:30");
            this.dudEntrada.Items.Add("15:45");
            this.dudEntrada.Items.Add("16:35");
            this.dudEntrada.Items.Add("17:25");
            this.dudEntrada.Items.Add("18:30");
            this.dudEntrada.Location = new System.Drawing.Point(299, 213);
            this.dudEntrada.Name = "dudEntrada";
            this.dudEntrada.ReadOnly = true;
            this.dudEntrada.Size = new System.Drawing.Size(227, 24);
            this.dudEntrada.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Saída:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Sala:";
            // 
            // cbSala
            // 
            this.cbSala.BackColor = System.Drawing.Color.White;
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(299, 124);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(227, 26);
            this.cbSala.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(21, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(299, 380);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(227, 38);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(17, 101);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(80, 20);
            this.lbl3.TabIndex = 101;
            this.lbl3.Text = "Disciplina:";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.BackColor = System.Drawing.Color.White;
            this.cbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(21, 124);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(227, 26);
            this.cbDisciplina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Curso:";
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.White;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(299, 52);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(227, 26);
            this.cbCurso.TabIndex = 2;
            this.cbCurso.SelectionChangeCommitted += new System.EventHandler(this.cbCurso_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Modalidade:";
            // 
            // cbModalidade
            // 
            this.cbModalidade.BackColor = System.Drawing.Color.White;
            this.cbModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(21, 52);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(227, 26);
            this.cbModalidade.TabIndex = 1;
            this.cbModalidade.SelectionChangeCommitted += new System.EventHandler(this.cbModalidade_SelectionChangeCommitted);
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 431);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dudSaida);
            this.Controls.Add(this.dudEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbModalidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 469);
            this.MinimumSize = new System.Drawing.Size(565, 469);
            this.Name = "Reservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reservar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DomainUpDown dudSaida;
        private System.Windows.Forms.DomainUpDown dudEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbModalidade;
    }
}