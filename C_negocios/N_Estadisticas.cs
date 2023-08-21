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
    public class N_Estadisticas
    {
        public D_Estadisticas objdato;
        public E_producto producto;

        public N_Estadisticas()
        {
            objdato = new D_Estadisticas();
            producto = new E_producto();
        }

        public DataTable N_mostrarUsuariosVentas()
        {
            return objdato.listarVentasUsuarios();
        }
        public DataTable N_MasVendido()
        {
            return objdato.listarMasVendido();
        }
        public DataTable N_MenosStock()
        {
            return objdato.listarMasMenosStock();
        }
    }
}
