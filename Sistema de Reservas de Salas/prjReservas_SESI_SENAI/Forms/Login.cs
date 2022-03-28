using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjDto;
using prjBll;

namespace prjReservas_SESI_SENAI.Forms
{
    public partial class Login : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        List<DtoUsuario> Adms = new List<DtoUsuario>();

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public Login()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTORS

        #region DESIGN
        private void lblEsqueceuSenha_MouseEnter(object sender, EventArgs e)
        {
            lblEsqueceuSenha.Font = new Font(lblEsqueceuSenha.Font, FontStyle.Underline);
        }

        private void lblEsqueceuSenha_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueceuSenha.Font = new Font(lblEsqueceuSenha.Font, FontStyle.Regular);
        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "Senha")
            {
                tb.Text = "";
                tb.PasswordChar = '*';
                // tb.ForeColor = Color.Black;
            }

            if (tb.Text == "Login")
            {
                tb.Text = "";
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "" && tb.PasswordChar == '*')
            {
                tb.Text = "Senha";
                tb.PasswordChar = '\0';
                // tb.ForeColor = Color.LigthGray;
            }

            else if (tb.Text == "" && tb.PasswordChar == '\0')
            {
                txtLogin.Text = "Login";
            }
        }

        #endregion DESGIN

        #region METHODS
        /////////////////////////////////////////////////////////////////////////////////
        private void lblFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSenha.GotFocus += new EventHandler(this.TextGotFocus);
            txtSenha.LostFocus += new EventHandler(this.TextLostFocus);

            txtLogin.GotFocus += new EventHandler(this.TextGotFocus);
            txtLogin.LostFocus += new EventHandler(this.TextLostFocus);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DtoUsuario usuario = new DtoUsuario(null, null, txtLogin.Text, txtSenha.Text, null, null, null, null);

            if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty || txtLogin.Text == "Login" || txtSenha.Text == "Senha")
            {
                MessageBox.Show("Preencha os campos.", "Não inserção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (objBll.ConsultarUsuario(usuario) == true)
                    {
                        DtoUsuario carregarU = objBll.SelectUsuarioLogin(usuario);

                        if (carregarU.Status == false)
                        {
                            MessageBox.Show("Esse login foi desativado do sistema,\npara mais informações procure a coordenação\nda casa a qual você pertence.", "Usuário desativado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            Principal principal = new Principal(carregarU);
                            this.Hide();
                            principal.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou senha incorreto(s).", "Preenchimento Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtSenha.Text = String.Empty;
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void lblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auto_Cadastro_Usuario auto = new Auto_Cadastro_Usuario();
            this.Hide();
            auto.ShowDialog();
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            Adms = objBll.SelectUsuario(true);
            string lista = null;

            for (int i = 0; i < Adms.Count; i++)
            {
                if (Adms[i].Status == true)
                {
                    lista += Adms[i].NomeUsuario + " - " + Adms[i].NomeCasa + "\n";
                }              
            }

            MessageBox.Show("Para recuperar sua conta, peça para alguma\ndessas pessoas resetar sua senha:\n\n"+ lista, "Esqueceu sua senha?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "Senha")
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
        }

        #endregion METHODS   
    }
}
