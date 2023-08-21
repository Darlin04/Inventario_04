namespace C.presentacion
{
    partial class V_Estadisticas
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
            dgvMvendedor = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            MasVendidoDGV = new DataGridView();
            label3 = new Label();
            StockDGV = new DataGridView();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMvendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MasVendidoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StockDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvMvendedor
            // 
            dgvMvendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvendedor.Location = new Point(73, 207);
            dgvMvendedor.Name = "dgvMvendedor";
            dgvMvendedor.RowHeadersWidth = 62;
            dgvMvendedor.Size = new Size(360, 94);
            dgvMvendedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(73, 164);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 2;
            label1.Text = "Mayor Vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(73, 335);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 4;
            label2.Text = "Producto más vendido.";
            // 
            // MasVendidoDGV
            // 
            MasVendidoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasVendidoDGV.Location = new Point(73, 378);
            MasVendidoDGV.Name = "MasVendidoDGV";
            MasVendidoDGV.RowHeadersWidth = 62;
            MasVendidoDGV.Size = new Size(360, 104);
            MasVendidoDGV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(73, 514);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 6;
            label3.Text = "Menos Stock";
            // 
            // StockDGV
            // 
            StockDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockDGV.Location = new Point(73, 557);
            StockDGV.Name = "StockDGV";
            StockDGV.RowHeadersWidth = 62;
            StockDGV.Size = new Size(360, 113);
            StockDGV.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(132, 101);
            label4.Name = "label4";
            label4.Size = new Size(224, 38);
            label4.TabIndex = 7;
            label4.Text = "Datos Historicos.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(347, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(430, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 32);
            lblUsuario.TabIndex = 46;
            lblUsuario.Text = "Darlin";
            // 
            // V_Estadisticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(523, 747);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StockDGV);
            Controls.Add(label2);
            Controls.Add(MasVendidoDGV);
            Controls.Add(label1);
            Controls.Add(dgvMvendedor);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Estadisticas";
            Text = "Estadisticas";
            TopMost = true;
            Load += V_Estadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMvendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)MasVendidoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)StockDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMvendedor;
        private Label label1;
        private Label label2;
        private DataGridView MasVendidoDGV;
        private Label label3;
        private DataGridView StockDGV;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lblUsuario;
    }
}