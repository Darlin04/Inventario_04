using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using C_Datos;
using C_entidad;

namespace C_negocios
{
    public class N_Producto
    {
        public D_Producto objdato;
        public E_producto producto;

        public N_Producto() 
        { 
            objdato = new D_Producto();
            producto = new E_producto();
        }
        public DataTable N_buscar(string busqueda)
        {
            return objdato.buscar(busqueda);
        }

        public DataTable N_listado()
        {
            return objdato.listar();
        }
        public DataTable InsertarProducto(E_producto producto) 
        {
            return objdato.Insertar(producto);
        }

        public DataTable EditarProducto(E_producto producto)
        {
            return objdato.editar(producto);
        }

        public void EliminarProducto(string codigo)
        {
            objdato.Eliminar(codigo);
        }
    }
}
