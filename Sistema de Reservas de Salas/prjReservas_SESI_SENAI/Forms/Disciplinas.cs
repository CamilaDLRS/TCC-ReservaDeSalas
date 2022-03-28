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
    public partial class Disciplinas : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();

        Enumeradores enumerador;
        DtoDisciplina p_disciplina = new DtoDisciplina();
        #endregion PROPERTIES

        #region CONSTRUCTOR
        public Disciplinas()
        {
            InitializeComponent();

            this.objBll = new Bll();
        }


        #endregion CONSTRUCTOR

        #region METHODS

        private void Disciplinas_Load(object sender, EventArgs e)
        {
            try
            {
                List<DtoCasa> casas = objBll.SelectCasa();
                cbCasa.DataSource = casas; 
                cbCasa.ValueMember = "IdCasa"; 
                cbCasa.DisplayMember = "NomeCasa"; 
                cbCasa.SelectedIndex = 0; 
                                          

                SelecionarModalidade();

                SelecionarCurso();

                dgvDisciplinas.DataSource = objBll.SelectDisciplina();

                dgvDisciplinas.Columns[0].Visible = false; 
                dgvDisciplinas.Columns[1].HeaderText = "Disciplina"; 
                dgvDisciplinas.Columns[1].Width = 200;

                dgvDisciplinas.Columns[2].Visible = false;
                dgvDisciplinas.Columns[3].HeaderText = "Curso"; 
                dgvDisciplinas.Columns[3].Width = 170;

                dgvDisciplinas.Columns[4].Visible = false;
                dgvDisciplinas.Columns[5].HeaderText = "Modalidade"; 
                dgvDisciplinas.Columns[5].Width = 180;

                dgvDisciplinas.Columns[6].Visible = false;
                dgvDisciplinas.Columns[7].HeaderText = "Casa"; 
                dgvDisciplinas.Columns[7].Width = 100;

                Campos(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdicionarSalvar.Text == "Adicionar")
                {
                    enumerador = Enumeradores.DisciplinaInsert;

                    dgvDisciplinas.Enabled = false;
                    btnExcluir.Enabled = false;

                    btnAdicionarSalvar.Text = "Salvar";
                    btnAlterarCancelar.Text = "Cancelar";

                    Campos(true);

                    SelecionarModalidade();
                    SelecionarCurso();
                }

                else if (btnAdicionarSalvar.Text == "Salvar")
                {
                    try
                    {
                        if (enumerador == Enumeradores.DisciplinaInsert)
                        {
                            FiscalizarAcao();
                        }
                        else if (enumerador == Enumeradores.DisciplinaEditar)
                        {
                            p_disciplina = new DtoDisciplina(
                           Convert.ToInt32(dgvDisciplinas.SelectedRows[0].Cells["IdDisciplina"].Value),
                           txtNome.Text, int.Parse(cbCurso.SelectedValue.ToString()),
                           cbCurso.SelectedItem.ToString(),
                           int.Parse(cbModalidade.SelectedValue.ToString()),
                           cbModalidade.SelectedItem.ToString(),
                           int.Parse(cbCasa.SelectedValue.ToString()),
                           cbCasa.SelectedItem.ToString());

                            objBll.EditDisciplina(p_disciplina);
                        }

                        dgvDisciplinas.DataSource = objBll.SelectDisciplina();
                        cbCasa.SelectedIndex = 0;
                        cbModalidade.SelectedValue = 0;
                        cbCurso.SelectedIndex = 0;

                        dgvDisciplinas.Enabled = true;
                        btnExcluir.Enabled = true;
                        cbModalidade.SelectedValue = 0;
                        cbCurso.SelectedValue = 0;
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
                            MessageBox.Show("Não há nenhuma modalidade ou curso cadastrado nesta casa.\nVolte e insira. (Caso a modalidade não possua, insira mesmo assim. Utilize como exemplo: Curso: 'NA = Não se aplica.')", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterarCancelar.Text == "Alterar")
                {
                    try
                    {
                        cbCasa.SelectedValue = int.Parse(dgvDisciplinas.SelectedRows[0].Cells["IdCasa"].Value.ToString());
                        txtNome.Text = dgvDisciplinas.SelectedRows[0].Cells["NomeDisciplina"].Value.ToString();
                        cbModalidade.SelectedValue = int.Parse(dgvDisciplinas.SelectedRows[0].Cells["IdModalidade"].Value.ToString());
                        SelecionarCurso();
                        cbCurso.SelectedValue = int.Parse(dgvDisciplinas.SelectedRows[0].Cells["IdCurso"].Value.ToString());

                        enumerador = Enumeradores.DisciplinaEditar;

                        dgvDisciplinas.Enabled = false;
                        btnExcluir.Enabled = false;

                        btnAdicionarSalvar.Text = "Salvar";
                        btnAlterarCancelar.Text = "Cancelar";
                        Campos(true);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                        {
                            MessageBox.Show("Não há registros para serem alterados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnAdicionarSalvar.Text = "Adicionar";
                            btnAlterarCancelar.Text = "Alterar";
                            Campos(false);
                        }
                    }           
                }
                else if (btnAlterarCancelar.Text == "Cancelar")
                {
                    txtNome.Text = "";
                    dgvDisciplinas.Enabled = true;
                    btnExcluir.Enabled = true;
                    cbCasa.SelectedIndex = 0;                    
                    btnAdicionarSalvar.Text = "Adicionar";
                    btnAlterarCancelar.Text = "Alterar";
                    Campos(false);                    
                    cbModalidade.SelectedValue = 0;
                    cbCurso.SelectedValue = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                enumerador = Enumeradores.DisciplinaDelete;

                FiscalizarAcao();
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há registros para serem excluidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiscalizarAcao()
        {
            try
            {
                if (enumerador == Enumeradores.DisciplinaInsert)

                {
                    p_disciplina = new DtoDisciplina(
                       1,
                       txtNome.Text, int.Parse(cbCurso.SelectedValue.ToString()),
                       cbCurso.SelectedItem.ToString(),
                       int.Parse(cbModalidade.SelectedValue.ToString()),
                       cbModalidade.SelectedItem.ToString(),
                       int.Parse(cbCasa.SelectedValue.ToString()),
                       cbCasa.SelectedItem.ToString());

                    objBll.InsertDisciplina(p_disciplina);
                }

                if (enumerador == Enumeradores.DisciplinaDelete)
                {
                    int p_IdDisciplina = Convert.ToInt32(dgvDisciplinas.SelectedRows[0].Cells["IdDisciplina"].Value.ToString());
                    if (MessageBox.Show("Tem certeza que deseja excluir a Disciplina - "+ dgvDisciplinas.SelectedRows[0].Cells["NomeDisciplina"].Value.ToString() +" do Curso - "+dgvDisciplinas.SelectedRows[0].Cells["NomeCurso"].Value.ToString() +"?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBll.DeleteDisciplina(p_IdDisciplina);

                        MessageBox.Show("Disciplina excluída com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dgvDisciplinas.DataSource = objBll.SelectDisciplina();
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
                cbModalidade.ValueMember = "IdModalidade"; 
                cbModalidade.DisplayMember = "NomeModalidade"; 
                cbModalidade.SelectedIndex = 0;
                cbModalidade.Enabled = true;

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                {
                    cbModalidade.Enabled = false;
                    cbCurso.Enabled = false;
                    cbCurso.SelectedValue = 0;
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelecionarCurso()
        {
            try
            {
                List<DtoCurso> curso = objBll.SelectCurso(int.Parse(cbModalidade.SelectedValue.ToString()));
                if (curso.Count == 0)
                {
                    cbCurso.Enabled = false;
                    cbCurso.SelectedValue = 0;
                }
                else
                {
                    cbCurso.DataSource = curso;
                    cbCurso.ValueMember = "IdCurso"; 
                    cbCurso.DisplayMember = "NomeCurso"; 
                    cbCurso.SelectedIndex = 0;
                    cbCurso.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                    cbCurso.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Campos(bool tf)
        {
            cbCurso.Enabled = tf;
            txtNome.Enabled = tf;
            cbModalidade.Enabled = tf;
            cbCasa.Enabled = tf;
        }

        private void cbCasa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarModalidade();
            SelecionarCurso();
        }        

        private void cbModalidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarCurso();
        }

        #endregion METHODS
    }
}
