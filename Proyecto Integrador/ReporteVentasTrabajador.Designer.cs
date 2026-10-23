namespace Proyecto_Integrador
{
    partial class ReporteVentasTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasTrabajador));
            panel1 = new Panel();
            dvgDetalleVentas = new DataGridView();
            dvgVentasrealizadas = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgVentasrealizadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dvgDetalleVentas);
            panel1.Controls.Add(dvgVentasrealizadas);
            panel1.Location = new Point(34, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 597);
            panel1.TabIndex = 0;
            // 
            // dvgDetalleVentas
            // 
            dvgDetalleVentas.AllowUserToAddRows = false;
            dvgDetalleVentas.BackgroundColor = Color.LightSkyBlue;
            dvgDetalleVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetalleVentas.Location = new Point(602, 56);
            dvgDetalleVentas.Name = "dvgDetalleVentas";
            dvgDetalleVentas.RowHeadersWidth = 51;
            dvgDetalleVentas.Size = new Size(542, 518);
            dvgDetalleVentas.TabIndex = 1;
            dvgDetalleVentas.CellClick += dvgDetalleVentas_CellClick;
            // 
            // dvgVentasrealizadas
            // 
            dvgVentasrealizadas.AllowUserToAddRows = false;
            dvgVentasrealizadas.BackgroundColor = Color.LightSkyBlue;
            dvgVentasrealizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVentasrealizadas.Location = new Point(30, 56);
            dvgVentasrealizadas.Name = "dvgVentasrealizadas";
            dvgVentasrealizadas.RowHeadersWidth = 51;
            dvgVentasrealizadas.Size = new Size(524, 518);
            dvgVentasrealizadas.TabIndex = 0;
            dvgVentasrealizadas.CellClick += dvgVentasrealizadas_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 16);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "Reporte De Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 36);
            label2.Name = "label2";
            label2.Size = new Size(382, 20);
            label2.TabIndex = 2;
            label2.Text = "Aqui se observara las ventas realizadas dentro del dia";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = Color.White;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(1091, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 65);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ReporteVentasTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1238, 715);
            Controls.Add(btnRegresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "ReporteVentasTrabajador";
            Text = "ReporteVentasTrabajador";
            Load += ReporteVentasTrabajador_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgVentasrealizadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private DataGridView dvgDetalleVentas;
        private DataGridView dvgVentasrealizadas;
    }
}