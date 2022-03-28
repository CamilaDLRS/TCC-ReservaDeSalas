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
    public partial class Auto_Alteração_Usuario : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        DtoUsuario usuario = new DtoUsuario();

        #endregion PROPERTIES

        #region METHODS
        public Auto_Alteração_Usuario(DtoUsuario usuario)
        {
            InitializeComponent();

            txtNome.Text = usuario.NomeUsuario;
            List<DtoCasa> casas = objBll.SelectCasa();
            cbCasa.DataSource = casas;
            cbCasa.ValueMember = "IdCasa";
            cbCasa.DisplayMember = "NomeCasa";
            cbCasa.SelectedValue = usuario.IdCasa;

            this.usuario = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Preencha os campos Nome e Senha Atual.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txtSenha.Text == usuario.Senha)
            {
                try
                {
                    if (txtNovaSenha.Text == String.Empty)
                    {
                        txtNovaSenha.Text = usuario.Senha;
                    }

                    DtoUsuario usuarioEdit = new DtoUsuario(usuario.IdUsuario, txtNome.Text,usuario.Login, txtNovaSenha.Text, usuario.IdentificacaoAdministrador, int.Parse(cbCasa.SelectedValue.ToString()), cbCasa.Text, usuario.Status);
                    objBll.EditUsuario(usuarioEdit);

                    MessageBox.Show("Conta salva com sucesso!", "", MessageBoxButtons.OK,MessageBoxIcon.Information);                   
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Senha atual incorreta.", "Preenchimento incorreto",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Text = String.Empty;
            }
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

        private void btnMostarNova_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.PasswordChar == '*')
            {
                txtNovaSenha.PasswordChar = '\0';
            }
            else
            {
                txtNovaSenha.PasswordChar = '*';
            }
        }
    }
    #endregion METHODS
}
