namespace Proyecto_Integrador
{
    partial class ZonaDelTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZonaDelTrabajador));
            panel1 = new Panel();
            btnReporteVentasCerradas = new FontAwesome.Sharp.IconButton();
            pictureBox5 = new PictureBox();
            txtProductosbuscar = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            groupBox5 = new GroupBox();
            btnHerramientas = new FontAwesome.Sharp.IconButton();
            btnReporteDeVentas = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblNombreUsuario = new Label();
            lblRolUsuario = new Label();
            lblHora = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dvgProductos = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dvgDetalleProducto = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            btnAgarrarProducto = new FontAwesome.Sharp.IconButton();
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            txtRecibidoCliente = new TextBox();
            txtCantidad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            lblCambio = new Label();
            lblTotalPagar = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleProducto).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnReporteVentasCerradas);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(txtProductosbuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(btnHerramientas);
            panel1.Controls.Add(btnReporteDeVentas);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1645, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnReporteVentasCerradas
            // 
            btnReporteVentasCerradas.BackColor = SystemColors.HotTrack;
            btnReporteVentasCerradas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteVentasCerradas.ForeColor = Color.White;
            btnReporteVentasCerradas.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            btnReporteVentasCerradas.IconColor = Color.White;
            btnReporteVentasCerradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporteVentasCerradas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteVentasCerradas.Location = new Point(1239, 8);
            btnReporteVentasCerradas.Name = "btnReporteVentasCerradas";
            btnReporteVentasCerradas.Size = new Size(231, 59);
            btnReporteVentasCerradas.TabIndex = 21;
            btnReporteVentasCerradas.Text = "Reporte Ventas Cerradas";
            btnReporteVentasCerradas.TextAlign = ContentAlignment.MiddleRight;
            btnReporteVentasCerradas.UseVisualStyleBackColor = false;
            btnReporteVentasCerradas.Click += btnReporteVentasCerradas_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-2, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(90, 81);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // txtProductosbuscar
            // 
            txtProductosbuscar.Location = new Point(190, 26);
            txtProductosbuscar.Name = "txtProductosbuscar";
            txtProductosbuscar.Size = new Size(510, 27);
            txtProductosbuscar.TabIndex = 11;
            txtProductosbuscar.TextChanged += textBox4_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(721, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 58);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += iconButton8_Click;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(353, 104);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 51);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            // 
            // btnHerramientas
            // 
            btnHerramientas.BackColor = SystemColors.HotTrack;
            btnHerramientas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHerramientas.ForeColor = Color.White;
            btnHerramientas.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            btnHerramientas.IconColor = Color.White;
            btnHerramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHerramientas.ImageAlign = ContentAlignment.MiddleLeft;
            btnHerramientas.Location = new Point(1480, 6);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(155, 60);
            btnHerramientas.TabIndex = 5;
            btnHerramientas.Text = "Herramientas";
            btnHerramientas.TextAlign = ContentAlignment.MiddleRight;
            btnHerramientas.UseVisualStyleBackColor = false;
            btnHerramientas.Click += iconButton4_Click_1;
            // 
            // btnReporteDeVentas
            // 
            btnReporteDeVentas.BackColor = SystemColors.HotTrack;
            btnReporteDeVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteDeVentas.ForeColor = Color.White;
            btnReporteDeVentas.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnReporteDeVentas.IconColor = Color.White;
            btnReporteDeVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporteDeVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteDeVentas.Location = new Point(1031, 7);
            btnReporteDeVentas.Name = "btnReporteDeVentas";
            btnReporteDeVentas.Size = new Size(202, 62);
            btnReporteDeVentas.TabIndex = 5;
            btnReporteDeVentas.Text = "Reportes de ventas";
            btnReporteDeVentas.TextAlign = ContentAlignment.MiddleRight;
            btnReporteDeVentas.UseVisualStyleBackColor = false;
            btnReporteDeVentas.Click += btnReporteDeVentas_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.HotTrack;
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(918, 7);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(104, 62);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.Highlight;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(1475, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(156, 48);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(lblNombreUsuario);
            panel2.Controls.Add(lblRolUsuario);
            panel2.Controls.Add(lblHora);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 699);
            panel2.Name = "panel2";
            panel2.Size = new Size(1645, 51);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(589, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(365, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(220, 17);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(59, 20);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "Usuario";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.White;
            lblRolUsuario.Location = new Point(442, 17);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(31, 20);
            lblRolUsuario.TabIndex = 4;
            lblRolUsuario.Text = "Rol";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(738, 18);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(17, 20);
            lblHora.TabIndex = 3;
            lblHora.Text = "0";
            lblHora.Click += MiRelojTick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(637, 18);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 2;
            label6.Text = "Hora Y Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(410, 17);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 1;
            label5.Text = "Rol:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 17);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 0;
            label4.Text = "Nombre De Usuario:";
            // 
            // dvgProductos
            // 
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductos.BackgroundColor = Color.LightSkyBlue;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Location = new Point(6, 26);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(568, 488);
            dvgProductos.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvgProductos);
            groupBox1.Location = new Point(374, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 529);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgDetalleProducto);
            groupBox2.Location = new Point(967, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 529);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Productos";
            // 
            // dvgDetalleProducto
            // 
            dvgDetalleProducto.AllowUserToAddRows = false;
            dvgDetalleProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDetalleProducto.BackgroundColor = Color.LightSkyBlue;
            dvgDetalleProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetalleProducto.Columns.AddRange(new DataGridViewColumn[] { IdProducto });
            dvgDetalleProducto.Location = new Point(10, 26);
            dvgDetalleProducto.Name = "dvgDetalleProducto";
            dvgDetalleProducto.RowHeadersWidth = 51;
            dvgDetalleProducto.Size = new Size(620, 488);
            dvgDetalleProducto.TabIndex = 0;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = SystemColors.HotTrack;
            btnFinalizarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenta.ForeColor = Color.White;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnFinalizarVenta.IconColor = Color.White;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(69, 32);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(182, 74);
            btnFinalizarVenta.TabIndex = 5;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // btnAgarrarProducto
            // 
            btnAgarrarProducto.BackColor = SystemColors.HotTrack;
            btnAgarrarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgarrarProducto.ForeColor = Color.White;
            btnAgarrarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAgarrarProducto.IconColor = Color.White;
            btnAgarrarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgarrarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgarrarProducto.Location = new Point(69, 112);
            btnAgarrarProducto.Name = "btnAgarrarProducto";
            btnAgarrarProducto.Size = new Size(182, 70);
            btnAgarrarProducto.TabIndex = 6;
            btnAgarrarProducto.Text = "Agarrar Producto";
            btnAgarrarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnAgarrarProducto.UseVisualStyleBackColor = false;
            btnAgarrarProducto.Click += btnAgarrarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.HotTrack;
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminarProducto.IconColor = Color.White;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.Location = new Point(69, 188);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(182, 71);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtRecibidoCliente);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblCambio);
            groupBox3.Controls.Add(lblTotalPagar);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label1);
            groupBox3.ForeColor = SystemColors.Desktop;
            groupBox3.Location = new Point(4, 151);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 241);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de la venta";
            // 
            // txtRecibidoCliente
            // 
            txtRecibidoCliente.Location = new Point(157, 165);
            txtRecibidoCliente.Name = "txtRecibidoCliente";
            txtRecibidoCliente.Size = new Size(163, 27);
            txtRecibidoCliente.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(177, 127);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(143, 27);
            txtCantidad.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(9, 166);
            label11.Name = "label11";
            label11.Size = new Size(150, 20);
            label11.TabIndex = 5;
            label11.Text = "Recibido del Cliente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(9, 130);
            label10.Name = "label10";
            label10.Size = new Size(168, 20);
            label10.TabIndex = 4;
            label10.Text = "Cantidad del producto:";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.ForeColor = SystemColors.Highlight;
            lblCambio.Location = new Point(79, 90);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(17, 20);
            lblCambio.TabIndex = 3;
            lblCambio.Text = "0";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.ForeColor = SystemColors.Highlight;
            lblTotalPagar.Location = new Point(115, 50);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(17, 20);
            lblTotalPagar.TabIndex = 2;
            lblTotalPagar.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(9, 90);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 1;
            label7.Text = "Cambio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(9, 50);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Total a pagar:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnFinalizarVenta);
            groupBox4.Controls.Add(btnEliminarProducto);
            groupBox4.Controls.Add(btnAgarrarProducto);
            groupBox4.Location = new Point(4, 398);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 280);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Acciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(4, 92);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 10;
            label2.Text = "Registrar Nueva Venta";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(4, 112);
            label12.Name = "label12";
            label12.Size = new Size(350, 20);
            label12.TabIndex = 20;
            label12.Text = "elige los productos que el cliente ocupe en la venta";
            // 
            // ZonaDelTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1645, 750);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZonaDelTrabajador";
            Text = "ZonaDelTrabajador";
            Load += ZonaDelTrabajador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDetalleProducto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Panel panel2;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lblHora;
        private Label lblNombreUsuario;
        private Label lblRolUsuario;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnReporteDeVentas;
        private FontAwesome.Sharp.IconButton btnHerramientas;
        private DataGridView dvgProductos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dvgDetalleProducto;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
        private FontAwesome.Sharp.IconButton btnAgarrarProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label label7;
        private Label lblCambio;
        private Label lblTotalPagar;
        private TextBox txtRecibidoCliente;
        private TextBox txtCantidad;
        private Label label11;
        private Label label10;
        private TextBox txtProductosbuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private GroupBox groupBox5;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label12;
        private DataGridViewTextBoxColumn IdProducto;
        private FontAwesome.Sharp.IconButton btnReporteVentasCerradas;
    }
}