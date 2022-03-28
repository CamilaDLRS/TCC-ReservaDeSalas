using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using prjDil;
using prjDto;

namespace prjDal
{
    public class Dal
    {
        /// <summary>
        /// =======================================================================
        /// Author:         Delarosa, Camila & Pereira, Lucas
        /// Create date:    01/06/2017
        /// Description:    Database Access Layer
        /// Public
        /// Properties:
        /// Public
        /// Error control:  Exceções são elevadas ao método chamador
        ///                 Mensagens de erro são registradas na biblioteca de classe prjBll
        /// Classe baseada no projeto 'prjCRUD13' de Gilmar Trevisan  
        /// =======================================================================
        /// </summary>

        #region PROPERTIES

        private Dil objDil = null;

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public Dal()
        {
            objDil = new Dil();
        }
        #endregion CONSTRUCTORS

        #region METHODS

        #region USUARIO

        public void InsertUsuario(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_login", usuario.Login);

                object ver = objDil.ExecuteAFieldQuery(CommandType.StoredProcedure, ("sp_verificar_login"));

                if (ver == null)
                {
                    objDil.ClearParameterCollection();

                    objDil.AddParameter("@p_nome_usuario", usuario.NomeUsuario);
                    objDil.AddParameter("@p_login", usuario.Login);
                    objDil.AddParameter("@p_senha", usuario.Senha);
                    objDil.AddParameter("@p_identificacao_adm", usuario.IdentificacaoAdministrador);
                    objDil.AddParameter("@p_id_casa", usuario.IdCasa);

                    objDil.ExecuteStoredProcedureNonQuery("sp_insert_usuario");
                }

                else
                {
                    Exception ex = new Exception("Login já existente.");

                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuario(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_usuario", usuario.IdUsuario);
                objDil.AddParameter("@p_id_casa", usuario.IdCasa);
                objDil.AddParameter("@p_nome_usuario", usuario.NomeUsuario);
                objDil.AddParameter("@p_senha", usuario.Senha);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuarioAdm(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_usuario", usuario.IdUsuario);
                objDil.AddParameter("@p_adm", usuario.IdentificacaoAdministrador);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_usuario_adm");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuarioResetarSenha(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_usuario", usuario.IdUsuario);
                objDil.AddParameter("@p_senha", usuario.Senha);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_usuario_resetar_senha");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TrocaStatusUsuario(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_usuario", usuario.IdUsuario);
                objDil.AddParameter("@p_status", usuario.Status);

                objDil.ExecuteStoredProcedureNonQuery("sp_troca_de_status_usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ConsultarUsuario(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_login", usuario.Login);
                objDil.AddParameter("@p_senha", usuario.Senha);

                object verificacao = objDil.ExecuteAFieldQuery(CommandType.StoredProcedure, "sp_verificar_usuario");

                if (verificacao == null)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoUsuario SelectUsuarioLogin(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_login", usuario.Login);
                objDil.AddParameter("@p_senha", usuario.Senha);

                DataTable dtUsuarios = objDil.ExecuteStoredProcedureQuery("sp_select_usuario_by_login");

                DtoUsuario objUsuario = null;

                if (dtUsuarios.Rows.Count > 0)
                    objUsuario = new DtoUsuario(dtUsuarios.Rows[0]);

                return objUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<DtoUsuario> SelectUsuario(DtoUsuario status)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_status", status.Status);

                DataTable dtUsuario = objDil.ExecuteStoredProcedureQuery("sp_select_usuario");

                DtoUsuario usuario = null;

                List<DtoUsuario> lstUsuarios = new List<DtoUsuario>();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    usuario = new DtoUsuario(row);
                    lstUsuarios.Add(usuario);
                    usuario = null;
                }

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoUsuario SelectUsuarioById(DtoUsuario usuario)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_usuario", usuario.IdUsuario);

                DataTable dtUsuarios = objDil.ExecuteStoredProcedureQuery("sp_select_usuario_by_id");

                DtoUsuario objUsuario = null;

                if (dtUsuarios.Rows.Count > 0)
                    objUsuario = new DtoUsuario(dtUsuarios.Rows[0]);

                return objUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoUsuario> SelectUsuario(int idCasa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_casa", idCasa);

                DataTable dtUsuario = objDil.ExecuteStoredProcedureQuery("sp_select_usuario_by_casa");

                DtoUsuario usuario = null;

                List<DtoUsuario> lstUsuarios = new List<DtoUsuario>();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    usuario = new DtoUsuario(row);
                    lstUsuarios.Add(usuario);
                    usuario = null;
                }

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoUsuario> SelectUsuario(Boolean Adms)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_adms", Adms);

                DataTable dtUsuario = objDil.ExecuteStoredProcedureQuery("sp_select_usuario_adm");

                DtoUsuario usuario = null;

                List<DtoUsuario> lstUsuarios = new List<DtoUsuario>();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    usuario = new DtoUsuario(row);
                    lstUsuarios.Add(usuario);
                    usuario = null;
                }

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoUsuario> SelectUsuario()
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtUsuario = objDil.ExecuteStoredProcedureQuery("sp_select_all_usuario");

                DtoUsuario usuario = null;

                List<DtoUsuario> lstUsuarios = new List<DtoUsuario>();

                foreach (DataRow row in dtUsuario.Rows)
                {
                    usuario = new DtoUsuario(row);
                    lstUsuarios.Add(usuario);
                    usuario = null;
                }

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion USUARIO

        #region CASA

        public List<DtoCasa> SelectCasa()
        {
            try
            {
                objDil.ClearParameterCollection();      

                DataTable dtCasas = objDil.ExecuteStoredProcedureQuery("sp_select_casa");

                DtoCasa casa = null;

                List<DtoCasa> lstCasas = new List<DtoCasa>();

                foreach (DataRow row in dtCasas.Rows)
                {
                    casa = new DtoCasa(row);
                    lstCasas.Add(casa);
                    casa = null;
                }

                return lstCasas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertCasa(DtoCasa casa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_nome_casa", casa.NomeCasa);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_casa");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditCasa(DtoCasa casa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_casa", casa.IdCasa);
                objDil.AddParameter("@p_nome_casa", casa.NomeCasa);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_casa");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion CASA

        #region MODALIDADE 

        public List<DtoModalidade> SelectModalidade()
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtModalidade = objDil.ExecuteStoredProcedureQuery("sp_select_modalidade");

                DtoModalidade modalidade = null;

                List<DtoModalidade> lstModalidades = new List<DtoModalidade>();

                foreach (DataRow row in dtModalidade.Rows)
                {
                    modalidade = new DtoModalidade(row);
                    lstModalidades.Add(modalidade);
                    modalidade = null;
                }

                return lstModalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoModalidade> SelectModalidadeSesiSenai(int SesiSenai)
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtModalidade = objDil.ExecuteStoredProcedureQuery("sp_select_modalidade_sesi_senai");

                DtoModalidade modalidade = null;

                List<DtoModalidade> lstModalidades = new List<DtoModalidade>();

                foreach (DataRow row in dtModalidade.Rows)
                {
                    modalidade = new DtoModalidade(row);
                    lstModalidades.Add(modalidade);
                    modalidade = null;
                }

                return lstModalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoModalidade> SelectModalidade(int IdCasa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_casa", IdCasa);

                DataTable dtModalidade = objDil.ExecuteStoredProcedureQuery("sp_select_modalidade_by_id");

                DtoModalidade modalidade = null;

                List<DtoModalidade> lstModalidades = new List<DtoModalidade>();

                foreach (DataRow row in dtModalidade.Rows)
                {
                    modalidade = new DtoModalidade(row);
                    lstModalidades.Add(modalidade);
                    modalidade = null;
                }

                return lstModalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertModalidade(DtoModalidade modalidade)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_nome_modalidade", modalidade.NomeModalidade);
                objDil.AddParameter("@p_id_casa", modalidade.IdCasa);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_modalidade");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditModalidade(DtoModalidade modalidade)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_modalidade", modalidade.IdModalidade);
                objDil.AddParameter("@p_nome_modalidade", modalidade.NomeModalidade);
                objDil.AddParameter("@p_id_casa", modalidade.IdCasa);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_modalidade");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteModalidade(int IdModalidade)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_modalidade", IdModalidade);

                objDil.ExecuteStoredProcedureNonQuery("sp_delete_modalidade");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion MODALIDADE       

        #region CURSO

        public List<DtoCurso> SelectCurso()
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtCursos = objDil.ExecuteStoredProcedureQuery("sp_select_curso");

                DtoCurso curso = null;

                List<DtoCurso> lstCursos = new List<DtoCurso>();

                foreach (DataRow row in dtCursos.Rows)
                {
                    curso = new DtoCurso(row);
                    lstCursos.Add(curso);
                    curso = null;
                }

                return lstCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoCurso> SelectCurso(int IdModalidade)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_modalidade", IdModalidade);

                DataTable dtCursos = objDil.ExecuteStoredProcedureQuery("sp_select_curso_by_id");

                DtoCurso curso = null;

                List<DtoCurso> lstCursos = new List<DtoCurso>();

                foreach (DataRow row in dtCursos.Rows)
                {
                    curso = new DtoCurso(row);
                    lstCursos.Add(curso);
                    curso = null;
                }

                return lstCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertCurso(DtoCurso curso)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_nome_curso", curso.NomeCurso);
                objDil.AddParameter("@p_id_modalidade", curso.IdModalidade);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_curso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditCurso(DtoCurso curso)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_curso", curso.IdCurso);
                objDil.AddParameter("@p_nome_curso", curso.NomeCurso);
                objDil.AddParameter("@p_id_modalidade", curso.IdModalidade);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_curso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCurso(int IdCurso)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_curso", IdCurso);

                objDil.ExecuteStoredProcedureNonQuery("sp_delete_curso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion CURSO

        #region DISCIPLINA

        public List<DtoDisciplina> SelectDisciplina()
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtDisciplinas = objDil.ExecuteStoredProcedureQuery("sp_select_disciplina");

                DtoDisciplina disciplina = null;

                List<DtoDisciplina> lstDisciplinas = new List<DtoDisciplina>();

                foreach (DataRow row in dtDisciplinas.Rows)
                {
                    disciplina = new DtoDisciplina(row);
                    lstDisciplinas.Add(disciplina);
                    disciplina = null;
                }

                return lstDisciplinas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoDisciplina> SelectDisciplina(int IdCurso)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_curso", IdCurso);

                DataTable dtDisciplinas = objDil.ExecuteStoredProcedureQuery("sp_select_disciplina_by_id");

                DtoDisciplina disciplina = null;

                List<DtoDisciplina> lstDisciplinas = new List<DtoDisciplina>();

                foreach (DataRow row in dtDisciplinas.Rows)
                {
                    disciplina = new DtoDisciplina(row);
                    lstDisciplinas.Add(disciplina);
                    disciplina = null;
                }

                return lstDisciplinas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SelectDisciplinaQuantidade(int IdCasa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_casa", IdCasa);

                object quantidade = objDil.ExecuteAFieldQuery(CommandType.StoredProcedure, "sp_select_disciplina_count");

                return int.Parse(quantidade.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertDisciplina(DtoDisciplina disciplina)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_nome_disciplina", disciplina.NomeDisciplina);
                objDil.AddParameter("@p_id_curso", disciplina.IdCurso);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_disciplina");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditDisciplina(DtoDisciplina disciplina)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_disciplina", disciplina.IdDisciplina);
                objDil.AddParameter("@p_nome_disciplina", disciplina.NomeDisciplina);
                objDil.AddParameter("@p_id_curso", disciplina.IdCurso);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_disciplina");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDisciplina(int IdDisciplina)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_disciplina", IdDisciplina);

                objDil.ExecuteStoredProcedureNonQuery("sp_delete_disciplina");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion DISCIPLINA       

        #region SALA

        public List<DtoSala> SelectSala(Boolean status)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_status", status);

                DataTable dtSalas = objDil.ExecuteStoredProcedureQuery("sp_select_sala");

                DtoSala sala = null;

                List<DtoSala> lstSalas = new List<DtoSala>();

                foreach (DataRow row in dtSalas.Rows)
                {
                    sala = new DtoSala(row);
                    lstSalas.Add(sala);
                    sala = null;
                }

                return lstSalas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoSala SelectSala(int IdSala)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", IdSala);

                DataTable dtSalas = objDil.ExecuteStoredProcedureQuery("sp_select_sala_by_id");

                DtoSala objSala = null;

                if (dtSalas.Rows.Count > 0)
                    objSala = new DtoSala(dtSalas.Rows[0]);

                return objSala;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertSala(DtoSala sala)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_nome_sala", sala.NomeSala);
                objDil.AddParameter("@p_informacoes", sala.Informacoes);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_sala");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditSala(DtoSala sala)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", sala.IdSala);
                objDil.AddParameter("@p_nome_sala", sala.NomeSala);
                objDil.AddParameter("@p_informacoes", sala.Informacoes);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_sala");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TrocaStatusSala(DtoSala sala)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", sala.IdSala);
                objDil.AddParameter("@p_status", sala.Status);

                objDil.ExecuteStoredProcedureNonQuery("sp_troca_de_status_sala");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion SALA

        #region RESERVAS

        public List<DtoReserva> SelectReserva()
        {
            try
            {
                objDil.ClearParameterCollection();

                DataTable dtReservas = objDil.ExecuteStoredProcedureQuery("sp_select_reserva");

                DtoReserva reserva = null;

                List<DtoReserva> lstReservas = new List<DtoReserva>();

                foreach (DataRow row in dtReservas.Rows)
                {
                    reserva = new DtoReserva(row);
                    lstReservas.Add(reserva);
                    reserva = null;
                }

                return lstReservas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoReserva> SelectReserva(DateTime data, int idSala)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", idSala);
                objDil.AddParameter("@p_data", data);

                DataTable dtReservas = objDil.ExecuteStoredProcedureQuery("sp_select_reserva_sala_data");

                DtoReserva reserva = null;

                List<DtoReserva> lstReservas = new List<DtoReserva>();

                foreach (DataRow row in dtReservas.Rows)
                {
                    reserva = new DtoReserva(row);
                    lstReservas.Add(reserva);
                    reserva = null;
                }

                return lstReservas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoReserva> SelectReserva(string idSala, string idUsuario, string idCasa)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", idSala);
                objDil.AddParameter("@p_id_usuario", idUsuario);
                objDil.AddParameter("@p_id_casa", idCasa);

                DataTable dtReservas = objDil.ExecuteStoredProcedureQuery("sp_select_reserva_filtros");

                DtoReserva reserva = null;

                List<DtoReserva> lstReservas = new List<DtoReserva>();

                foreach (DataRow row in dtReservas.Rows)
                {
                    reserva = new DtoReserva(row);
                    lstReservas.Add(reserva);
                    reserva = null;
                }

                return lstReservas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertReserva(DtoReserva reserva)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_sala", reserva.IdSala);
                objDil.AddParameter("@p_id_usuario", reserva.IdUsuario);
                objDil.AddParameter("@p_nome_disciplina", reserva.NomeDisciplina);
                objDil.AddParameter("@p_nome_curso", reserva.NomeCurso);
                objDil.AddParameter("@p_nome_modalidade", reserva.NomeModalidade);
                objDil.AddParameter("@p_data", reserva.Data);
                objDil.AddParameter("@p_inicio", reserva.Entrada);
                objDil.AddParameter("@p_fim", reserva.Saida);

                objDil.ExecuteStoredProcedureNonQuery("sp_insert_reserva");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditReserva(DtoReserva reserva)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_reserva", reserva.IdReserva);
                objDil.AddParameter("@p_id_sala", reserva.IdSala);
                objDil.AddParameter("@p_nome_disciplina", reserva.NomeDisciplina);
                objDil.AddParameter("@p_nome_curso", reserva.NomeCurso);
                objDil.AddParameter("@p_nome_modalidade", reserva.NomeModalidade);
                objDil.AddParameter("@p_data", reserva.Data);
                objDil.AddParameter("@p_inicio", reserva.Entrada);
                objDil.AddParameter("@p_fim", reserva.Saida);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_reserva");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditReservaAdm(DtoReserva reserva)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_reserva", reserva.IdReserva);
                objDil.AddParameter("@p_id_sala", reserva.IdSala);
                objDil.AddParameter("@p_data", reserva.Data);
                objDil.AddParameter("@p_inicio", reserva.Entrada);
                objDil.AddParameter("@p_fim", reserva.Saida);

                objDil.ExecuteStoredProcedureNonQuery("sp_update_adm_reserva");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteReserva(int IdReserva)
        {
            try
            {
                objDil.ClearParameterCollection();

                objDil.AddParameter("@p_id_reserva", IdReserva);

                objDil.ExecuteStoredProcedureNonQuery("sp_delete_reserva");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion RESERVAS

        #endregion METHODS
    }
}
