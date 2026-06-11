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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnMostrarProducto = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblTotalProductos = new Label();
            label12 = new Label();
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cbCategoria = new ComboBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            txtBuscarProducto = new TextBox();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dvgProductosExistencia
            // 
            dvgProductosExistencia.AllowUserToAddRows = false;
            dvgProductosExistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
            dvgProductosExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosExistencia.Location = new Point(16, 388);
            dvgProductosExistencia.Name = "dvgProductosExistencia";
            dvgProductosExistencia.RowHeadersWidth = 51;
            dvgProductosExistencia.Size = new Size(1282, 332);
            dvgProductosExistencia.TabIndex = 0;
            dvgProductosExistencia.CellClick += dvgProductosExistencia_CellClick;
            dvgProductosExistencia.CellContentClick += dvgProductosExistencia_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image__3__removebg_preview;
            pictureBox1.Location = new Point(-3, 3);
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
            label2.Location = new Point(102, 22);
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
            label3.Location = new Point(102, 42);
            label3.Name = "label3";
            label3.Size = new Size(430, 20);
            label3.TabIndex = 2;
            label3.Text = "Selecciona un producto de la lista para editar su informacion";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(btnMostrarProducto);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(btnEliminarProducto);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cbCategoria);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(dtpFechaVencimiento);
            panel2.Controls.Add(label11);
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
            panel2.Size = new Size(1311, 731);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnMostrarProducto
            // 
            btnMostrarProducto.BackColor = SystemColors.HotTrack;
            btnMostrarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarProducto.ForeColor = SystemColors.Window;
            btnMostrarProducto.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnMostrarProducto.IconColor = SystemColors.Window;
            btnMostrarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarProducto.Location = new Point(745, 263);
            btnMostrarProducto.Name = "btnMostrarProducto";
            btnMostrarProducto.Size = new Size(193, 55);
            btnMostrarProducto.TabIndex = 27;
            btnMostrarProducto.Text = "Mostrar Productos";
            btnMostrarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarProducto.UseVisualStyleBackColor = false;
            btnMostrarProducto.Click += btnMostrarProducto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(lblTotalProductos);
            groupBox1.Location = new Point(1031, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 346);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 193);
            label15.Name = "label15";
            label15.Size = new Size(220, 20);
            label15.TabIndex = 26;
            label15.Text = "Para ver y editar su informacion.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 173);
            label14.Name = "label14";
            label14.Size = new Size(239, 20);
            label14.TabIndex = 26;
            label14.Text = "Seleccione un productos de la lista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 147);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 26;
            label1.Text = "Selecciona un Producto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._11065775;
            pictureBox2.Location = new Point(28, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductos.ForeColor = SystemColors.HotTrack;
            lblTotalProductos.Location = new Point(48, 277);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(18, 20);
            lblTotalProductos.TabIndex = 21;
            lblTotalProductos.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(16, 350);
            label12.Name = "label12";
            label12.Size = new Size(138, 20);
            label12.TabIndex = 23;
            label12.Text = "Lista de Productos";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.OrangeRed;
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.Window;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarProducto.IconColor = SystemColors.Window;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.Location = new Point(745, 196);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(193, 55);
            btnEliminarProducto.TabIndex = 17;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnGuardar.IconColor = SystemColors.Window;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(745, 61);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 55);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Panaderia", "Bebidas", "Meneitos", "Comidas Congeladas", "Productos De Limpieza", "Higiene Personal" });
            cbCategoria.Location = new Point(16, 224);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(291, 28);
            cbCategoria.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Orange;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = SystemColors.Window;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(745, 129);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(193, 55);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(370, 225);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(291, 27);
            dtpFechaVencimiento.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(370, 202);
            label11.Name = "label11";
            label11.Size = new Size(165, 20);
            label11.TabIndex = 14;
            label11.Text = "Fecha de Vencimiento:";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(370, 149);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(291, 27);
            txtStockMinimo.TabIndex = 12;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(370, 84);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(291, 27);
            txtStockActual.TabIndex = 11;
            // 
            // txtPrecioActual
            // 
            txtPrecioActual.Location = new Point(16, 291);
            txtPrecioActual.Name = "txtPrecioActual";
            txtPrecioActual.Size = new Size(291, 27);
            txtPrecioActual.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(16, 152);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(291, 27);
            txtMarca.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 27);
            txtNombre.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(370, 126);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 6;
            label10.Text = "Stock Minimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(370, 61);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 5;
            label9.Text = "Stock Actual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(16, 268);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 4;
            label8.Text = "Precio Actual:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(16, 198);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 3;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(16, 129);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(16, 59);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(16, 25);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 0;
            label4.Text = "Informacion del Poducto";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.HotTrack;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.Window;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(1043, 17);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(119, 50);
            iconButton2.TabIndex = 28;
            iconButton2.Text = "Buscar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(623, 32);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 24;
            label13.Text = "Buscar Producto:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(757, 29);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(280, 27);
            txtBuscarProducto.TabIndex = 19;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
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
            btnRegresar.Location = new Point(1203, 12);
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
            ClientSize = new Size(1335, 824);
            Controls.Add(iconButton2);
            Controls.Add(btnRegresar);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscarProducto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarProducto";
            Text = "EditarProducto";
            Load += EditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvgProductosExistencia;
        private PictureBox pictureBox1;
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
        private TextBox txtBuscarProducto;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private TextBox txtStockMinimo;
        private TextBox txtStockActual;
        private TextBox txtPrecioActual;
        private TextBox txtMarca;
        private TextBox txtNombre;
        private ComboBox cbCategoria;
        private Label label12;
        private Label label13;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label15;
        private Label label14;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnMostrarProducto;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}