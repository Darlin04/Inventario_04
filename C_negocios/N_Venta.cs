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
    public class N_Venta
    {
        public D_Venta objdato;
        public E_producto producto;

        public N_Venta()
        {
            objdato = new D_Venta();
            producto = new E_producto();
        }

        public void N_validarVenta(E_Venta venta)
        {
            objdato.ValidarVenta(venta);
        }
    }
}
