namespace C.presentacion
{
    partial class V_Ventas
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnAgregar = new Button();
            label6 = new Label();
            label1 = new Label();
            btnVender = new Button();
            label5 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            lblventaTotal = new Label();
            label9 = new Label();
            txtPrecio = new TextBox();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            label8 = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(646, 176);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Cantidad, Costo });
            dataGridView2.Location = new Point(596, 459);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(646, 159);
            dataGridView2.TabIndex = 19;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 8;
            Costo.Name = "Costo";
            Costo.Width = 150;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1001, 652);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(140, 521);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(248, 34);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(838, 403);
            label6.Name = "label6";
            label6.Size = new Size(128, 48);
            label6.TabIndex = 22;
            label6.Text = "Carrito";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(818, 133);
            label1.Name = "label1";
            label1.Size = new Size(180, 48);
            label1.TabIndex = 23;
            label1.Text = "Productos";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(1130, 652);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(112, 34);
            btnVender.TabIndex = 25;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 456);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 36;
            label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(140, 459);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(248, 31);
            txtCantidad.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 340);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 34;
            label4.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(140, 337);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(248, 31);
            txtMarca.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 276);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 32;
            label3.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(140, 273);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(248, 31);
            txtStock.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 219);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 216);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 31);
            txtNombre.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 165);
            label7.Name = "label7";
            label7.Size = new Size(91, 32);
            label7.TabIndex = 28;
            label7.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(140, 162);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(248, 31);
            txtCodigo.TabIndex = 27;
            // 
            // lblventaTotal
            // 
            lblventaTotal.AutoSize = true;
            lblventaTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblventaTotal.Location = new Point(596, 654);
            lblventaTotal.Name = "lblventaTotal";
            lblventaTotal.Size = new Size(137, 32);
            lblventaTotal.TabIndex = 37;
            lblventaTotal.Text = "Venta Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(21, 403);
            label9.Name = "label9";
            label9.Size = new Size(79, 32);
            label9.TabIndex = 39;
            label9.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(140, 400);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(248, 31);
            txtPrecio.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(1100, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(1183, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 32);
            lblUsuario.TabIndex = 44;
            lblUsuario.Text = "Darlin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(593, 377);
            label8.Name = "label8";
            label8.Size = new Size(88, 32);
            label8.TabIndex = 46;
            label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(687, 374);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(122, 31);
            txtBuscar.TabIndex = 45;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // V_Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1279, 747);
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(label9);
            Controls.Add(txtPrecio);
            Controls.Add(lblventaTotal);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(txtCodigo);
            Controls.Add(btnVender);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(416, 31);
            Name = "V_Ventas";
            StartPosition = FormStartPosition.Manual;
            Text = "V_Inventario";
            Load += V_Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label6;
        private Label label1;
        private Button btnVender;
        private Label label5;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtStock;
        private Label label2;
        private TextBox txtNombre;
        private Label label7;
        private TextBox txtCodigo;
        private Label lblventaTotal;
        private Label label9;
        private TextBox txtPrecio;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Costo;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label label8;
        private TextBox txtBuscar;
    }
}