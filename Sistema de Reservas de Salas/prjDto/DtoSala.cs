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
    public class DtoSala
    {
        #region PROPERTIES
        public int? IdSala { get; set; }
        public string NomeSala { get; set; }
        public string Informacoes{ get; set; }
        public bool Status { get; set; }
        #endregion PROPERTIES

        #region CONSTRUCTORS
        public DtoSala(DataRow row)
        {
            try
            {
                this.IdSala = int.Parse(row["id_sala"].ToString());
                this.NomeSala = row["nome_sala"].ToString();
                this.Informacoes = row["informacoes"].ToString();

                bool blnStatus = false;
                Boolean.TryParse(row["status"].ToString(), out blnStatus);
                this.Status = blnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoSala(int? p_IdSala
                     , string p_NomeSala
                     , bool p_Status
                     , string p_Informacoes)
        {
            try
            {
                this.IdSala = p_IdSala;
                this.NomeSala = p_NomeSala;
                this.Status = p_Status;
                this.Informacoes = p_Informacoes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoSala()
        {
        }
        #endregion CONSTRUCTORS
    }
}
