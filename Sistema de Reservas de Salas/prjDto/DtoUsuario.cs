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
    /// Description:    Database Transference Object - Usuario
    /// Public  
    /// Error control:  Exceções são elevadas ao método chamador
    ///                 Mensagens de erro são registradas na biblioteca de classe prjBll
    /// Classe baseada no projeto 'prjCRUD13' de Gilmar Trevisan                
    /// =======================================================================
    /// </summary>
    public class DtoUsuario
    {
        #region PROPERTIES

        public int? IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool? IdentificacaoAdministrador { get; set; }

        public int? IdCasa { get; set; }
        public string NomeCasa { get; set; }
        public bool? Status { get; set; }

        #endregion PROPERTIES

        #region CONSTRUCTORS       

        public DtoUsuario(DataRow row)
        {
            try
            {
                this.IdUsuario = int.Parse(row["id_usuario"].ToString());
                this.NomeUsuario = row["nome_usuario"].ToString();
                this.Login = row["login"].ToString();
                this.Senha = row["senha"].ToString();

                bool blnAdministrador = false;
                Boolean.TryParse(row["identificacao_adm"].ToString(), out blnAdministrador);
                this.IdentificacaoAdministrador = blnAdministrador;

                this.IdCasa = int.Parse(row["id_casa"].ToString());
                this.NomeCasa = row["nome_casa"].ToString();

                bool blnStatus = false;
                Boolean.TryParse(row["status"].ToString(), out blnStatus);
                this.Status = blnStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoUsuario(int? p_IdUsuario
                        , string p_NomeUsuario
                        , string p_Login
                        , string p_Senha
                        , bool? p_IdentidicacaoAdministrador
                        , int? p_IdCasa
                        , string p_NomeCasa
                        , bool? p_Status)
        {
            try
            {
                this.IdUsuario = p_IdUsuario;
                this.NomeUsuario = p_NomeUsuario;
                this.Login = p_Login;
                this.Senha = p_Senha;
                this.IdentificacaoAdministrador = p_IdentidicacaoAdministrador;

                this.IdCasa = p_IdCasa;
                this.NomeCasa = p_NomeCasa;
                this.Status = p_Status;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DtoUsuario()
        {
        }
        #endregion CONSTRUCTORS
    }
}
