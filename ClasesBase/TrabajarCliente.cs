using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarCliente
    {
        public Cliente TraerCliente(string dni)
        {
            /*SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.playaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente WHERE clienteDNI ='" + dni + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cliente ocliente = new Cliente();
            foreach (DataRow row in dt.Rows)
            {
                ocliente.nombre = row["nombre"].ToString();
                ocliente.apellido = row["apellido"].ToString();
                ocliente.telefono = row["telefono"].ToString();
            }
            return (ocliente);*/
            return new Cliente(); 
        }
       

    }
}
