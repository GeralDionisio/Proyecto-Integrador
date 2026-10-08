namespace Proyecto_Integrador
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            groupBox1 = new GroupBox();
            dvgProductosDisponible = new DataGridView();
            label7 = new Label();
            groupBox2 = new GroupBox();
            dvgDetalleVenta = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            groupBox3 = new GroupBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label14 = new Label();
            lblCambio = new Label();
            txtRecibido = new TextBox();
            label10 = new Label();
            label11 = new Label();
            lblTotalaPagar = new Label();
            label8 = new Label();
            lblSubtotal = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label12 = new Label();
            btnRecargar = new FontAwesome.Sharp.IconButton();
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            BtnAgarrarCantidad = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnHerramientas = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label9 = new Label();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            lblUsuario = new Label();
            pictureBox3 = new PictureBox();
            label15 = new Label();
            panel6 = new Panel();
            label21 = new Label();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblFecha1 = new Label();
            label19 = new Label();
            lblRol = new Label();
            label17 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosDisponible).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVenta).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(dvgProductosDisponible);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(19, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 500);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dvgProductosDisponible
            // 
            dvgProductosDisponible.AllowUserToAddRows = false;
            dvgProductosDisponible.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductosDisponible.BackgroundColor = Color.LightSkyBlue;
            dvgProductosDisponible.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosDisponible.Location = new Point(6, 41);
            dvgProductosDisponible.Name = "dvgProductosDisponible";
            dvgProductosDisponible.RowHeadersWidth = 51;
            dvgProductosDisponible.Size = new Size(566, 442);
            dvgProductosDisponible.TabIndex = 11;
            dvgProductosDisponible.CellClick += dvgProductosDisponible_CellClick;
            dvgProductosDisponible.CellContentClick += dvgProductosDisponible_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(7, 18);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 16;
            label7.Text = "Productos Disponibles";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgDetalleVenta);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(615, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 500);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // dvgDetalleVenta
            // 
            dvgDetalleVenta.AllowUserToAddRows = false;
            dvgDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDetalleVenta.BackgroundColor = Color.LightSkyBlue;
            dvgDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { IdProducto });
            dvgDetalleVenta.Location = new Point(7, 41);
            dvgDetalleVenta.Name = "dvgDetalleVenta";
            dvgDetalleVenta.RowHeadersWidth = 51;
            dvgDetalleVenta.Size = new Size(635, 442);
            dvgDetalleVenta.TabIndex = 15;
            dvgDetalleVenta.CellContentClick += dvgDetalleVenta_CellContentClick;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 14;
            label3.Text = "Detalle de Venta";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.BackColor = SystemColors.HotTrack;
            btnFinalizarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenta.ForeColor = SystemColors.Window;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnFinalizarVenta.IconColor = SystemColors.Window;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(1272, 271);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(202, 60);
            btnFinalizarVenta.TabIndex = 12;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(489, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(490, 27);
            txtBuscar.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblCambio);
            groupBox3.Controls.Add(txtRecibido);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(lblTotalaPagar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblSubtotal);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(1269, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 251);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(87, 137);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(103, 27);
            txtCantidad.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(6, 144);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 16;
            label2.Text = "Cantidad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(7, 0);
            label14.Name = "label14";
            label14.Size = new Size(134, 20);
            label14.TabIndex = 16;
            label14.Text = "Resumen de Pago";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(85, 108);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(17, 20);
            lblCambio.TabIndex = 19;
            lblCambio.Text = "0";
            // 
            // txtRecibido
            // 
            txtRecibido.Location = new Point(87, 170);
            txtRecibido.Name = "txtRecibido";
            txtRecibido.Size = new Size(105, 27);
            txtRecibido.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(7, 173);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 16;
            label10.Text = "Recibido:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(8, 108);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 18;
            label11.Text = "Cambio:";
            // 
            // lblTotalaPagar
            // 
            lblTotalaPagar.AutoSize = true;
            lblTotalaPagar.Location = new Point(137, 74);
            lblTotalaPagar.Name = "lblTotalaPagar";
            lblTotalaPagar.Size = new Size(17, 20);
            lblTotalaPagar.TabIndex = 15;
            lblTotalaPagar.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(7, 74);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 15;
            label8.Text = "Total a Pagar:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(137, 44);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(17, 20);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(7, 44);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "Subtotal:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnEliminarProducto);
            panel1.Controls.Add(BtnAgarrarCantidad);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnFinalizarVenta);
            panel1.Location = new Point(298, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1552, 569);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(19, 5);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 18;
            label1.Text = "Registrar Nuevas Ventas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(19, 36);
            label12.Name = "label12";
            label12.Size = new Size(350, 20);
            label12.TabIndex = 19;
            label12.Text = "elige los productos que el cliente ocupe en la venta";
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.HotTrack;
            btnRecargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecargar.ForeColor = SystemColors.Window;
            btnRecargar.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnRecargar.IconColor = SystemColors.Window;
            btnRecargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRecargar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecargar.Location = new Point(1274, 463);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(200, 58);
            btnRecargar.TabIndex = 17;
            btnRecargar.Text = "Ver Reportes Ventas";
            btnRecargar.TextAlign = ContentAlignment.MiddleRight;
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.HotTrack;
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.Window;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarProducto.IconColor = SystemColors.Window;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarProducto.Location = new Point(1272, 401);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(202, 56);
            btnEliminarProducto.TabIndex = 16;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // BtnAgarrarCantidad
            // 
            BtnAgarrarCantidad.BackColor = SystemColors.HotTrack;
            BtnAgarrarCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgarrarCantidad.ForeColor = SystemColors.Window;
            BtnAgarrarCantidad.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            BtnAgarrarCantidad.IconColor = SystemColors.Window;
            BtnAgarrarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgarrarCantidad.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgarrarCantidad.Location = new Point(1272, 336);
            BtnAgarrarCantidad.Name = "BtnAgarrarCantidad";
            BtnAgarrarCantidad.Size = new Size(202, 59);
            BtnAgarrarCantidad.TabIndex = 15;
            BtnAgarrarCantidad.Text = "Agarrar Cantidad";
            BtnAgarrarCantidad.TextAlign = ContentAlignment.MiddleRight;
            BtnAgarrarCantidad.UseVisualStyleBackColor = false;
            BtnAgarrarCantidad.Click += BtnAgarrarCantidad_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = SystemColors.HotTrack;
            BtnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = SystemColors.Window;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = SystemColors.Window;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1004, 10);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 51);
            BtnBuscar.TabIndex = 17;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(btnHerramientas);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label15);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 675);
            panel2.TabIndex = 20;
            // 
            // btnHerramientas
            // 
            btnHerramientas.BackColor = SystemColors.MenuHighlight;
            btnHerramientas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHerramientas.ForeColor = SystemColors.Control;
            btnHerramientas.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            btnHerramientas.IconColor = Color.White;
            btnHerramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHerramientas.ImageAlign = ContentAlignment.MiddleLeft;
            btnHerramientas.Location = new Point(9, 417);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(284, 58);
            btnHerramientas.TabIndex = 29;
            btnHerramientas.Text = "Herramientas";
            btnHerramientas.UseVisualStyleBackColor = false;
            btnHerramientas.Click += btnHerramientas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(61, 237);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 7;
            label6.Text = "Pulperia Oscar Gamez N2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(175, 217);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 6;
            label4.Text = "de Inventario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(35, 217);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 5;
            label9.Text = "Sistema de Gestion";
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.MenuHighlight;
            btnInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.Snow;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnInventario.IconColor = Color.White;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(9, 344);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(284, 67);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.MenuHighlight;
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = SystemColors.ControlLightLight;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btnInicio.IconColor = Color.White;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(9, 279);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(284, 59);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(129, 570);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "User";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 533);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(129, 546);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 10;
            label15.Text = "Usuarios:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Controls.Add(label21);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(298, 634);
            panel6.Name = "panel6";
            panel6.Size = new Size(1552, 41);
            panel6.TabIndex = 21;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Window;
            label21.Location = new Point(22, 12);
            label21.Name = "label21";
            label21.Size = new Size(164, 20);
            label21.TabIndex = 15;
            label21.Text = "Inicio - Nuevas Ventas";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(BtnBuscar);
            panel3.Controls.Add(txtBuscar);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(lblFecha1);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(lblRol);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnCerrarSesion);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(298, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1552, 67);
            panel3.TabIndex = 22;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(196, 9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(6, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // lblFecha1
            // 
            lblFecha1.AutoSize = true;
            lblFecha1.ForeColor = SystemColors.Control;
            lblFecha1.Location = new Point(258, 39);
            lblFecha1.Name = "lblFecha1";
            lblFecha1.Size = new Size(77, 20);
            lblFecha1.TabIndex = 11;
            lblFecha1.Text = "31/5/2026";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(258, 15);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 11;
            label19.Text = "Fecha:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(70, 39);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 11;
            lblRol.Text = "Administrador";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(70, 15);
            label17.Name = "label17";
            label17.Size = new Size(34, 20);
            label17.TabIndex = 11;
            label17.Text = "Rol:";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.Highlight;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(1379, 7);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(161, 50);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1850, 675);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosDisponible).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVenta).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dvgProductosDisponible;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
        private DataGridView dvgDetalleVenta;
        private Label label3;
        private TextBox txtBuscar;
        private GroupBox groupBox3;
        private Label label5;
        private Label lblSubtotal;
        private Label label8;
        private Label lblTotalaPagar;
        private Label label11;
        private TextBox txtRecibido;
        private Label label10;
        private Label label14;
        private Label lblCambio;
        private Label label7;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnAgarrarCantidad;
        private Label label2;
        private TextBox txtCantidad;
        private DataGridViewTextBoxColumn IdProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnRecargar;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnHerramientas;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Label lblUsuario;
        private PictureBox pictureBox3;
        private Label label15;
        private Panel panel6;
        private Label label21;
        private Panel panel3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label lblFecha1;
        private Label label19;
        private Label lblRol;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Label label1;
        private Label label12;
    }
}