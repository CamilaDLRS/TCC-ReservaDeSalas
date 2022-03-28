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
    public partial class Usuarios : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        DtoUsuario usuario = new DtoUsuario();
        DtoUsuario usuarioEdit = new DtoUsuario();

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public Usuarios(DtoUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            usuario.Status = true;
        }
        #endregion CONSTRUCTORS

        #region METHODS

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
            //   dgvUsuario_SelectionChanged(sender, e);

            dgvUsuario.Columns[0].Visible = false;
            dgvUsuario.Columns[1].HeaderText = "Nome";
            dgvUsuario.Columns[1].Width = 168;
            dgvUsuario.Columns[3].Visible = false;
            dgvUsuario.Columns[4].HeaderText = "Administrador";
            dgvUsuario.Columns[4].Width = 105;
            dgvUsuario.Columns[5].Visible = false;
            dgvUsuario.Columns[6].HeaderText = "Casa";
            dgvUsuario.Columns[7].Visible = false;
        }

        private void btnAtivadoDesativado_Click(object sender, EventArgs e)
        {
            if (btnAtivadoDesativado.Text == "Ver usuários ativos")
            {
                btnAtivar_Desativar.Text = "Desativar";

                btnAtivar_Desativar.ForeColor = Color.Red;
                btnAtivar_Desativar.FlatAppearance.BorderColor = Color.Red;
                btnAtivar_Desativar.FlatAppearance.MouseOverBackColor = Color.LightSalmon;

                btnAdministrador.Visible = true;
                btnResetarSenha.Visible = true;
                usuario.Status = true;
                dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
                btnAtivadoDesativado.Text = "Ver usuários desativados";
            }

            else if (btnAtivadoDesativado.Text == "Ver usuários desativados")
            {
                btnAtivar_Desativar.Text = "Ativar";

                btnAtivar_Desativar.ForeColor = Color.MediumSeaGreen;
                btnAtivar_Desativar.FlatAppearance.BorderColor = Color.MediumSeaGreen;
                btnAtivar_Desativar.FlatAppearance.MouseOverBackColor = Color.PaleGreen;

                btnAdministrador.Visible = false;
                btnResetarSenha.Visible = false;
                usuario.Status = false;
                dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
                btnAtivadoDesativado.Text = "Ver usuários ativos";
            }
        }

        private void btnAtivar_Desativar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsuario.Enabled = false;

                if (btnAtivar_Desativar.Text == "Ativar")
                {
                    usuarioEdit.Status = true;
                    TrocadeStatus();
                    usuario.Status = false;
                    dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
                }

                else
                {
                    if (usuario.IdUsuario == int.Parse(dgvUsuario.SelectedRows[0].Cells["IdUsuario"].Value.ToString()))
                    {
                        MessageBox.Show("Você não pode se desativar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvUsuario.Enabled = true;
                    }

                    else
                    {
                        usuarioEdit.Status = false;
                        TrocadeStatus();
                        usuario.Status = true;
                        dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    if (btnAtivar_Desativar.Text == "Ativar")
                    {
                        MessageBox.Show("Não há usuários para ativar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Não há usuários para desativar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                   ///
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TrocadeStatus()
        {
            usuarioEdit.IdUsuario = int.Parse(dgvUsuario.SelectedRows[0].Cells["IdUsuario"].Value.ToString());

            if (MessageBox.Show("Tem certeza que deseja trocar o status desse usuário?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    objBll.TrocaStatusUsuario(usuarioEdit);

                    MessageBox.Show("Status alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuario.Enabled = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            else
            {
                dgvUsuario.Enabled = true;
            }
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(dgvUsuario.CurrentRow.Cells["IdentificacaoAdministrador"].Value.ToString()) == false)
                {
                    btnAdministrador.Text = "Tornar administrador";
                }
                else
                {
                    btnAdministrador.Text = "Tornar usuário comum";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                    ///
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdministrador.Text == "Tornar administrador")
                {
                    usuarioEdit.IdentificacaoAdministrador = true;
                    ComumXAdm("administrador");
                }
                else
                {
                    usuarioEdit.IdentificacaoAdministrador = false;
                    ComumXAdm("comum");
                }
                dgvUsuario.DataSource = objBll.SelectUsuario(usuario);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                   ////
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void ComumXAdm(string texto)
        {
            if (usuario.IdUsuario == int.Parse(dgvUsuario.SelectedRows[0].Cells["IdUsuario"].Value.ToString()))
            {
                MessageBox.Show("Você não pode mudar sua permissão.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuario.Enabled = true;
            }

            else if (MessageBox.Show("Tem certeza que deseja tornar o(a)" + dgvUsuario.SelectedRows[0].Cells["NomeUsuario"].Value + " um usuário" + texto + "?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    usuarioEdit.IdUsuario = int.Parse(dgvUsuario.SelectedRows[0].Cells["IdUsuario"].Value.ToString());

                    objBll.EditUsuarioAdm(usuarioEdit);

                    MessageBox.Show("Usuário alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuario.Enabled = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            else
            {
                dgvUsuario.Enabled = true;
            }
        }

        private void btnResetarSenha_Click(object sender, EventArgs e)
        {
            string nome = dgvUsuario.SelectedRows[0].Cells["NomeUsuario"].Value.ToString();

            if (MessageBox.Show("Tem certeza que deseja resetar a senha do(a)\n" + nome + " para 123456 ?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    usuarioEdit.IdUsuario = int.Parse(dgvUsuario.SelectedRows[0].Cells["IdUsuario"].Value.ToString());
                    usuarioEdit.Senha = "123456";

                    objBll.EditUsuarioResetarSenha(usuarioEdit);

                    MessageBox.Show("Senha resetada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        #endregion METHODS
    }
}
