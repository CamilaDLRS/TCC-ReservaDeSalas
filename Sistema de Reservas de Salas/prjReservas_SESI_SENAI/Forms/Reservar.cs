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
    public partial class Reservar : Form
    {
        #region PROPERTIES

        Bll objBll = new Bll();
        DtoUsuario usuario = new DtoUsuario();
        DtoReserva reservaEdit = new DtoReserva();
        DtoReserva reserva = new DtoReserva();
        List<DtoReserva> reservasLista = new List<DtoReserva>();
        Enumeradores enumerador;

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public Reservar(DtoUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public Reservar(DtoReserva reserva, DtoUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.reservaEdit = reserva;

            if (reserva.IdUsuario == usuario.IdUsuario)
            {
                enumerador = Enumeradores.ReservaEditar;
            }
            else
            {
                enumerador = Enumeradores.ReservaEditarAdm;
            }
        }
        #endregion CONSTRUCTORS

        #region METHODS

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reservar_Load(object sender, EventArgs e)
        {
            monthCalendar.MinDate = DateTime.Now;
            dudEntrada.SelectedIndex = 0;
            dudSaida.SelectedIndex = 0;
            try
            {
                List<DtoModalidade> modalidades;

                if (usuario.IdCasa == 3)
                {
                    modalidades = objBll.SelectModalidadeSesiSenai(3);
                }
                else
                {
                    modalidades = objBll.SelectModalidade(int.Parse(usuario.IdCasa.Value.ToString()));
                }

                cbModalidade.DataSource = modalidades;
                cbModalidade.ValueMember = "IdModalidade";
                cbModalidade.DisplayMember = "NomeModalidade";
                cbModalidade.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                {
                    cbModalidade.Enabled = false;
                    cbModalidade.SelectedValue = 0;
                }
                else if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                    cbCurso.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Boolean status = true;
            List<DtoSala> salas = objBll.SelectSala(status);
            cbSala.DataSource = salas;
            cbSala.ValueMember = "IdSala";
            cbSala.DisplayMember = "NomeSala";
            cbSala.SelectedItem = null;

            SelecionarCurso();
            SelecionarDisciplina();

            if (enumerador == Enumeradores.ReservaEditarAdm || enumerador == Enumeradores.ReservaEditar)
            {
                cbModalidade.SelectedText = reservaEdit.NomeModalidade;
                cbCurso.SelectedText = reservaEdit.NomeCurso;
                cbDisciplina.SelectedText = reservaEdit.NomeDisciplina;
                cbSala.SelectedValue = reservaEdit.IdSala;
                monthCalendar.SelectionStart = reservaEdit.Data.Date;
                dudEntrada.Text = reservaEdit.Entrada.TimeOfDay.ToString();
                dudSaida.Text = reservaEdit.Saida.TimeOfDay.ToString();

                if (enumerador == Enumeradores.ReservaEditarAdm)
                {
                    cbCurso.Enabled = false;
                    cbDisciplina.Enabled = false;
                    cbModalidade.Enabled = false;
                }
            }
        }

        private void SelecionarDisciplina()
        {
            try
            {
                List<DtoDisciplina> disciplinas = objBll.SelectDisciplina(int.Parse(cbCurso.SelectedValue.ToString()));
                cbDisciplina.DataSource = disciplinas;
                cbDisciplina.ValueMember = "IdDisciplina"; /* O valor do combox eu pego do "Id" da minha classe Casa */
                cbDisciplina.DisplayMember = "NomeDisciplina"; /* O valor que o usuário irá ver no Combox */
                cbDisciplina.SelectedIndex = 0;
                cbDisciplina.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                {
                    cbDisciplina.Enabled = false;
                    cbDisciplina.SelectedValue = 0;
                    //MessageBox.Show("Não há nenhuma disciplina neste curso.\nVolte e insira uma disciplina.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Referência de objeto não definida para uma instância de um objeto."))
                {
                    cbCurso.Enabled = false;
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

                cbCurso.DataSource = curso;
                cbCurso.ValueMember = "IdCurso"; /* O valor do combox eu pego do "Id" da minha classe Casa */
                cbCurso.DisplayMember = "NomeCurso"; /* O valor que o usuário irá ver no Combox */
                cbCurso.SelectedIndex = 0;
                cbCurso.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("InvalidArgument=Value '0' não é um valor válido para 'SelectedIndex'."))
                {
                    cbCurso.Enabled = false;
                    cbDisciplina.Enabled = false;
                    cbDisciplina.SelectedValue = 0;                    
                }
                else
                {
                    MessageBox.Show("Erro de sistema, solicite suporte técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSala.Text == String.Empty)
                {
                    MessageBox.Show("O campo Sala é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int quant = 0;
                    reservasLista = objBll.SelectReserva(monthCalendar.SelectionStart.Date, int.Parse(cbSala.SelectedValue.ToString()));

                    if (reservasLista.Count >= 1)
                    {
                        for (int i = 0; i < reservasLista.Count; i++)
                        {
                            if (Convert.ToDateTime(dudEntrada.Text).TimeOfDay < reservasLista[i].Saida.TimeOfDay && Convert.ToDateTime(dudSaida.Text).TimeOfDay > reservasLista[i].Entrada.TimeOfDay)
                            {
                                if (reservasLista[i].IdReserva != reservaEdit.IdReserva)
                                {
                                    MessageBox.Show("Esta sala já esta reservada pelo(a) " + reservasLista[i].NomeUsuario + "\n das " + reservasLista[i].Entrada.TimeOfDay + " as " + reservasLista[i].Saida.TimeOfDay + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    quant++;
                                }
                            }
                        }
                    }

                    if (quant == 0)
                    {

                        if (enumerador == Enumeradores.ReservaEditar)
                        {
                            reserva = new DtoReserva(reservaEdit.IdReserva, monthCalendar.SelectionStart.Date, Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") + " " + dudEntrada.Text), Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") + " " + dudSaida.Text), int.Parse(cbSala.SelectedValue.ToString()),
                            cbSala.Text, usuario.IdUsuario.Value, usuario.NomeUsuario, usuario.IdCasa.Value, usuario.NomeCasa, cbCurso.Text, cbModalidade.Text, cbDisciplina.Text);

                            objBll.EditReserva(reserva);
                            MessageBox.Show("Reserva editada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (enumerador == Enumeradores.ReservaEditarAdm)
                        {
                            reserva = new DtoReserva(reservaEdit.IdReserva, monthCalendar.SelectionStart.Date, Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy")+" "+dudEntrada.Text), Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") + " " + dudSaida.Text), int.Parse(cbSala.SelectedValue.ToString()),
                            cbSala.Text, null, null, null, null, null, null, null);

                            objBll.EditReservaAdm(reserva);
                            MessageBox.Show("Reserva editada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            reserva = new DtoReserva(null, monthCalendar.SelectionStart.Date, Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") + " " + dudEntrada.Text), Convert.ToDateTime(monthCalendar.SelectionStart.Date.ToString("dd/MM/yyyy") + " " + dudSaida.Text), int.Parse(cbSala.SelectedValue.ToString()),
                            cbSala.Text, usuario.IdUsuario.Value, usuario.NomeUsuario, usuario.IdCasa.Value, usuario.NomeCasa, cbCurso.Text, cbModalidade.Text, cbDisciplina.Text);


                            objBll.InsertReserva(reserva);

                            MessageBox.Show("Reservado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cbModalidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarCurso();
            SelecionarDisciplina();
        }

        private void cbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarDisciplina();
        }
        #endregion METHODS
    }
}
