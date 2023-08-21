namespace VentanaPrincipal
{
    partial class V_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnConfiguracion = new Button();
            btnCerrarSeccion = new Button();
            btnAgregarEditarVentana = new Button();
            btnEstadisticasVtn = new Button();
            btnStock = new Button();
            panelPrincipal = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnCerrarSeccion);
            panel1.Controls.Add(btnAgregarEditarVentana);
            panel1.Controls.Add(btnEstadisticasVtn);
            panel1.Controls.Add(btnStock);
            panel1.Location = new Point(42, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 747);
            panel1.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracion.Location = new Point(18, 473);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(307, 74);
            btnConfiguracion.TabIndex = 4;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnCerrarSeccion
            // 
            btnCerrarSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSeccion.Location = new Point(18, 369);
            btnCerrarSeccion.Name = "btnCerrarSeccion";
            btnCerrarSeccion.Size = new Size(307, 74);
            btnCerrarSeccion.TabIndex = 3;
            btnCerrarSeccion.Text = "Cerrar Sección";
            btnCerrarSeccion.UseVisualStyleBackColor = true;
            btnCerrarSeccion.Click += btnCerrarSeccion_Click;
            // 
            // btnAgregarEditarVentana
            // 
            btnAgregarEditarVentana.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarEditarVentana.Location = new Point(18, 265);
            btnAgregarEditarVentana.Name = "btnAgregarEditarVentana";
            btnAgregarEditarVentana.Size = new Size(307, 74);
            btnAgregarEditarVentana.TabIndex = 2;
            btnAgregarEditarVentana.Text = "Agregar o Editar";
            btnAgregarEditarVentana.UseVisualStyleBackColor = true;
            btnAgregarEditarVentana.Click += btnAgregarEditarVentana_Click;
            // 
            // btnEstadisticasVtn
            // 
            btnEstadisticasVtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadisticasVtn.Location = new Point(18, 157);
            btnEstadisticasVtn.Name = "btnEstadisticasVtn";
            btnEstadisticasVtn.Size = new Size(307, 74);
            btnEstadisticasVtn.TabIndex = 1;
            btnEstadisticasVtn.Text = "Estadisticas";
            btnEstadisticasVtn.UseVisualStyleBackColor = true;
            btnEstadisticasVtn.Click += btnEstadisticasVtn_Click;
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.Location = new Point(18, 55);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(307, 74);
            btnStock.TabIndex = 0;
            btnStock.Text = "Ventas";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnVerInventarioVentana_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelPrincipal.BackColor = SystemColors.ButtonFace;
            panelPrincipal.Location = new Point(-8, -2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1746, 813);
            panelPrincipal.TabIndex = 1;
            // 
            // V_Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1732, 807);
            Controls.Add(panel1);
            Controls.Add(panelPrincipal);
            IsMdiContainer = true;
            Name = "V_Principal";
            Text = "Ventana Principal";
            FormClosing += V_Principal_FormClosing;
            Load += V_Principal_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelPrincipal;
        private Button btnStock;
        private Button btnAgregarEditarVentana;
        private Button btnEstadisticasVtn;
        private Button button1;
        private Button btnCerrarSeccion;
        private Button btnConfiguracion;
    }
}