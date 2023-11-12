using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {
        public DataTable traerTipoVehiculos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM TipoVehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
