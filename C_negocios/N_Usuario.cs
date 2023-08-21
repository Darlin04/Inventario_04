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
    public class N_Usuario
    {
        public D_Usuario objdato;
        public E_producto producto;

        public N_Usuario()
        {
            objdato = new D_Usuario();
            producto = new E_producto();
        }



        public DataTable loginValidacion(string criterio, string valor)
        {
            return objdato.login(criterio, valor);
        }

        public DataTable N_listadoUsuarios()
        {
            return objdato.listarUsuarios();
        }

        public DataTable InsertarUsuarios(E_Usuario usuario)
        {
            return objdato.InsertarUsuario(usuario);
        }

        public void EliminarUsuario(string usuario)
        {
            objdato.EliminarUsuario(usuario);
        }

    }
}
