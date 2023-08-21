using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_entidad;
using System.Data.SqlClient;


namespace C_Datos.BD
{
    public class Conexion : Parametros
    {
        private static Conexion instancia = null;
        private MySqlConnection conexion;
        private string CadenaConexion;
        E_producto E_mensaje;

        private Conexion()
        {
            CadenaConexion = "Database=" + database +
                "; Datasource=" + server +
                "; UserId=" + user +
                "; password=" + password;
            conexion = new MySqlConnection(CadenaConexion);
        }

        public static Conexion Instancia()
        {  
                if (instancia == null)
                {
                    instancia = new Conexion();
                }
                return instancia;
        }

        public MySqlConnection getConexion()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                E_mensaje.mensaje = (e.ToString());
            }
            return conexion;
        }

        public void CloseConexion()
        {
            conexion.Close();
        }
    }
}
