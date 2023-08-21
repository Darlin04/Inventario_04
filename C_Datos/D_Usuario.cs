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
    
    public class D_Usuario
    {
        private Conexion Iconexion;
        public D_Usuario()
        {
            Iconexion = Conexion.Instancia();
        }

        public DataTable login(string criterio, string valor)
        {
            MySqlCommand cmd = new MySqlCommand("BuscarUsuario", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_criterio", criterio);
            cmd.Parameters.AddWithValue("@p_valor", valor);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable listarUsuarios()
        {
            MySqlCommand cmd = new MySqlCommand("MostrarUsuarios", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable InsertarUsuario(E_Usuario usuario)
        {
            MySqlCommand cmd = new MySqlCommand("AgregarUsuario", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_usuario", usuario.nombre);
            cmd.Parameters.AddWithValue("@p_contrasena", usuario.contraseña);
            cmd.Parameters.AddWithValue("@p_status", usuario.status);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void EliminarUsuario(string usuario)
        {
            MySqlCommand cmd = new MySqlCommand("sp_eliminarUsuario", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@v_usuario", usuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
