using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
    public class DtoCasa
    {
        #region PROPERTIES
        public int? IdCasa { get; set; }
        public string NomeCasa { get; set; }               

        #endregion PROPERTIES

        #region CONSTRUCTORS
        public DtoCasa(DataRow row)
        {
            try
            {   this.IdCasa = int.Parse(row["id_casa"].ToString());
                this.NomeCasa = row["nome_casa"].ToString();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoCasa(int? p_IdCasa
                     , string p_NomeCasa)
        {
            try
            {
                this.IdCasa = p_IdCasa;
                this.NomeCasa = p_NomeCasa;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoCasa()
        {
        }       
        #endregion CONSTRUCTORS
    }
}
