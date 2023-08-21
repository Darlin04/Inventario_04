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
using C_entidad;

namespace C.presentacion
{
    public partial class V_Ventas : Form
    {
        N_Venta VentaN;
        N_Producto ProductoN;
        E_producto entidad;
        E_Venta venta;
        E_Usuario usuario;


        public V_Ventas(E_Usuario usuario)
        {
            InitializeComponent();
            ProductoN = new N_Producto();
            VentaN = new N_Venta();
            entidad = new E_producto();
            venta = new E_Venta();
            this.usuario = usuario;

            ListarProductos();
        }

        private void V_Inventario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Location = new Point(425, 30); // X=200, Y=100
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtStock.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;

            lblUsuario.Text = usuario.nombre;
        }

        public void ListarProductos()
        {
            DataTable dt = ProductoN.N_listado();
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
            txtMarca.Text = dataGridView1.CurrentRow.Cells["marca"].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool entradaValidacion = true;


            if (ExisteCodigoEnDataGridView(txtCodigo.Text))
            {
                MessageBox.Show("El producto ya existe en el carrito.", "Advertencia", MessageBoxButtons.OK);
                return; // Salir del método
                entradaValidacion = false;
            }



            if (entradaValidacion = true)
            {
                if (llenarCampos())
                {
                    int precio = int.Parse(txtPrecio.Text);
                    int cantidad = int.Parse(txtCantidad.Text);
                    int costo = precio * cantidad;

                    dataGridView2.Rows.Add(txtCodigo.Text, txtNombre.Text, txtPrecio.Text, txtCantidad.Text, costo);
                    actualizarTotal();
                    limpiarForm();
                }
            }
        }

        private bool ExisteCodigoEnDataGridView(string codigo)
        {
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                //string cod = fila.Cells["Codigo"].Value.ToString();
                if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == codigo)
                {
                    return true; // El código ya existe en el DataGridView
                }
            }
            return false; // El código no existe en el DataGridView
        }

        private void EliminarFilaSeleccionada()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int indiceFila = dataGridView2.SelectedRows[0].Index;
                dataGridView2.Rows.RemoveAt(indiceFila);
                actualizarTotal();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el producto que desea eliminar.");
            }

            EliminarFilaSeleccionada();
        }

        private void limpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Text = "";
            txtStock.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }
        private void limpiardgv2()
        {
            dataGridView2.Rows.Clear();
        }

        private int CalcularSumaCostos()
        {
            int suma = 0;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.Cells["Costo"].Value != null)
                {
                    int valorCosto;
                    if (int.TryParse(fila.Cells["Costo"].Value.ToString(), out valorCosto))
                    {
                        suma += valorCosto;
                    }
                }
            }

            return suma;
        }

        private bool llenarCampos()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return false;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe agregarle cantidad.");
                return false;
            }
            return true;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            bool entrada = true;
            bool dgv = dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells[0].Value == null;

            if (dgv)
            {
                MessageBox.Show("Primero agregue un producto al carrito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entrada = false;
            }
            if (entrada)
            {
                validarVenta();
                limpiardgv2();
                ListarProductos();
                actualizarTotal();
            }
                
        }

        public void validarVenta()
        {
            string cadena = "";
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.Cells["Costo"].Value != null)
                {
                    string codigo = fila.Cells["codigo"].Value.ToString();
                    string cantidad = fila.Cells["Cantidad"].Value.ToString();
                    cadena += codigo + "," + cantidad + ";";
                }
            }

            venta.usuario = usuario.nombre;
            venta.cadena = cadena;
            VentaN.N_validarVenta(venta);
            MessageBox.Show("Se ha materializado la venta.");
        }

        public void actualizarTotal()
        {
            lblventaTotal.Text = "Venta total: " + CalcularSumaCostos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos(txtBuscar.Text);
        }


        void BuscarProductos(string textoFiltro)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.Clear();
            dataTable = ProductoN.N_buscar(textoFiltro);
            dataGridView1.DataSource = dataTable;
        }

    }
}
