using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjBll;
using prjDto;

namespace prjReservas_SESI_SENAI.Forms
{
    public partial class Auto_Cadastro_Usuario : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public Auto_Cadastro_Usuario()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTORS

        #region METHODS

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void Auto_Cadastro_Usuario_Load(object sender, EventArgs e)
        {
            //Adiciona dados na combobox Casa
            List<DtoCasa> casas = objBll.SelectCasa();
            cbCasa.DataSource = casas; /* Atribuo o DataSource a minha lista */
            cbCasa.ValueMember = "IdCasa"; /* O valor do combox eu pego do "Id" da minha classe Casa */
            cbCasa.DisplayMember = "NomeCasa"; /* O valor que o usuário irá ver no Combox */
            cbCasa.SelectedIndex = 0; /*Seleciona pelo id qual Casa aparecer antes*/
            //Adiciona dados na combobox Casa
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                DtoUsuario usuario = new DtoUsuario(null, txtNome.Text, txtLogin.Text, txtSenha.Text, false, int.Parse(cbCasa.SelectedValue.ToString()), null, null);
                objBll.InsertUsuario(usuario);

                DtoUsuario carregarU = objBll.SelectUsuarioLogin(usuario);

                MessageBox.Show("Cadastro realizado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Principal principal = new Principal(carregarU);
                this.Hide();
                principal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Auto_Cadastro_Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        #endregion METHODS

    }
}
