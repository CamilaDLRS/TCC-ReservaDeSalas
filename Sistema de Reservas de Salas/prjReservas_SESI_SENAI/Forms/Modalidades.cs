using prjBll;
using prjDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjReservas_SESI_SENAI.Forms
{
    public partial class Modalidades : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        Enumeradores enumerador;
        DtoModalidade p_modalidade = new DtoModalidade();
        DtoCasa p_casa = new DtoCasa();

        #endregion PROPERTIES

        #region CONSTRUCTOR
        public Modalidades()
        {
            InitializeComponent();

            this.objBll = new Bll();
        }

        #endregion CONSTRUCTOR

        #region METHODS

        private void Modalidades_Load(object sender, EventArgs e)
        {
            try
            {
                //Adiciona dados na combobox Casa
                List<DtoCasa> casas = objBll.SelectCasa();
                cbCasa.DataSource = casas; /* Atribuo o DataSource a minha lista */
                cbCasa.ValueMember = "IdCasa"; /* O valor do combox eu pego do "Id" da minha classe Casa */
                cbCasa.DisplayMember = "NomeCasa"; /* O valor que o usuário irá ver no Combox */
                cbCasa.SelectedIndex = 0; /*Seleciona pelo id qual Casa aparecer antes*/
                //Adiciona dados na combobox Casa

                dgvModalidade.DataSource = objBll.SelectModalidade();

                dgvModalidade.Columns[0].Visible = false; // Define a 1° Coluna(IdDisciplina) como não visível
                dgvModalidade.Columns[1].HeaderText = "Modalidade"; //Define o nome da 2° Coluna(NomeDisciplian) como "Disciplina"
                dgvModalidade.Columns[1].Width = 238;

                dgvModalidade.Columns[2].Visible = false;
                dgvModalidade.Columns[3].HeaderText = "Casa"; //Define o nome da 2° Coluna(NomeDisciplian) como "Disciplina"
                dgvModalidade.Columns[3].Width = 235;

                Campos(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdicionarSalvar.Text == "Adicionar")
                {
                    enumerador = Enumeradores.ModalidadeInsert;

                    dgvModalidade.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                    Campos(true);
                }

                else if (btnAdicionarSalvar.Text == "Salvar")
                {
                    if (enumerador == Enumeradores.ModalidadeInsert)
                    {
                        FiscalizarAcao();
                    }
                    else if (enumerador == Enumeradores.ModalidadeEditar)
                    {
                        p_modalidade = new DtoModalidade(
                       Convert.ToInt32(dgvModalidade.SelectedRows[0].Cells["IdModalidade"].Value),
                       txtNome.Text, int.Parse(cbCasa.SelectedValue.ToString()), cbCasa.SelectedItem.ToString());

                        objBll.EditModalidade(p_modalidade);
                    }

                    dgvModalidade.DataSource = objBll.SelectModalidade();
                    cbCasa.SelectedIndex = 0;

                    dgvModalidade.Enabled = true;
                    btnExcluir.Enabled = true;

                    btnAdicionarSalvar.Text = "Adicionar";
                    btnAlterarCancelar.Text = "Alterar";

                    txtNome.Text = "";

                    Campos(false);

                    MessageBox.Show("Salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtNome.Text = dgvModalidade.SelectedRows[0].Cells["NomeModalidade"].Value.ToString();
                    cbCasa.Text = dgvModalidade.SelectedRows[0].Cells["NomeCasa"].Value.ToString();

                    enumerador = Enumeradores.ModalidadeEditar;

                    dgvModalidade.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                    Campos(true);
                }
                else if (btnAlterarCancelar.Text == "Cancelar")
                {
                    txtNome.Text = "";
                    dgvModalidade.Enabled = true;
                    btnExcluir.Enabled = true;
                    cbCasa.SelectedIndex = 0;
                    btnAdicionarSalvar.Text = "Adicionar";
                    btnAlterarCancelar.Text = "Alterar";
                    Campos(false);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há registros para serem alterados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                enumerador = Enumeradores.ModalidadeDelete;

                FiscalizarAcao();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há registros para serem alterados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("A instrução DELETE conflitou com a restrição do REFERENCE \"FK__tb_curso__id_mod__1BFD2C07\". O conflito ocorreu no banco de dados \"bdReserva\", tabela \"dbo.tb_curso\", column 'id_modalidade'."))
                {
                    MessageBox.Show("Existem curso(s) nessa modalidade.\nExclua os cursos dessa modalidade para realizar a exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("A instrução DELETE conflitou com a restrição do REFERENCE \"FK__tb_curso__id_mod__1B0907CE\". O conflito ocorreu no banco de dados \"bdReserva\", tabela \"dbo.tb_curso\", column 'id_modalidade'.\r\nA instrução foi finalizada."))
                {
                    MessageBox.Show("Existem curso(s) nessa modalidade.\nExclua os cursos dessa modalidade para realizar a exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Campos(false);
                btnAdicionarSalvar.Text = "Adicionar";
                btnAlterarCancelar.Text = "Alterar";
            }

        }

        private void FiscalizarAcao()
        {
            try
            {

                if (enumerador == Enumeradores.ModalidadeInsert)
                {
                    p_modalidade = new DtoModalidade(
                        1,
                        txtNome.Text,
                        int.Parse(cbCasa.SelectedValue.ToString()),
                        cbCasa.SelectedItem.ToString());

                    objBll.InsertModalidade(p_modalidade);
                }

                if (enumerador == Enumeradores.ModalidadeDelete)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir a Modalidade "+ dgvModalidade.SelectedRows[0].Cells["NomeModalidade"].Value.ToString() +"\n da casa "+ dgvModalidade.SelectedRows[0].Cells["NomeCasa"].Value.ToString() +"?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int p_IdModalidade = Convert.ToInt32(dgvModalidade.SelectedRows[0].Cells["IdModalidade"].Value.ToString());

                        objBll.DeleteModalidade(p_IdModalidade);


                        MessageBox.Show("Modalidade excluída com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dgvModalidade.DataSource = objBll.SelectModalidade();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Campos(bool tf)
        {
            cbCasa.Enabled = tf;
            txtNome.Enabled = tf;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion METHODS
    }
}
