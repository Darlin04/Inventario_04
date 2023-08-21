using System.Data;
using System.Windows.Forms;
using VentanaPrincipal;
using C_negocios;
using static C.presentacion.V_AgregarEditar;
using C.presentacion;
using C_entidad;

namespace Proyecto_Inventario
{
    public partial class V_login : Form
    {
        private N_Usuario UsuarioN;
        private E_Usuario usuario;

        public V_login()
        {
            InitializeComponent();
            UsuarioN = new N_Usuario();
            usuario = new E_Usuario();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            BuscarContacto();
        }

        private void V_login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtContrasena.UseSystemPasswordChar = true;
        }

        private void V_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void BuscarContacto()
        {
            string criterio = "usuario";
            string valorUsuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable = UsuarioN.loginValidacion(criterio, valorUsuario);
            bool entradaValidacion = true;


            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos debidamente");
                entradaValidacion = false;
            }

            if (dataTable.Rows.Count == 1 && entradaValidacion == true) // Si el usuario existe
            {
                // Guardar en variables        
                usuario.nombre = dataTable.Rows[0]["usuario"].ToString();
                usuario.contraseña = dataTable.Rows[0]["contrasena"].ToString();
                usuario.status = dataTable.Rows[0]["status"].ToString();


                if (usuario.contraseña != null) // Si la contraseña existe
                {
                    // Credenciales correctas
                    this.Hide();

                    V_Principal ventanaPrincipal = new V_Principal(usuario);
                    ventanaPrincipal.Show();
                }
                else
                {
                    // Contraseña incorrecta
                    MessageBox.Show("Contraseña o usuario incorrecto");
                }
            }
            else if (entradaValidacion == true)
            {
                // Usuario no existente
                MessageBox.Show("Usuario inexistente");

            }

        }
    }
}