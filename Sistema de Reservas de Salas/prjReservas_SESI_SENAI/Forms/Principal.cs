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
    public partial class Principal : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        DtoUsuario usuario = new DtoUsuario();
        List<DtoReserva> reservaLista = new List<DtoReserva>();
        List<DtoReserva> reservaFiltrada = new List<DtoReserva>();

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public Principal(DtoUsuario usuario)
        {
            InitializeComponent();

            lblNomeUsuario.Text = usuario.NomeUsuario;
            this.usuario = usuario;
        }
        public Principal()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTORS

        #region METHODS

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deslogar?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (usuario.IdentificacaoAdministrador == false)
            {
                btnCasas.Visible = false;
                btnModalidades.Visible = false;
                btnCursos.Visible = false;
                btnDisciplinas.Visible = false;
                btnUsuarios.Visible = false;
            }           

            dtpInicio.CustomFormat = " ";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = " ";
            dtpFim.Format = DateTimePickerFormat.Custom;           

            dgvReservas.DataSource = objBll.SelectReserva();

            dgvReservas.Columns[0].Visible = false;
            dgvReservas.Columns[1].HeaderText = "Sala";
            dgvReservas.Columns[1].Width = 180;
            dgvReservas.Columns[3].DefaultCellStyle.Format = "t";
            dgvReservas.Columns[3].Width = 80;
            dgvReservas.Columns[4].DefaultCellStyle.Format = "t";
            dgvReservas.Columns[4].Width = 80;
            dgvReservas.Columns[5].Visible = false;
            dgvReservas.Columns[6].Visible = false;
            dgvReservas.Columns[7].HeaderText = "Usuário";
            dgvReservas.Columns[7].Width = 150;
            dgvReservas.Columns[8].Visible = false;
            dgvReservas.Columns[9].HeaderText = "Casa";
            dgvReservas.Columns[10].HeaderText = "Curso";
            dgvReservas.Columns[11].Width = 180;
            dgvReservas.Columns[11].HeaderText = "Modalidade";
            dgvReservas.Columns[12].HeaderText = "Disciplina";
            dgvReservas.Columns[12].Width = 180;

            List<DtoCasa> casas = objBll.SelectCasa();
            cbCasa.DataSource = casas;
            cbCasa.ValueMember = "IdCasa";
            cbCasa.DisplayMember = "NomeCasa";
            cbCasa.SelectedItem = null;

            List<DtoUsuario> usuarios = objBll.SelectUsuario();
            cbUsuario.DataSource = usuarios;
            cbUsuario.ValueMember = "IdUsuario";
            cbUsuario.DisplayMember = "NomeUsuario";
            cbUsuario.SelectedItem = null;

            Boolean status = false;
            List<DtoSala> salas = objBll.SelectSala(status);
            cbSala.DataSource = salas;
            cbSala.ValueMember = "IdSala";
            cbSala.DisplayMember = "NomeSala";
            cbSala.SelectedItem = null;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(usuario);
            usuarios.ShowDialog();

            Principal_Load(sender, e);
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (int.Parse(objBll.SelectDisciplinaQuantidade(usuario.IdCasa.Value).ToString()) == 0)
            {
                MessageBox.Show("Para reservar é necessário no mínimo uma modalidade, um curso e uma disciplina de sua casa(as).\n" +
                "Caso não possua permissão para inserir os itens acima, consulte um Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (objBll.SelectSala(true).Count == 0)
            {
                MessageBox.Show("Para reservar é necessário no mínimo uma sala.\n" +
                "Caso não possua permissão para inserir, consulte um Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Reservar reservar = new Reservar(usuario);
                reservar.ShowDialog();

                Principal_Load(sender, e);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

            else
            {
                e.Cancel = true;
            }
        }

        private void btnCasas_Click(object sender, EventArgs e)
        {
            Casas casa = new Casas();
            casa.ShowDialog();

            Principal_Load(sender, e);
        }

        private void btnModalidades_Click(object sender, EventArgs e)
        {
            Modalidades modalidade = new Modalidades();
            modalidade.ShowDialog();

            Principal_Load(sender, e);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            curso.ShowDialog();

            Principal_Load(sender, e);
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            Disciplinas disciplina = new Disciplinas();
            disciplina.ShowDialog();

            Principal_Load(sender, e);
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            Salas salas = new Salas(usuario);
            salas.ShowDialog();

            Principal_Load(sender, e);
        }

        private void alterarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto_Alteração_Usuario alteracao = new Auto_Alteração_Usuario(usuario);
            alteracao.ShowDialog();

            usuario = objBll.SelectUsuarioById(usuario);
            lblNomeUsuario.Text = usuario.NomeUsuario;
        }

        private void Excluir(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Data"].Value.ToString()).Date > DateTime.Now.Date || Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Data"].Value.ToString()).Date == DateTime.Now.Date && Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Entrada"].Value.ToString()).TimeOfDay > DateTime.Now.TimeOfDay)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir essa reserva?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBll.DeleteReserva(int.Parse(dgvReservas.SelectedRows[0].Cells["IdReserva"].Value.ToString()));
                        Principal_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Não permetido a exclusão de reservas iniciadas ou concretizadas.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há reservas para serem excluídas.\n(Verifique os filtros)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (usuario.IdentificacaoAdministrador == true)
            {
                Excluir(sender, e);
            }
            else
            {
                if (dgvReservas.RowCount == 0)
                {
                    MessageBox.Show("Não há reservas para serem excluídas.\n(Verifique os filtros)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.Parse(dgvReservas.SelectedRows[0].Cells["IdUsuario"].Value.ToString()) != usuario.IdUsuario)
                {
                    MessageBox.Show("Voce não tem permissão para excluir reservas de outros usuários.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Excluir(sender, e);
                }
            }

        }

        private void Alterar()
        {
            try
            {
                if (Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Data"].Value.ToString()).Date > DateTime.Now.Date || Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Data"].Value.ToString()).Date == DateTime.Now.Date && Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Entrada"].Value.ToString()).TimeOfDay > DateTime.Now.TimeOfDay)
                {
                    DtoReserva reserva = new DtoReserva(int.Parse(dgvReservas.SelectedRows[0].Cells["IdReserva"].Value.ToString()),
                        Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Data"].Value.ToString()),
                        Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Entrada"].Value.ToString()),
                        Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["Saida"].Value.ToString()),
                        int.Parse(dgvReservas.SelectedRows[0].Cells["IdSala"].Value.ToString()),
                        dgvReservas.SelectedRows[0].Cells["NomeSala"].Value.ToString(),
                        int.Parse(dgvReservas.SelectedRows[0].Cells["IdUsuario"].Value.ToString()),
                        dgvReservas.SelectedRows[0].Cells["NomeUsuario"].Value.ToString(),
                        int.Parse(dgvReservas.SelectedRows[0].Cells["IdCasa"].Value.ToString()),
                        dgvReservas.SelectedRows[0].Cells["NomeCasa"].Value.ToString(),
                        dgvReservas.SelectedRows[0].Cells["NomeCurso"].Value.ToString(),
                        dgvReservas.SelectedRows[0].Cells["NomeModalidade"].Value.ToString(),
                        dgvReservas.SelectedRows[0].Cells["NomeDisciplina"].Value.ToString());

                    Reservar reservar = new Reservar(reserva, usuario);
                    reservar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não permetido a edição de reservas iniciadas ou concretizadas.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção."))
                {
                    MessageBox.Show("Não há reservas para serem alteradas.\n(Verifique os filtros)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario.IdentificacaoAdministrador == false)
                {
                    if (dgvReservas.RowCount == 0)
                    {
                        MessageBox.Show("Não há reservas para serem alteradas.\n(Verifique os filtros)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (int.Parse(dgvReservas.SelectedRows[0].Cells["IdUsuario"].Value.ToString()) != usuario.IdUsuario)
                    {
                        MessageBox.Show("Voce não tem permissão para editar reservas de outros usuários.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Alterar();
                        Principal_Load(sender, e);
                    }
                }
                else
                {
                    Alterar();
                    Principal_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            Principal_Load(sender, e);
            Campos(true);
        }

        private void btnAtivarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                string sala = "0", usuario = "0", casa = "0";

                if (cbSala.SelectedValue != null)
                {
                    sala = cbSala.SelectedValue.ToString();
                }
                if (cbUsuario.SelectedValue != null)
                {
                    usuario = cbUsuario.SelectedValue.ToString();
                }
                if (cbCasa.SelectedValue != null)
                {
                    casa = cbCasa.SelectedValue.ToString();
                }

                reservaLista = objBll.SelectReserva(sala, usuario, casa);
                reservaFiltrada = new List<DtoReserva>();

                if (dtpFim.CustomFormat != " " && dtpInicio.CustomFormat != " ")
                {
                    for (int i = 0; i < reservaLista.Count; i++)
                    {
                        if (reservaLista[i].Data.Date >= dtpInicio.Value.Date && reservaLista[i].Data.Date <= dtpFim.Value.Date)
                        {
                            reservaFiltrada.Add(reservaLista[i]);
                        }
                    }

                    dgvReservas.DataSource = reservaFiltrada;
                }
                else
                {
                    dgvReservas.DataSource = reservaLista;
                }

                if (reservaLista.Count == 0)
                {
                    MessageBox.Show("Nenhuma reserva foi encontrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Campos(bool tf)
        {
            cbCasa.Enabled = tf;
            cbSala.Enabled = tf;
            cbUsuario.Enabled = tf;
            dtpInicio.Enabled = tf;
            dtpFim.Enabled = tf;
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFim.MinDate = dtpInicio.Value;
            dtpInicio.CustomFormat = "dddd, d 'de' MMMM 'de' yyyy";
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            dtpFim.CustomFormat = "dddd, d 'de' MMMM 'de' yyyy";
        }

        private void cbCasa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                List<DtoUsuario> usuarios = objBll.SelectUsuario(int.Parse(cbCasa.SelectedValue.ToString()));
                cbUsuario.DataSource = usuarios;
                cbUsuario.ValueMember = "IdUsuario"; /* O valor do combox eu pego do "Id" da minha classe Casa */
                cbUsuario.DisplayMember = "NomeUsuario"; /* O valor que o usuário irá ver no Combox */
                cbUsuario.SelectedValue = 0;
                cbUsuario.Enabled = true;

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                {
                    cbUsuario.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion METHODS
    }
}
