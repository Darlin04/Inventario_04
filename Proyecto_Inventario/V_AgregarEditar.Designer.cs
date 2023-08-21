namespace C.presentacion
{
    partial class V_AgregarEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            txtVentas = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            tbnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            label8 = new Label();
            txtBuscar = new TextBox();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            label11 = new Label();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 199);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 4;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(146, 202);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(248, 31);
            txtCodigo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 256);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 256);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 31);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 312);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 8;
            label3.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(146, 313);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(248, 31);
            txtStock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 377);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 10;
            label4.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(146, 377);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(248, 31);
            txtMarca.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 495);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 12;
            label5.Text = "Ventas";
            // 
            // txtVentas
            // 
            txtVentas.Location = new Point(146, 495);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(248, 31);
            txtVentas.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(505, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(735, 482);
            dataGridView1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(146, 87);
            label6.Name = "label6";
            label6.Size = new Size(289, 48);
            label6.TabIndex = 14;
            label6.Text = "Agregar o editar";
            // 
            // tbnGuardar
            // 
            tbnGuardar.Location = new Point(146, 585);
            tbnGuardar.Name = "tbnGuardar";
            tbnGuardar.Size = new Size(112, 34);
            tbnGuardar.TabIndex = 15;
            tbnGuardar.Text = "Guardar";
            tbnGuardar.UseVisualStyleBackColor = true;
            tbnGuardar.Click += tbnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(282, 585);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1128, 656);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(892, 83);
            label7.Name = "label7";
            label7.Size = new Size(293, 48);
            label7.TabIndex = 18;
            label7.Text = "Datos historicos.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(497, 100);
            label8.Name = "label8";
            label8.Size = new Size(88, 32);
            label8.TabIndex = 20;
            label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(591, 100);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(264, 31);
            txtBuscar.TabIndex = 19;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(146, 87);
            label9.Name = "label9";
            label9.Size = new Size(281, 48);
            label9.TabIndex = 14;
            label9.Text = "Agregar o editar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(892, 83);
            label10.Name = "label10";
            label10.Size = new Size(281, 48);
            label10.TabIndex = 18;
            label10.Text = "Datos historicos.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(1099, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(1182, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 32);
            lblUsuario.TabIndex = 48;
            lblUsuario.Text = "Darlin";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(37, 438);
            label11.Name = "label11";
            label11.Size = new Size(79, 32);
            label11.TabIndex = 50;
            label11.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(146, 438);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(248, 31);
            txtPrecio.TabIndex = 49;
            // 
            // V_AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1279, 747);
            Controls.Add(label11);
            Controls.Add(txtPrecio);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(tbnGuardar);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtVentas);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_AgregarEditar";
            Text = "Form1";
            TopMost = true;
            Load += V_AgregarEditar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtVentas;
        private DataGridView dataGridView1;
        private Label label6;
        private Button tbnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label7;
        private Label label8;
        private TextBox txtBuscar;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label label11;
        private TextBox txtPrecio;
    }
}