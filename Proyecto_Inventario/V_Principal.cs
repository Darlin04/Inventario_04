using C.presentacion;
using C_entidad;
using Proyecto_Inventario;

namespace VentanaPrincipal
{
    public partial class V_Principal : Form
    {
        V_Ventas v_Inventario;
        V_Estadisticas v_Estadisticas;
        V_AgregarEditar v_AgregarEditar;
        V_Configuracion v_Configuracion;
        E_Usuario usuario;
        V_login login;

        private List<Form> ventanasHijas;

        public V_Principal(E_Usuario usuario)
        {
            InitializeComponent();
            MaximizeBox = false; // Evita la opción de maximizar el formulario
            FormBorderStyle = FormBorderStyle.FixedDialog; // Bloquea el cambio de tamaño del formulario
            v_AgregarEditar = new V_AgregarEditar(usuario);
            v_Configuracion = new V_Configuracion(usuario);
            v_Estadisticas = new V_Estadisticas(usuario);
            v_Inventario = new V_Ventas(usuario);
            login = new V_login();
            ventanasHijas = new List<Form>();
            this.usuario = usuario;
        }

        public void status()
        {
            if (usuario.status == "General")
            {
                btnConfiguracion.Visible = false;
            }
        }

        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            ocultarVentanas();
            login.Show();
            this.Hide();
        }

        private void btnVerInventarioVentana_Click(object sender, EventArgs e)
        {
            ocultarVentanas();
            MostrarFormularioEnPanel(v_Inventario);
            v_Inventario.ListarProductos();
        }

        private void V_Principal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MostrarFormularioEnPanel(v_Inventario);
            status();
        }

        private void btnEstadisticasVtn_Click(object sender, EventArgs e)
        {
            ocultarVentanas();
            MostrarFormularioEnPanel(v_Estadisticas);

        }

        private void V_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ocultarVentanas();
            Application.Exit();
        }

        private void btnAgregarEditarVentana_Click(object sender, EventArgs e)
        {
            ocultarVentanas();
            v_AgregarEditar.MdiParent = this;
            MostrarFormularioEnPanel(v_AgregarEditar);

        }

        public void ocultarVentanas()
        {
            ventanasHijas.Add(v_Inventario);
            ventanasHijas.Add(v_Estadisticas);
            ventanasHijas.Add(v_AgregarEditar);
            ventanasHijas.Add(v_Configuracion);
            ventanasHijas.Add(login);

            foreach (Form ventanaHija in ventanasHijas)
            {
                ventanaHija.Hide();
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ocultarVentanas();
            MostrarFormularioEnPanel(v_Configuracion);
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            panelPrincipal.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            panelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }
    }
}