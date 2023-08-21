using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Datos.BD;
using C_entidad;
using MySql.Data.MySqlClient;

namespace C_Datos
{
    public class D_Venta
    {
        private Conexion Iconexion;

        public D_Venta()
        {
            Iconexion = Conexion.Instancia();
        }

        public DataTable ValidarVenta(E_Venta venta)
        {
            MySqlCommand cmd = new MySqlCommand("ValidarVenta", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_usuario", venta.usuario);
            cmd.Parameters.AddWithValue("@cadena_entrada", venta.cadena);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
