namespace Proyecto_Integrador
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            label15 = new Label();
            label1 = new Label();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            lblFecha = new Label();
            lblRol = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            label17 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label19 = new Label();
            txtBuscarProducto = new TextBox();
            label11 = new Label();
            dvgProductosExistencia = new DataGridView();
            label3 = new Label();
            btnAñadirProducto = new Button();
            btnPanaderia = new FontAwesome.Sharp.IconButton();
            btnBebidas = new FontAwesome.Sharp.IconButton();
            btnProductosLimpieza = new FontAwesome.Sharp.IconButton();
            btnMeneitos = new FontAwesome.Sharp.IconButton();
            btnComidasCongelada = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label4 = new Label();
            btnEditarProducto = new Button();
            btnHigienePersonal = new FontAwesome.Sharp.IconButton();
            btnTodoLosProductos = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-5, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 621);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(54, 241);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 7;
            label6.Text = "Pulperia Oscar Gamez N2";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(134, 559);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 19;
            lblUsuario.Text = "User";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(166, 221);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "de Inventario";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(134, 532);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 15;
            label15.Text = "Usuarios:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 221);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 5;
            label1.Text = "Sistema de Gestion";
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.MenuHighlight;
            btnVentas.BackgroundImageLayout = ImageLayout.None;
            btnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.Control;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnVentas.IconColor = Color.White;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(11, 344);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(284, 64);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseCompatibleTextRendering = true;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
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
            btnInicio.Location = new Point(11, 279);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(284, 59);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 521);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(BtnBuscar);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(txtBuscarProducto);
            panel1.Location = new Point(287, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 75);
            panel1.TabIndex = 3;
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
            BtnBuscar.Location = new Point(850, 14);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(100, 50);
            BtnBuscar.TabIndex = 20;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.Control;
            lblFecha.Location = new Point(252, 49);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "31/5/2026";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(71, 48);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 19;
            lblRol.Text = "Administrador";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.MenuHighlight;
            btnCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.Control;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnCerrarSesion.IconColor = Color.White;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.Location = new Point(988, 14);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(161, 50);
            btnCerrarSesion.TabIndex = 17;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(71, 21);
            label17.Name = "label17";
            label17.Size = new Size(34, 20);
            label17.TabIndex = 15;
            label17.Text = "Rol:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(12, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(190, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(252, 21);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 15;
            label19.Text = "Fecha:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(407, 26);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(437, 27);
            txtBuscarProducto.TabIndex = 5;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(330, 86);
            label11.Name = "label11";
            label11.Size = new Size(124, 31);
            label11.TabIndex = 13;
            label11.Text = "Inventario";
            label11.Click += label11_Click;
            // 
            // dvgProductosExistencia
            // 
            dvgProductosExistencia.AllowUserToAddRows = false;
            dvgProductosExistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
            dvgProductosExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosExistencia.Location = new Point(330, 209);
            dvgProductosExistencia.Name = "dvgProductosExistencia";
            dvgProductosExistencia.RowHeadersWidth = 51;
            dvgProductosExistencia.Size = new Size(1106, 315);
            dvgProductosExistencia.TabIndex = 4;
            dvgProductosExistencia.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(330, 117);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 6;
            label3.Text = "Productos en existencia";
            label3.Click += label3_Click;
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.Location = new Point(330, 530);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(122, 69);
            btnAñadirProducto.TabIndex = 7;
            btnAñadirProducto.Text = "Añadir Nuevo Producto";
            btnAñadirProducto.UseVisualStyleBackColor = true;
            btnAñadirProducto.Click += btnAñadirProducto_Click;
            // 
            // btnPanaderia
            // 
            btnPanaderia.BackColor = SystemColors.HotTrack;
            btnPanaderia.ForeColor = Color.Snow;
            btnPanaderia.IconChar = FontAwesome.Sharp.IconChar.BreadSlice;
            btnPanaderia.IconColor = Color.White;
            btnPanaderia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPanaderia.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanaderia.Location = new Point(328, 140);
            btnPanaderia.Name = "btnPanaderia";
            btnPanaderia.Size = new Size(129, 63);
            btnPanaderia.TabIndex = 11;
            btnPanaderia.Text = "Panaderia";
            btnPanaderia.TextAlign = ContentAlignment.MiddleRight;
            btnPanaderia.UseVisualStyleBackColor = false;
            btnPanaderia.Click += btnPanaderia_Click;
            // 
            // btnBebidas
            // 
            btnBebidas.BackColor = SystemColors.HotTrack;
            btnBebidas.ForeColor = SystemColors.Control;
            btnBebidas.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
            btnBebidas.IconColor = Color.White;
            btnBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBebidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBebidas.Location = new Point(457, 140);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(121, 63);
            btnBebidas.TabIndex = 12;
            btnBebidas.Text = "Bebidas";
            btnBebidas.TextAlign = ContentAlignment.MiddleRight;
            btnBebidas.UseVisualStyleBackColor = false;
            btnBebidas.Click += btnBebidas_Click;
            // 
            // btnProductosLimpieza
            // 
            btnProductosLimpieza.BackColor = SystemColors.HotTrack;
            btnProductosLimpieza.ForeColor = SystemColors.Control;
            btnProductosLimpieza.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            btnProductosLimpieza.IconColor = Color.White;
            btnProductosLimpieza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductosLimpieza.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductosLimpieza.Location = new Point(915, 139);
            btnProductosLimpieza.Name = "btnProductosLimpieza";
            btnProductosLimpieza.Size = new Size(208, 63);
            btnProductosLimpieza.TabIndex = 13;
            btnProductosLimpieza.Text = "Productos De Limpieza";
            btnProductosLimpieza.TextAlign = ContentAlignment.MiddleRight;
            btnProductosLimpieza.UseVisualStyleBackColor = false;
            btnProductosLimpieza.Click += btnProductosLimpieza_Click;
            // 
            // btnMeneitos
            // 
            btnMeneitos.BackColor = SystemColors.HotTrack;
            btnMeneitos.ForeColor = SystemColors.Window;
            btnMeneitos.IconChar = FontAwesome.Sharp.IconChar.CookieBite;
            btnMeneitos.IconColor = Color.White;
            btnMeneitos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMeneitos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeneitos.Location = new Point(584, 140);
            btnMeneitos.Name = "btnMeneitos";
            btnMeneitos.Size = new Size(124, 63);
            btnMeneitos.TabIndex = 14;
            btnMeneitos.Text = "Meneitos";
            btnMeneitos.TextAlign = ContentAlignment.MiddleRight;
            btnMeneitos.UseVisualStyleBackColor = false;
            btnMeneitos.Click += btnMeneitos_Click;
            // 
            // btnComidasCongelada
            // 
            btnComidasCongelada.BackColor = SystemColors.HotTrack;
            btnComidasCongelada.ForeColor = SystemColors.Window;
            btnComidasCongelada.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnComidasCongelada.IconColor = Color.White;
            btnComidasCongelada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComidasCongelada.ImageAlign = ContentAlignment.MiddleLeft;
            btnComidasCongelada.Location = new Point(714, 140);
            btnComidasCongelada.Name = "btnComidasCongelada";
            btnComidasCongelada.Size = new Size(195, 62);
            btnComidasCongelada.TabIndex = 15;
            btnComidasCongelada.Text = "Comidas Congeladas";
            btnComidasCongelada.TextAlign = ContentAlignment.MiddleRight;
            btnComidasCongelada.UseVisualStyleBackColor = false;
            btnComidasCongelada.Click += btnComidasCongelada_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(-2, 611);
            panel3.Name = "panel3";
            panel3.Size = new Size(1480, 83);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(9, 11);
            label4.Name = "label4";
            label4.Size = new Size(199, 20);
            label4.TabIndex = 18;
            label4.Text = "Menu Principal - Inventario";
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(465, 530);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(113, 69);
            btnEditarProducto.TabIndex = 8;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnHigienePersonal
            // 
            btnHigienePersonal.BackColor = SystemColors.HotTrack;
            btnHigienePersonal.ForeColor = SystemColors.Window;
            btnHigienePersonal.IconChar = FontAwesome.Sharp.IconChar.PumpMedical;
            btnHigienePersonal.IconColor = SystemColors.Window;
            btnHigienePersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHigienePersonal.ImageAlign = ContentAlignment.MiddleLeft;
            btnHigienePersonal.Location = new Point(1129, 139);
            btnHigienePersonal.Name = "btnHigienePersonal";
            btnHigienePersonal.Size = new Size(166, 63);
            btnHigienePersonal.TabIndex = 17;
            btnHigienePersonal.Text = "Higiene Personal";
            btnHigienePersonal.TextAlign = ContentAlignment.MiddleRight;
            btnHigienePersonal.UseVisualStyleBackColor = false;
            btnHigienePersonal.Click += btnHigienePersonal_Click;
            // 
            // btnTodoLosProductos
            // 
            btnTodoLosProductos.BackColor = SystemColors.HotTrack;
            btnTodoLosProductos.ForeColor = SystemColors.Window;
            btnTodoLosProductos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnTodoLosProductos.IconColor = SystemColors.Window;
            btnTodoLosProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTodoLosProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTodoLosProductos.Location = new Point(1301, 141);
            btnTodoLosProductos.Name = "btnTodoLosProductos";
            btnTodoLosProductos.Size = new Size(133, 62);
            btnTodoLosProductos.TabIndex = 19;
            btnTodoLosProductos.Text = " Todo los Productos";
            btnTodoLosProductos.TextAlign = ContentAlignment.MiddleRight;
            btnTodoLosProductos.UseVisualStyleBackColor = false;
            btnTodoLosProductos.Click += iconButton1_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1448, 649);
            Controls.Add(btnTodoLosProductos);
            Controls.Add(btnHigienePersonal);
            Controls.Add(panel3);
            Controls.Add(btnComidasCongelada);
            Controls.Add(btnMeneitos);
            Controls.Add(btnProductosLimpieza);
            Controls.Add(btnBebidas);
            Controls.Add(btnPanaderia);
            Controls.Add(btnEditarProducto);
            Controls.Add(label11);
            Controls.Add(btnAñadirProducto);
            Controls.Add(label3);
            Controls.Add(dvgProductosExistencia);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label11;
        private DataGridView dvgProductosExistencia;
        private TextBox txtBuscarProducto;
        private Label label3;
        private Button btnAñadirProducto;
        private FontAwesome.Sharp.IconButton btnPanaderia;
        private FontAwesome.Sharp.IconButton btnBebidas;
        private FontAwesome.Sharp.IconButton btnProductosLimpieza;
        private FontAwesome.Sharp.IconButton btnMeneitos;
        private Label label19;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Label label15;
        private FontAwesome.Sharp.IconButton btnComidasCongelada;
        private Panel panel3;
        private Button btnEditarProducto;
        private FontAwesome.Sharp.IconButton btnHigienePersonal;
        private Label label4;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label lblRol;
        private Label lblFecha;
        private FontAwesome.Sharp.IconButton btnTodoLosProductos;
        private FontAwesome.Sharp.IconButton BtnBuscar;
    }
}