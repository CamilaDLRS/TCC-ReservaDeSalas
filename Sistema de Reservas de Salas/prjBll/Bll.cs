using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjDal;
using prjDto;

namespace prjBll
{
    public class Bll
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
        #region PROPERTIE

        private Dal objDal = null;

        #endregion PROPERTIE

        #region CONSTRUCTORS
        public Bll()
        {
            this.objDal = new Dal();
        }
        #endregion CONSTRUCTORS

        #region METHODS

        #region USUARIO

        public void InsertUsuario(DtoUsuario p_Usuario)
        {
            try
            {
                CheckFieldsUsuario(p_Usuario);

                // Remove espaços à esquerda e à direita
                p_Usuario.Login = p_Usuario.Login.Trim();
                p_Usuario.NomeUsuario = p_Usuario.NomeUsuario.Trim();
                p_Usuario.Senha = p_Usuario.Senha.Trim();

                objDal.InsertUsuario(p_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuario(DtoUsuario p_Usuario)
        {
            try
            {
                CheckFieldsUsuario(p_Usuario);

                p_Usuario.NomeUsuario = p_Usuario.NomeUsuario.Trim();
                p_Usuario.Senha = p_Usuario.Senha.Trim();

                objDal.EditUsuario(p_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuarioAdm(DtoUsuario p_Usuario)
        {
            try
            {
                objDal.EditUsuarioAdm(p_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditUsuarioResetarSenha(DtoUsuario p_Usuario)
        {
            try
            {
                p_Usuario.Senha = p_Usuario.Senha.Trim();
                objDal.EditUsuarioResetarSenha(p_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TrocaStatusUsuario(DtoUsuario p_Usuario)
        {
            try
            {
                objDal.TrocaStatusUsuario(p_Usuario);
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
                usuario.Login = usuario.Login.Trim();
                usuario.Senha = usuario.Senha.Trim();

                if (objDal.ConsultarUsuario(usuario) == true)
                {
                    return true;
                }

                else
                {
                    return false;
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
                DtoUsuario objUsuario = objDal.SelectUsuarioLogin(usuario);

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
                List<DtoUsuario> lstUsuarios = null;

                lstUsuarios = objDal.SelectUsuario(status);

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
                DtoUsuario objUsuario = objDal.SelectUsuarioById(usuario);

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
                List<DtoUsuario> lstUsuarios = null;

                lstUsuarios = objDal.SelectUsuario(idCasa);

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoUsuario> SelectUsuario(Boolean Adm)
        {
            try
            {
                List<DtoUsuario> lstUsuarios = null;

                lstUsuarios = objDal.SelectUsuario(Adm);

                return lstUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsUsuario(DtoUsuario p_Usuario)
        {
            // Validações de campo são obrigatórias na camada DLL
            // mesmo que já tenham sido feitas na camada PL
            if (p_Usuario.NomeUsuario.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Nome é obrigatório.");

                throw ex;
            }

            if (p_Usuario.Login.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Login é obrigatório.");

                throw ex;
            }

            if (p_Usuario.Senha.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Senha é obrigatório.");

                throw ex;
            }

            if (p_Usuario.Senha.Trim().Length < 6)
            {
                Exception ex = new Exception("A senha deve conter 6 ou mais caracteres.");

                throw ex;
            }
        }

        public List<DtoUsuario> SelectUsuario()
        {
            try
            {
                List<DtoUsuario> lstUsuarios = null;

                lstUsuarios = objDal.SelectUsuario();

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
                List<DtoCasa> lstCasas = null;

                lstCasas = objDal.SelectCasa();

                return lstCasas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditCasa(DtoCasa p_Casa)
        {
            try
            {
                CheckFieldsCasa(p_Casa);

                objDal.EditCasa(p_Casa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsCasa(DtoCasa p_Casa)
        {
            if (p_Casa.NomeCasa.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Nome é obrigatório.");

                throw ex;
            }
        }

        public void InsertCasa(DtoCasa p_Casa)
        {
            try
            {
                CheckFieldsCasa(p_Casa);
                p_Casa.NomeCasa = p_Casa.NomeCasa.Trim();

                objDal.InsertCasa(p_Casa);
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
                List<DtoModalidade> lstModalidades = null;

                lstModalidades = objDal.SelectModalidade();

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
                List<DtoModalidade> lstModalidades = null;

                lstModalidades = objDal.SelectModalidadeSesiSenai(SesiSenai);

                return lstModalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoModalidade> SelectModalidade(int p_IdCasa)
        {
            try
            {
                List<DtoModalidade> lstModalidades = null;

                lstModalidades = objDal.SelectModalidade(p_IdCasa);

                return lstModalidades;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditModalidade(DtoModalidade p_Modalidade)
        {
            try
            {
                CheckFieldsModalidade(p_Modalidade);

                // Remove espaços à esquerda e à direita
                p_Modalidade.NomeModalidade = p_Modalidade.NomeModalidade.Trim();

                objDal.EditModalidade(p_Modalidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertModalidade(DtoModalidade p_Modalidade)
        {
            try
            {
                CheckFieldsModalidade(p_Modalidade);

                // Remove espaços à esquerda e à direita
                p_Modalidade.NomeModalidade = p_Modalidade.NomeModalidade.Trim();

                objDal.InsertModalidade(p_Modalidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteModalidade(int p_IdModalidade)
        {
            try
            {
                objDal.DeleteModalidade(p_IdModalidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsModalidade(DtoModalidade p_Modalidade)
        {
            if (p_Modalidade.NomeModalidade.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Modalidade é obrigatório.");

                throw ex;
            }
        }

        #endregion MODALIDADE

        #region CURSO
        public List<DtoCurso> SelectCurso()
        {
            try
            {
                List<DtoCurso> lstCursos = null;

                lstCursos = objDal.SelectCurso();

                return lstCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoCurso> SelectCurso(int p_IdModalidade)
        {
            try
            {
                List<DtoCurso> lstCursos = null;

                lstCursos = objDal.SelectCurso(p_IdModalidade);

                return lstCursos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditCurso(DtoCurso p_Curso)
        {
            try
            {
                CheckFieldsCurso(p_Curso);

                objDal.EditCurso(p_Curso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertCurso(DtoCurso p_Curso)
        {
            try
            {
                CheckFieldsCurso(p_Curso);

                p_Curso.NomeCurso = p_Curso.NomeCurso.Trim();

                objDal.InsertCurso(p_Curso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCurso(int p_IdCurso)
        {
            try
            {
                objDal.DeleteCurso(p_IdCurso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsCurso(DtoCurso p_Curso)
        {
            if (p_Curso.NomeCurso.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Curso é obrigatório.");

                throw ex;
            }
        }

        #endregion CURSO

        #region DISCIPLINA

        public List<DtoDisciplina> SelectDisciplina()
        {
            try
            {
                List<DtoDisciplina> lstDisciplinas = null;

                lstDisciplinas = objDal.SelectDisciplina();

                return lstDisciplinas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DtoDisciplina> SelectDisciplina(int p_Curso)
        {
            try
            {
                List<DtoDisciplina> lstDisciplinas = null;

                lstDisciplinas = objDal.SelectDisciplina(p_Curso);

                return lstDisciplinas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditDisciplina(DtoDisciplina p_Disciplina)
        {
            try
            {
                CheckFieldsDisciplina(p_Disciplina);

                objDal.EditDisciplina(p_Disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsDisciplina(DtoDisciplina p_Disciplina)
        {
            if (p_Disciplina.NomeDisciplina.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Disciplina é obrigatório.");

                throw ex;
            }
        }

        public void InsertDisciplina(DtoDisciplina p_Disciplina)
        {
            try
            {
                CheckFieldsDisciplina(p_Disciplina);

                p_Disciplina.NomeDisciplina = p_Disciplina.NomeDisciplina.Trim();

                objDal.InsertDisciplina(p_Disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDisciplina(int p_IdDisciplina)
        {
            try
            {
                objDal.DeleteDisciplina(p_IdDisciplina);
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
                return objDal.SelectDisciplinaQuantidade(IdCasa);
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
                List<DtoSala> lstSalas = null;

                lstSalas = objDal.SelectSala(status);

                return lstSalas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditSala(DtoSala p_Sala)
        {
            try
            {
                CheckFieldsSala(p_Sala);

                p_Sala.NomeSala = p_Sala.NomeSala.Trim();
                p_Sala.Informacoes = p_Sala.Informacoes.Trim();

                objDal.EditSala(p_Sala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsSala(DtoSala p_Sala)
        {
            if (p_Sala.NomeSala.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Nome é obrigatório.");

                throw ex;
            }

            if (p_Sala.Informacoes.Trim().Length > 200)
            {
                Exception ex = new Exception("As informações não podem conter mais de 200 caracteres");

                throw ex;
            }

        }

        public void InsertSala(DtoSala p_Sala)
        {
            try
            {
                CheckFieldsSala(p_Sala);

                p_Sala.NomeSala = p_Sala.NomeSala.Trim();
                p_Sala.Informacoes = p_Sala.Informacoes.Trim();

                objDal.InsertSala(p_Sala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TrocaStatusSala(DtoSala p_Sala)
        {
            try
            {
                objDal.TrocaStatusSala(p_Sala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion SALA

        #region RESERVA

        public List<DtoReserva> SelectReserva()
        {
            try
            {
                List<DtoReserva> lstReservas = null;

                lstReservas = objDal.SelectReserva();

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
                List<DtoReserva> lstReservas = null;

                lstReservas = objDal.SelectReserva(data, idSala);

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
                List<DtoReserva> lstReservas = null;

                lstReservas = objDal.SelectReserva(idSala, idUsuario, idCasa);

                return lstReservas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditReserva(DtoReserva p_Reserva)
        {
            try
            {
                CheckFieldsReserva(p_Reserva);

                p_Reserva.NomeDisciplina = p_Reserva.NomeDisciplina.Trim();
                p_Reserva.NomeCurso = p_Reserva.NomeCurso.Trim();
                p_Reserva.NomeModalidade = p_Reserva.NomeModalidade.Trim();

                objDal.EditReserva(p_Reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditReservaAdm(DtoReserva p_Reserva)
        {
            try
            {
                objDal.EditReservaAdm(p_Reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CheckFieldsReserva(DtoReserva p_Reserva)
        {
            if (p_Reserva.NomeDisciplina.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Disciplina é obrigatório.");

                throw ex;
            }

            if (p_Reserva.NomeCurso.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Curso é obrigatório.");

                throw ex;
            }

            if (p_Reserva.NomeSala.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Sala é obrigatório.");

                throw ex;
            }

            if (p_Reserva.NomeModalidade.Trim() == String.Empty)
            {
                Exception ex = new Exception("O campo Modalidade é obrigatório.");

                throw ex;
            }

            if (p_Reserva.Data == DateTime.Now.Date && p_Reserva.Entrada.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                Exception ex = new Exception("Não é possível reservar horários que já se passaram.");

                throw ex;
            }

            if (p_Reserva.Entrada > p_Reserva.Saida)
            {
                Exception ex = new Exception("A entrada não pode ser após a saída.");

                throw ex;
            }

            if(p_Reserva.Entrada == p_Reserva.Saida)
            {
                Exception ex = new Exception("A entrada e a saída devem ser diferentes.");

                throw ex;
            }
        }

        public void InsertReserva(DtoReserva p_Reserva)
        {
            try
            {
                CheckFieldsReserva(p_Reserva);

                p_Reserva.NomeDisciplina = p_Reserva.NomeDisciplina.Trim();
                p_Reserva.NomeCurso = p_Reserva.NomeCurso.Trim();
                p_Reserva.NomeModalidade = p_Reserva.NomeModalidade.Trim();

                objDal.InsertReserva(p_Reserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteReserva(int p_IdReserva)
        {
            try
            {
                objDal.DeleteReserva(p_IdReserva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion RESERVA

        #endregion METHODS
    }
}
