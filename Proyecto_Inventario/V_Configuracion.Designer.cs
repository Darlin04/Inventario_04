namespace C.presentacion
{
    partial class V_Configuracion
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
            panel1 = new Panel();
            btnRegistrarme = new Button();
            radioButtonGeneral = new RadioButton();
            radioButtonAdministrador = new RadioButton();
            label4 = new Label();
            txtConfirmar = new TextBox();
            label2 = new Label();
            txtContrasena = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnRegistrarme);
            panel1.Controls.Add(radioButtonGeneral);
            panel1.Controls.Add(radioButtonAdministrador);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtConfirmar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(84, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 478);
            panel1.TabIndex = 0;
            // 
            // btnRegistrarme
            // 
            btnRegistrarme.Location = new Point(107, 402);
            btnRegistrarme.Name = "btnRegistrarme";
            btnRegistrarme.Size = new Size(184, 45);
            btnRegistrarme.TabIndex = 15;
            btnRegistrarme.Text = "Registrar";
            btnRegistrarme.UseVisualStyleBackColor = true;
            btnRegistrarme.Click += btnRegistrarme_Click;
            // 
            // radioButtonGeneral
            // 
            radioButtonGeneral.AutoSize = true;
            radioButtonGeneral.Location = new Point(235, 281);
            radioButtonGeneral.Name = "radioButtonGeneral";
            radioButtonGeneral.Size = new Size(96, 29);
            radioButtonGeneral.TabIndex = 14;
            radioButtonGeneral.TabStop = true;
            radioButtonGeneral.Text = "General";
            radioButtonGeneral.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministrador
            // 
            radioButtonAdministrador.AutoSize = true;
            radioButtonAdministrador.Location = new Point(39, 281);
            radioButtonAdministrador.Name = "radioButtonAdministrador";
            radioButtonAdministrador.Size = new Size(151, 29);
            radioButtonAdministrador.TabIndex = 13;
            radioButtonAdministrador.TabStop = true;
            radioButtonAdministrador.Text = "Administrador";
            radioButtonAdministrador.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 179);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 12;
            label4.Text = "Confirmar C.";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(175, 176);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(201, 31);
            txtConfirmar.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 122);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(175, 119);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(201, 31);
            txtContrasena.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 68);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 8;
            label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(175, 65);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(201, 31);
            txtUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 96);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 1;
            label1.Text = "Agregar usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(524, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(650, 477);
            dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(771, 96);
            label5.Name = "label5";
            label5.Size = new Size(123, 38);
            label5.TabIndex = 3;
            label5.Text = "Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1062, 653);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(1107, 9);
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
            lblUsuario.Location = new Point(1190, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 32);
            lblUsuario.TabIndex = 48;
            lblUsuario.Text = "Darlin";
            // 
            // V_Configuracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1279, 747);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Configuracion";
            Text = "V_Configuracion";
            TopMost = true;
            Load += V_Configuracion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtConfirmar;
        private Label label2;
        private TextBox txtContrasena;
        private Label label3;
        private TextBox txtUsuario;
        private DataGridView dataGridView1;
        private Label label5;
        private RadioButton radioButtonGeneral;
        private RadioButton radioButtonAdministrador;
        private Button btnRegistrarme;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private Label lblUsuario;
    }
}