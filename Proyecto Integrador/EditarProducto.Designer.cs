namespace Proyecto_Integrador
{
    partial class EditarProducto
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
            dvgProductosExistencia = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            cbCategoria = new ComboBox();
            lblTotalProductos = new Label();
            label12 = new Label();
            txtBuscarProducto = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            dtpFechaVencimiento = new DateTimePicker();
            label11 = new Label();
            txtStockMinimo = new TextBox();
            txtStockActual = new TextBox();
            txtPrecioActual = new TextBox();
            txtMarca = new TextBox();
            txtNombre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvgProductosExistencia
            // 
            dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
            dvgProductosExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosExistencia.Location = new Point(16, 99);
            dvgProductosExistencia.Name = "dvgProductosExistencia";
            dvgProductosExistencia.RowHeadersWidth = 51;
            dvgProductosExistencia.Size = new Size(403, 495);
            dvgProductosExistencia.TabIndex = 0;
            dvgProductosExistencia.CellContentClick += dvgProductosExistencia_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "Lista de Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image__3__removebg_preview;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(144, 22);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "Editar Producto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(144, 42);
            label3.Name = "label3";
            label3.Size = new Size(430, 20);
            label3.TabIndex = 2;
            label3.Text = "Selecciona un producto de la lista para editar su informacion";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(cbCategoria);
            panel2.Controls.Add(lblTotalProductos);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtBuscarProducto);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnEliminarProducto);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(dtpFechaVencimiento);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtStockMinimo);
            panel2.Controls.Add(dvgProductosExistencia);
            panel2.Controls.Add(txtStockActual);
            panel2.Controls.Add(txtPrecioActual);
            panel2.Controls.Add(txtMarca);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 626);
            panel2.TabIndex = 3;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Panaderia", "Bebidas", "Meneitos", "Comidas Congeladas", "Productos De Limpieza", "Higiene Personal" });
            cbCategoria.Location = new Point(442, 240);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(291, 28);
            cbCategoria.TabIndex = 22;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Location = new Point(160, 597);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(17, 20);
            lblTotalProductos.TabIndex = 21;
            lblTotalProductos.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 597);
            label12.Name = "label12";
            label12.Size = new Size(138, 20);
            label12.TabIndex = 20;
            label12.Text = "Total De Productos:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(16, 52);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(403, 27);
            txtBuscarProducto.TabIndex = 19;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Orange;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = SystemColors.Window;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.Location = new Point(568, 560);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 57);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.OrangeRed;
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.Window;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarProducto.IconColor = SystemColors.Window;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.ImageAlign = ContentAlignment.BottomRight;
            btnEliminarProducto.Location = new Point(684, 560);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(123, 57);
            btnEliminarProducto.TabIndex = 17;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnGuardar.IconColor = SystemColors.Window;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(442, 560);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 60);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(442, 508);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(291, 27);
            dtpFechaVencimiento.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(442, 485);
            label11.Name = "label11";
            label11.Size = new Size(157, 20);
            label11.TabIndex = 14;
            label11.Text = "Fecha de Vencimiento:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(442, 446);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(291, 27);
            txtStockMinimo.TabIndex = 12;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(442, 381);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(291, 27);
            txtStockActual.TabIndex = 11;
            // 
            // txtPrecioActual
            // 
            txtPrecioActual.Location = new Point(442, 310);
            txtPrecioActual.Name = "txtPrecioActual";
            txtPrecioActual.Size = new Size(291, 27);
            txtPrecioActual.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(442, 169);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(291, 27);
            txtMarca.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(442, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 27);
            txtNombre.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 423);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 6;
            label10.Text = "Stock Minimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 358);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 5;
            label9.Text = "Stock Actual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 287);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 4;
            label8.Text = "Precio Actual:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 217);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 3;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 146);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 2;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 76);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(442, 29);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 0;
            label4.Text = "Informacion del Poducto";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = SystemColors.Window;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.TopRight;
            btnRegresar.Location = new Point(774, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 60);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += iconButton4_Click;
            // 
            // EditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(912, 719);
            Controls.Add(btnRegresar);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "EditarProducto";
            Text = "EditarProducto";
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvgProductosExistencia;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox2;
        private DateTimePicker dtpFechaVencimiento;
        private Label label11;
        private TextBox textBox6;
        private TextBox textBox5;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblTotalProductos;
        private Label label12;
        private TextBox txtBuscarProducto;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private TextBox txtStockMinimo;
        private TextBox txtStockActual;
        private TextBox txtPrecioActual;
        private TextBox txtMarca;
        private TextBox txtNombre;
        private ComboBox cbCategoria;
    }
}