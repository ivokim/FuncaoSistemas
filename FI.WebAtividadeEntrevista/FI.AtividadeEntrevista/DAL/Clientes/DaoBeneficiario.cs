using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DAL 
{
    internal class DaoBeneficiario : AcessoDados
    {
        internal long Incluir(DML.Beneficiario cliente)
        {
            List<System.Data.SqlClient.SqlParameter> parametros = new List<System.Data.SqlClient.SqlParameter>();
            parametros.Add(new System.Data.SqlClient.SqlParameter("NOME", cliente.NOME));
            parametros.Add(new System.Data.SqlClient.SqlParameter("CPF", cliente.CPF));
            parametros.Add(new System.Data.SqlClient.SqlParameter("IDCLIENTE", cliente.IDCLIENTE));
           

            DataSet ds = base.Consultar("FI_SP_IncBenefi", parametros);
            long ret = 0;
            if (ds.Tables[0].Rows.Count > 0)
                long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out ret);
            return ret;
        }
    }
}
