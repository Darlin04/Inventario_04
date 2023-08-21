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
    public class D_Estadisticas
    {
        private Conexion Iconexion;
        
        public D_Estadisticas()
        {
            Iconexion = Conexion.Instancia();
        }

        public DataTable listarVentasUsuarios()
        {
            MySqlCommand cmd = new MySqlCommand("mostrarUsuariosVentas", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable listarMasVendido()
        {
            MySqlCommand cmd = new MySqlCommand("obtenerProductoMasVendido", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable listarMasMenosStock()
        {
            MySqlCommand cmd = new MySqlCommand("obtenerProductoConMenosStock", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
