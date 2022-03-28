using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDto
{
    /// <summary>
    /// =======================================================================
    /// Author:         Delarosa, Camila
    /// Create date:    01/06/2017
    /// Description:    Database Transference Object - Casa
    /// Public  
    /// Error control:  Exceções são elevadas ao método chamador
    ///                 Mensagens de erro são registradas na biblioteca de classe prjBll
    /// Classe baseada no projeto 'prjCRUD13' de Gilmar Trevisan                
    /// =======================================================================
    /// </summary>
    public class DtoReserva
    {
        #region PROPERTIES
        
        public int? IdReserva { get; set; }
        public string NomeSala { get; set; }
        public DateTime Data { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public int IdSala { get; set; }
        public int? IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public int? IdCasa { get; set; }
        public string NomeCasa { get; set; }
        public string NomeModalidade { get; set; }
        public string NomeCurso { get; set; }
        public string NomeDisciplina { get; set; }

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public DtoReserva(DataRow row)
        {

            try
            {
                this.IdReserva = int.Parse(row["id_reserva"].ToString());
                this.Data = DateTime.Parse(row["data"].ToString());
                this.Entrada = DateTime.Parse(row["inicio"].ToString());
                this.Saida = DateTime.Parse(row["fim"].ToString());
                this.IdSala = int.Parse(row["id_sala"].ToString());
                this.NomeSala = row["nome_sala"].ToString();
                this.IdUsuario = int.Parse(row["id_usuario"].ToString());
                this.NomeUsuario = row["nome_usuario"].ToString();
                this.IdCasa = int.Parse(row["id_casa"].ToString());
                this.NomeCasa = row["nome_casa"].ToString();
                this.NomeCurso = row["nome_curso"].ToString();
                this.NomeModalidade = row["nome_modalidade"].ToString();
                this.NomeDisciplina = row["nome_disciplina"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoReserva(int? p_Idreserva
                     , DateTime p_Data
                     , DateTime p_Inicio
                     , DateTime p_Fim
                     , int p_IdSala
                     , string p_NomeSala
                     , int? p_IdUsuario
                     , string p_NomeUsuario
                     , int? p_IdCasa
                     , string p_NomeCasa
                     , string p_NomeCurso
                     , string p_NomeModalidade
                     , string p_NomeDisciplina)
        {
            try
            {
                this.IdReserva = p_Idreserva;
                this.Data = p_Data;
                this.Entrada = p_Inicio;
                this.Saida = p_Fim;
                this.IdSala = p_IdSala;
                this.NomeSala = p_NomeSala;
                this.IdUsuario = p_IdUsuario;
                this.NomeUsuario = p_NomeUsuario;
                this.IdCasa = p_IdCasa;
                this.NomeCasa = p_NomeCasa;
                this.NomeCurso = p_NomeCurso;
                this.NomeModalidade = p_NomeModalidade;
                this.NomeDisciplina = p_NomeDisciplina;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoReserva()
        {
        }
        #endregion CONSTRUCTORS
    }
}
