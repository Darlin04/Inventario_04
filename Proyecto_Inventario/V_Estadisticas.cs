using C_entidad;
using C_negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.presentacion
{
    public partial class V_Estadisticas : Form
    {
        N_Estadisticas estadisticasN;
        E_Usuario usuario;
        public V_Estadisticas(E_Usuario usuario)
        {
            InitializeComponent();
            estadisticasN = new N_Estadisticas();
            this.usuario = usuario;
        }

        private void V_Estadisticas_Load(object sender, EventArgs e)
        {
            this.Location = new Point(425, 30); // X=200, Y=100
            ListarventasUsuarios();
            MasVendido();
            MenosStock();
        }
        public void ListarventasUsuarios()
        {
            DataTable dt = estadisticasN.N_mostrarUsuariosVentas();
            dgvMvendedor.DataSource = dt;
            dgvMvendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMvendedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Cambiar color de fuente de toda la grilla
            dgvMvendedor.DefaultCellStyle.ForeColor = Color.Black;

            lblUsuario.Text = usuario.nombre;
        }
        public void MasVendido()
        {
            DataTable dt = estadisticasN.N_MasVendido();
            MasVendidoDGV.DataSource = dt;
            MasVendidoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MasVendidoDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Cambiar color de fuente de toda la grilla
            MasVendidoDGV.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void MenosStock()
        {
            DataTable dt = estadisticasN.N_MenosStock();
            StockDGV.DataSource = dt;
            StockDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StockDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Cambiar color de fuente de toda la grilla
            StockDGV.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
