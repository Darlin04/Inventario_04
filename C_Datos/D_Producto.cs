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
    public class D_Producto 
    {
        private Conexion Iconexion;

        public D_Producto() 
        { 
            Iconexion = Conexion.Instancia();
        }
        public DataTable listar()
        {
            MySqlCommand cmd = new MySqlCommand("MostrarProductos", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable buscar(string busqueda)
        {
            MySqlCommand cmd = new MySqlCommand("BuscarProducto", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_codigo",  busqueda);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable Insertar(E_producto producto)
        {

            MySqlCommand cmd = new MySqlCommand("AgregarProducto", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_codigo", producto.codigo);
            cmd.Parameters.AddWithValue("@p_nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@p_stock", producto.stock);
            cmd.Parameters.AddWithValue("@p_marca", producto.marca);
            cmd.Parameters.AddWithValue("@p_precio", producto.precio);
            cmd.Parameters.AddWithValue("@p_Ventas", producto.ventas);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable editar(E_producto producto)
        {

            MySqlCommand cmd = new MySqlCommand("EditarProducto", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_codigo", producto.codigo);
            cmd.Parameters.AddWithValue("@p_nombre", producto.nombre);
            cmd.Parameters.AddWithValue("@p_stock", producto.stock);
            cmd.Parameters.AddWithValue("@p_marca", producto.marca);
            cmd.Parameters.AddWithValue("@p_precio", producto.precio);
            cmd.Parameters.AddWithValue("@p_Ventas", producto.ventas);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void Eliminar(string codigo)
        {
            MySqlCommand cmd = new MySqlCommand("EliminarProducto", Iconexion.getConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_codigo", codigo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
