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
    public partial class Cursos : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        Enumeradores enumerador;
        DtoCurso p_curso = new DtoCurso();

        #endregion PROPERTIES

        #region CONSTRUCTOR

        public Cursos()
        {
            InitializeComponent();

            this.objBll = new Bll();
        }

        #endregion CONSTRUCTOR

        #region METHODS

        private void Cursos_Load(object sender, EventArgs e)
        {
            List<DtoCasa> casas = objBll.SelectCasa();
            cbCasa.DataSource = casas; /* Atribuo o DataSource a minha lista */
            cbCasa.ValueMember = "IdCasa"; /* O valor do combox eu pego do "Id" da minha classe Casa */
            cbCasa.DisplayMember = "NomeCasa"; /* O valor que o usuário irá ver no Combox */
            cbCasa.SelectedIndex = 0; /*Seleciona pelo id qual Casa aparecer antes*/
            //Adiciona dados na combobox Casa

            SelecionarModalidade();

            dgvCursos.DataSource = objBll.SelectCurso();

            dgvCursos.Columns[0].Visible = false; // Define a 1° Coluna(IdDisciplina) como não visível
            dgvCursos.Columns[1].HeaderText = "Curso"; //Define o nome da 2° Coluna(NomeDisciplian) como "Disciplina"
            dgvCursos.Columns[1].Width = 200;

            dgvCursos.Columns[2].Visible = false;
            dgvCursos.Columns[3].HeaderText = "Modalidade"; //Define o nome da 2° Coluna(NomeDisciplian) como "Disciplina"
            dgvCursos.Columns[3].Width = 153;

            dgvCursos.Columns[4].Visible = false;
            dgvCursos.Columns[5].HeaderText = "Casa"; //Define o nome da 2° Coluna(NomeDisciplian) como "Disciplina"
            dgvCursos.Columns[5].Width = 120;

            cbCasa.Enabled = false;
            cbModalidade.Enabled = false;
            txtNome.Enabled = false;



        }

        private void btnAdicionarSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdicionarSalvar.Text == "Adicionar")
                {
                    enumerador = Enumeradores.CursoInsert;

                    dgvCursos.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                    Campos(true);

                    SelecionarModalidade();
                }

                else if (btnAdicionarSalvar.Text == "Salvar")
                {
                    try
                    {
                        if (enumerador == Enumeradores.CursoInsert)
                        {
                            FiscalizarAcao();
                        }
                        else if (enumerador == Enumeradores.CursoEditar)
                        {
                            p_curso = new DtoCurso(
                           Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["IdCurso"].Value),
                           txtNome.Text, int.Parse(cbModalidade.SelectedValue.ToString()),
                           cbModalidade.SelectedItem.ToString(),
                           int.Parse(cbCasa.SelectedValue.ToString()),
                           cbCasa.SelectedItem.ToString());

                            objBll.EditCurso(p_curso);
                        }

                        dgvCursos.DataSource = objBll.SelectCurso();
                        cbCasa.SelectedIndex = 0;
                        SelecionarModalidade();

                        dgvCursos.Enabled = true;
                        btnExcluir.Enabled = true;

                        btnAdicionarSalvar.Text = "Adicionar";
                        btnAlterarCancelar.Text = "Alterar";

                        txtNome.Text = "";

                        Campos(false);

                        MessageBox.Show("Salvo com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                        {
                            MessageBox.Show("Não há nenhuma modalidade nesta casa.\nVolte e insira uma modalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterarCancelar.Text == "Alterar")
                {
                    cbCasa.SelectedValue = int.Parse(dgvCursos.SelectedRows[0].Cells["IdCasa"].Value.ToString());
                    cbModalidade.DataSource = objBll.SelectModalidade(int.Parse(cbCasa.SelectedValue.ToString()));
                    txtNome.Text = dgvCursos.SelectedRows[0].Cells["NomeCurso"].Value.ToString();

                    cbModalidade.SelectedValue = int.Parse(dgvCursos.SelectedRows[0].Cells["IdModalidade"].Value.ToString());

                    enumerador = Enumeradores.CursoEditar;

                    dgvCursos.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                    Campos(true);
                }
                else if (btnAlterarCancelar.Text == "Cancelar")
                {
                    txtNome.Text = "";
                    dgvCursos.Enabled = true;
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
                    MessageBox.Show("Não há cursos para serem alterados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                enumerador = Enumeradores.CursoDelete;

                FiscalizarAcao();
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há registros para serem excluídos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("A instrução DELETE conflitou com a restrição do REFERENCE \"FK__tb_discip__id_cu__1DE57479\". O conflito ocorreu no banco de dados \"bdReserva\", tabela \"dbo.tb_disciplina\", column 'id_curso'.\r\nA instrução foi finalizada."))
                {
                    MessageBox.Show("Existem disciplinas(s) nesse curso.\nExclua as disciplinas desse curso para realizar a exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (enumerador == Enumeradores.CursoInsert)

                {
                    p_curso = new DtoCurso(
                          1,
                           txtNome.Text, int.Parse(cbModalidade.SelectedValue.ToString()),
                           cbModalidade.SelectedItem.ToString(),
                           int.Parse(cbCasa.SelectedValue.ToString()),
                           cbCasa.SelectedItem.ToString());

                    objBll.InsertCurso(p_curso);
                }

                if (enumerador == Enumeradores.CursoDelete)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o Curso - "+ dgvCursos.SelectedRows[0].Cells["NomeCurso"].Value.ToString() +"?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int p_IdCurso = Convert.ToInt32(dgvCursos.SelectedRows[0].Cells["IdCurso"].Value.ToString());

                        objBll.DeleteCurso(p_IdCurso);

                        MessageBox.Show("Curso excluído com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dgvCursos.DataSource = objBll.SelectCurso();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SelecionarModalidade()
        {
            try
            {
                List<DtoModalidade> modalidades = objBll.SelectModalidade(int.Parse(cbCasa.SelectedValue.ToString()));
                cbModalidade.DataSource = modalidades;
                cbModalidade.ValueMember = "IdModalidade"; /* O valor do combox eu pego do "Id" da minha classe Casa */
                cbModalidade.DisplayMember = "NomeModalidade"; /* O valor que o usuário irá ver no Combox */
                cbModalidade.SelectedIndex = 0;
                cbModalidade.Enabled = true;

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                { 
                    cbModalidade.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbCasa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarModalidade();
        }

        private void Campos(bool tf)
        {
            cbCasa.Enabled = tf;
            cbModalidade.Enabled = tf;
            txtNome.Enabled = tf;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion METHODS
    }
}
