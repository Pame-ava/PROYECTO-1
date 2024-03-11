using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_1
{
    class conexion
    {
        public SqlConnection ccn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public void conectado()
        {
            ccn = new SqlConnection("Data Source=DESKTOP-N2FM8BS;Initial Catalog=usuarios;integrated security=true");
            ccn.Open();

        }

    }
}
