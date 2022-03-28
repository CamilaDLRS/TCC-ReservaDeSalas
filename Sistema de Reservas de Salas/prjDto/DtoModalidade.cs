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
    /// Author:         Pereira, Lucas
    /// Create date:    01/06/2017
    /// Description:    Database Transference Object - Casa
    /// Public  
    /// Error control:  Exceções são elevadas ao método chamador
    ///                 Mensagens de erro são registradas na biblioteca de classe prjBll
    /// Classe baseada no projeto 'prjCRUD13' de Gilmar Trevisan                
    /// =======================================================================
    /// </summary>
    public class DtoModalidade
    {
        #region PROPERTIES

        public int? IdModalidade { get; set; }
        public string NomeModalidade { get; set; }
        public int IdCasa { get; set; }
        public string NomeCasa { get; set; }


        #endregion PROPERTIES

        #region CONSTRUCTORS
        public DtoModalidade(DataRow row)
        {

            try
            {
                this.IdModalidade = int.Parse(row["id_modalidade"].ToString());
                this.NomeModalidade = row["nome_modalidade"].ToString();
                this.IdCasa = int.Parse(row["id_casa"].ToString());
                this.NomeCasa = row["nome_casa"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoModalidade(int? p_IdModalidade
                     , string p_NomeModalidade
                     , int p_IdCasa
                     , string p_NomeCasa)
        {
            try
            {
                this.IdModalidade = p_IdModalidade;
                this.NomeModalidade = p_NomeModalidade;
                this.IdCasa = p_IdCasa;
                this.NomeCasa = p_NomeCasa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoModalidade()
        {
        }
        #endregion CONSTRUCTORS
    }
}
