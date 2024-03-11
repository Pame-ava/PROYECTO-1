using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_1
{
    class Fusuario : conexion
    {
        public DataTable validar_usuario(Dusuario dts)
        {
            try
            {
                conectado();
                cmd = new SqlCommand("validar_usuario", ccn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usu", dts.get_usuario());
                cmd.Parameters.AddWithValue("@pass", dts.get_password());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;


            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}


