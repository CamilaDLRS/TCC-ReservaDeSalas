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
    public partial class Salas : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        DtoUsuario usuario = new DtoUsuario();
        DtoSala sala = new DtoSala();
        Boolean status = true;
        Enumeradores enumerador;

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public Salas(DtoUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (usuario.IdentificacaoAdministrador == true)
            {
                this.Size = new Size(565, 524);
                this.MaximumSize = new Size(565, 524);
                this.MinimumSize = new Size(565, 524);
            }
            else
            {
                this.Size = new Size(565, 314);
                this.MaximumSize = new Size(565, 314);
                this.MinimumSize = new Size(565, 314);

                btnAdicionar_Salvar.Visible = false;
                btnAlterar_Cancelar.Visible = false;
                btnDesativar.Visible = false;
            }          
        }

        #endregion CONSTRUCTORS

        #region METHODS

        private void Salas_Load(object sender, EventArgs e)
        {
            dgvSalas.DataSource = objBll.SelectSala(status);
            dgvSalas.Columns[0].Visible = false;
            dgvSalas.Columns[1].HeaderText = "Nome";
            dgvSalas.Columns[1].Width = 205;
            dgvSalas.Columns[2].HeaderText = "Informações";
            dgvSalas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSalas.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvSalas.Columns[2].Width = 267;
            dgvSalas.Columns[3].Visible = false;
        }

        private void btnAdicionar_Salvar_Click(object sender, EventArgs e)
        {
            bool passe = false;

            if (btnAdicionar_Salvar.Text == "Adicionar")
            {
                enumerador = Enumeradores.SalaInsert;
                btnAdicionar_Salvar.Text = "Salvar";
                btnAlterar_Cancelar.Text = "Cancelar";

                txtInformacoes.Enabled = true;
                txtNome.Enabled = true;
                btnDesativar.Enabled = false;
            }
            else
            {
                try
                {
                    if (txtInformacoes.Text == String.Empty)
                        txtInformacoes.Text = "NA";

                    if (enumerador == Enumeradores.SalaInsert)
                    {
                        try
                        {
                            sala = new DtoSala(null, txtNome.Text, true, txtInformacoes.Text);
                            objBll.InsertSala(sala);

                            MessageBox.Show("Sala salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSalas.DataSource = objBll.SelectSala(status);
                            passe = true;
                            txtInformacoes.Enabled = false;
                            txtNome.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                    }
                    else if (enumerador == Enumeradores.SalaEditar)
                    {
                        try
                        {
                            sala = new DtoSala(Convert.ToInt32(dgvSalas.SelectedRows[0].Cells["IdSala"].Value),
                       txtNome.Text, true, txtInformacoes.Text);

                            objBll.EditSala(sala);

                            MessageBox.Show("Sala salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSalas.DataSource = objBll.SelectSala(status);
                            passe = true;
                            btnDesativar.Enabled = true;
                            txtInformacoes.Enabled = false;
                            txtNome.Enabled = false;
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                    }
                    if (passe == true)
                    {
                        dgvSalas.DataSource = objBll.SelectSala(status);
                        dgvSalas.Enabled = true;
                        btnAdicionar_Salvar.Text = "Adicionar";
                        btnAlterar_Cancelar.Text = "Alterar";
                        txtNome.Text = String.Empty;
                        txtInformacoes.Text = String.Empty;
                        btnDesativar.Enabled = true;
                    }                               
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnAlterar_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterar_Cancelar.Text == "Cancelar")
                {
                    dgvSalas.Enabled = true;
                    txtNome.Text = String.Empty;
                    txtInformacoes.Text = String.Empty;
                    btnAlterar_Cancelar.Text = "Alterar";
                    btnAdicionar_Salvar.Text = "Adicionar";                    

                    txtInformacoes.Enabled = false;
                    txtNome.Enabled = false;
                    btnDesativar.Enabled = true;
                }
                else
                {
                    btnDesativar.Enabled = false;
                    txtNome.Text = dgvSalas.SelectedRows[0].Cells["NomeSala"].Value.ToString();
                    txtInformacoes.Text = dgvSalas.SelectedRows[0].Cells["Informacoes"].Value.ToString();

                    enumerador = Enumeradores.SalaEditar;

                    dgvSalas.Enabled = false;
                    btnAdicionar_Salvar.Text = "Salvar";
                    btnAlterar_Cancelar.Text = "Cancelar";

                    txtInformacoes.Enabled = true;
                    txtNome.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há existem salas para serem alteradas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = dgvSalas.SelectedRows[0].Cells["NomeSala"].Value.ToString();

                if (MessageBox.Show("Tem certeza que deseja excluir a sala " + nome + "?\n (Você ainda poderá ver as reservas dela)", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        sala.IdSala = Convert.ToInt32(dgvSalas.SelectedRows[0].Cells["IdSala"].Value);
                        sala.Status = false;
                        objBll.TrocaStatusSala(sala);

                        MessageBox.Show("Sala excluída com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalas.DataSource = objBll.SelectSala(status);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não existem salas para serem alteradas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion METHODS
    }
}
