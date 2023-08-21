using C_entidad;
using C_negocios;
using Proyecto_Inventario;
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
    public partial class V_AgregarEditar : Form
    {
        N_Producto ProductoN;
        E_Usuario usuario;
        E_producto producto;
        private bool Editar = false;
        private string codigoProducto = null;
        V_login v_Login;

        public V_AgregarEditar(E_Usuario usuario)
        {
            InitializeComponent();
            ProductoN = new N_Producto();
            producto = new E_producto();
            v_Login = new V_login();
            this.usuario = usuario;
        }

        private void V_AgregarEditar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(425, 30); // X=200, Y=100
            ListarProductos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            status();

            lblUsuario.Text = usuario.nombre;
        }

        public void status()
        {
            if (usuario.status == "General")
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        void BuscarProductos(string textoFiltro)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.Clear();
            dataTable = ProductoN.N_buscar(textoFiltro);
            dataGridView1.DataSource = dataTable;
        }


        public void ListarProductos()
        {
            DataTable dt = ProductoN.N_listado();
            dataGridView1.DataSource = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtVentas.Text = dataGridView1.CurrentRow.Cells["Ventas"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void tbnGuardar_Click(object sender, EventArgs e)
        {
            producto.codigo = txtCodigo.Text;
            producto.nombre = txtNombre.Text;
            producto.stock = txtStock.Text;
            producto.marca = txtMarca.Text;
            producto.precio = txtPrecio.Text;
            producto.ventas = txtVentas.Text;

            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    ProductoN.InsertarProducto(producto);
                    MessageBox.Show("Se insertó correctamente");
                    ListarProductos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    ProductoN.EditarProducto(producto);
                    MessageBox.Show("Se editó correctamente");
                    ListarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void limpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Text = "";
            txtStock.Clear();
            txtMarca.Clear();
            txtVentas.Clear();
            txtPrecio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "¿Desea eliminar el producto?";
            string title = "Eliminar producto.";

            if (codigoProducto != null)
            {
                MessageBox.Show("Primero guarde los cambios.");
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(message, title,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Eliminar contacto
                        codigoProducto = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                        ProductoN.EliminarProducto(codigoProducto);
                        ListarProductos();
                        MessageBox.Show("El producto ha sido eliminado.");
                        codigoProducto = null;
                    }
                    else
                    {
                        MessageBox.Show("No se ha eliminado el producto.");
                    }

                }
                else
                    MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos(txtBuscar.Text);
        }
    }
}
