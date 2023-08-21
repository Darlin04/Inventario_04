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
    public partial class V_Configuracion : Form
    {
        N_Usuario usuarioN;
        E_Usuario usuario;
        public V_Configuracion(E_Usuario usuario)
        {
            InitializeComponent();
            usuarioN = new N_Usuario();
            this.usuario = usuario;
        }

        private void V_Configuracion_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Location = new Point(425, 30); // X=200, Y=100
            ListarUsuarios();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            txtContrasena.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;

            lblUsuario.Text = usuario.nombre;
        }

        public void ListarUsuarios()
        {
            DataTable dt = usuarioN.N_listadoUsuarios();
            dataGridView1.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "¿Desea eliminar el usuario?";
            string title = "Eliminar producto";
            string codigoUsuario;


            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Eliminar contacto
                    codigoUsuario = dataGridView1.CurrentRow.Cells["usuario"].Value.ToString();
                    usuarioN.EliminarUsuario(codigoUsuario);
                    ListarUsuarios();
                    MessageBox.Show("El usuario ha sido eliminado.");
                    codigoUsuario = null;
                }
                else
                {
                    MessageBox.Show("No se ha eliminado el usuario.");
                }

            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            string status = estatus();
            if (status != null)
            {
                try
                {
                    usuario.nombre = txtUsuario.Text;
                    usuario.contraseña = txtContrasena.Text;
                    usuario.status = status;
                    usuarioN.InsertarUsuarios(usuario);
                    MessageBox.Show("Se insertó correctamente.");
                    ListarUsuarios();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
        }

        private void limpiarForm()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmar.Clear();
        }

        public string estatus()
        {
            string status; // Variable para almacenar el valor de status

            if (radioButtonAdministrador.Checked)
            {
                return status = "Administrador";
            }
            else if (radioButtonGeneral.Checked)
            {
                return status = "General";
            }
            else
            {
                MessageBox.Show("Selecione un estatus.");
                return status = null;
            }

        }
    }
}
