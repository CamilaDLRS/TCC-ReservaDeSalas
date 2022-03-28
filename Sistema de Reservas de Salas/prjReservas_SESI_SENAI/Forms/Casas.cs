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
    public partial class Casas : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();

        Enumeradores enumerador;

        DtoCasa p_casa = new DtoCasa();

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public Casas()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORS
        
        #region METHODS
        private void Casas_Load(object sender, EventArgs e)
        {
            dgvCasa.DataSource = objBll.SelectCasa();

            dgvCasa.Columns[0].Visible = false;
            dgvCasa.Columns[1].HeaderText = "Nome";
            dgvCasa.Columns[1].Width =348;
            dgvCasa.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            txtNome.Enabled = false;
        }

        private void FiscalizarAcao()
        {
            try
            {
                if (enumerador == Enumeradores.CasaInsert)
                {
                    p_casa = new DtoCasa(Convert.ToInt32(dgvCasa.SelectedRows[0].Cells["IdCasa"].Value),
                            txtNome.Text);

                    if (txtNome.Text != String.Empty)
                    {
                        if (MessageBox.Show("A Casa é muito impotante para a instituição e não há como\n excluir após adiciona-la.\n" +
                        "Você tem certeza que deseja inserir a casa " + txtNome.Text + "?\n", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            objBll.InsertCasa(p_casa);
                            MessageBox.Show("Salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo Nome é obrigatório.", "Preenchimento incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                dgvCasa.DataSource = objBll.SelectCasa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = "";
                dgvCasa.Enabled = true;
                txtNome.Enabled = false;
                btnAdicionarSalvar.Enabled = true;
                btnAlterarCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAdicionarSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdicionarSalvar.Text == "Adicionar")
                {
                    enumerador = Enumeradores.CasaInsert;

                    dgvCasa.Enabled = false;
                    txtNome.Enabled = true;
                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                }

                else if (btnAdicionarSalvar.Text == "Salvar")
                {
                    

                    if (enumerador == Enumeradores.CasaInsert)
                    {                        
                        FiscalizarAcao();
                    }

                    if (enumerador == Enumeradores.DisciplinaEditar)
                    {
                        p_casa = new DtoCasa(Convert.ToInt32(dgvCasa.SelectedRows[0].Cells["IdCasa"].Value), txtNome.Text);
                        objBll.EditCasa(p_casa);
                        MessageBox.Show("Salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvCasa.DataSource = objBll.SelectCasa();

                    dgvCasa.Enabled = true;
                    txtNome.Enabled = false;

                    btnAdicionarSalvar.Text = "Adicionar";
                    btnAlterarCancelar.Text = "Alterar";

                    txtNome.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterarCancelar.Text == "Alterar")
                {
                    txtNome.Text = dgvCasa.SelectedRows[0].Cells["NomeCasa"].Value.ToString();

                    enumerador = Enumeradores.DisciplinaEditar;

                    dgvCasa.Enabled = false;
                    txtNome.Enabled = true;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";
                }
                else if (btnAlterarCancelar.Text == "Cancelar")
                {
                    txtNome.Text = "";
                    dgvCasa.Enabled = true;
                    txtNome.Enabled = false;                  
                    btnAdicionarSalvar.Text = "Adicionar";
                    btnAlterarCancelar.Text = "Alterar";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há registros para serem alterados.\nInsira um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
