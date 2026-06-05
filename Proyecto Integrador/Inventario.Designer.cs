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
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblUsuario = new Label();
            label15 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            label17 = new Label();
            pictureBox6 = new PictureBox();
            label20 = new Label();
            pictureBox7 = new PictureBox();
            label19 = new Label();
            pictureBox2 = new PictureBox();
            lblRol = new Label();
            label11 = new Label();
            dvgProductosExistencia = new DataGridView();
            txtBuscarProducto = new TextBox();
            label3 = new Label();
            btnAñadirProducto = new Button();
            btnPanaderia = new FontAwesome.Sharp.IconButton();
            btnBebidas = new FontAwesome.Sharp.IconButton();
            btnProductosLimpieza = new FontAwesome.Sharp.IconButton();
            btnMeneitos = new FontAwesome.Sharp.IconButton();
            btnComidasCongelada = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnEditarProducto = new Button();
            btnHigienePersonal = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnInicio);
            panel2.Location = new Point(-5, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 621);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(48, 241);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 7;
            label6.Text = "Pulperia Oscar Gamez N2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(157, 221);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 6;
            label2.Text = "de Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 221);
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
            btnVentas.Location = new Point(11, 437);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(284, 64);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseCompatibleTextRendering = true;
            btnVentas.UseVisualStyleBackColor = false;
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
            btnInventario.Location = new Point(11, 356);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(284, 64);
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
            btnInicio.Location = new Point(12, 279);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(284, 59);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblRol);
            panel1.Location = new Point(287, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 75);
            panel1.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(74, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 18;
            lblUsuario.Text = "User";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(74, 17);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 15;
            label15.Text = "Usuarios:";
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
            btnCerrarSesion.Location = new Point(878, 15);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(161, 50);
            btnCerrarSesion.TabIndex = 17;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(215, 17);
            label17.Name = "label17";
            label17.Size = new Size(34, 20);
            label17.TabIndex = 15;
            label17.Text = "Rol:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(156, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(396, 37);
            label20.Name = "label20";
            label20.Size = new Size(77, 20);
            label20.TabIndex = 15;
            label20.Text = "31/5/2026";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(334, 10);
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
            label19.Location = new Point(396, 17);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 15;
            label19.Text = "Fecha:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(215, 37);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 9;
            lblRol.Text = "Administrador";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(332, 109);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 13;
            label11.Text = "Inventario";
            label11.Click += label11_Click;
            // 
            // dvgProductosExistencia
            // 
            dvgProductosExistencia.BackgroundColor = Color.LightSkyBlue;
            dvgProductosExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosExistencia.Location = new Point(330, 236);
            dvgProductosExistencia.Name = "dvgProductosExistencia";
            dvgProductosExistencia.RowHeadersWidth = 51;
            dvgProductosExistencia.Size = new Size(973, 278);
            dvgProductosExistencia.TabIndex = 4;
            dvgProductosExistencia.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(701, 122);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(591, 27);
            txtBuscarProducto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(332, 129);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 6;
            label3.Text = "Productos en existencia";
            label3.Click += label3_Click;
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.Location = new Point(330, 520);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(122, 69);
            btnAñadirProducto.TabIndex = 7;
            btnAñadirProducto.Text = "Añadir Nuevo Producto";
            btnAñadirProducto.UseVisualStyleBackColor = true;
            // 
            // btnPanaderia
            // 
            btnPanaderia.BackColor = SystemColors.HotTrack;
            btnPanaderia.ForeColor = Color.Snow;
            btnPanaderia.IconChar = FontAwesome.Sharp.IconChar.BreadSlice;
            btnPanaderia.IconColor = Color.White;
            btnPanaderia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPanaderia.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanaderia.Location = new Point(330, 166);
            btnPanaderia.Name = "btnPanaderia";
            btnPanaderia.Size = new Size(129, 63);
            btnPanaderia.TabIndex = 11;
            btnPanaderia.Text = "Panaderia";
            btnPanaderia.TextAlign = ContentAlignment.MiddleRight;
            btnPanaderia.UseVisualStyleBackColor = false;
            // 
            // btnBebidas
            // 
            btnBebidas.BackColor = SystemColors.HotTrack;
            btnBebidas.ForeColor = SystemColors.Control;
            btnBebidas.IconChar = FontAwesome.Sharp.IconChar.BottleWater;
            btnBebidas.IconColor = Color.White;
            btnBebidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBebidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBebidas.Location = new Point(465, 166);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(121, 63);
            btnBebidas.TabIndex = 12;
            btnBebidas.Text = "Bebidas";
            btnBebidas.TextAlign = ContentAlignment.MiddleRight;
            btnBebidas.UseVisualStyleBackColor = false;
            // 
            // btnProductosLimpieza
            // 
            btnProductosLimpieza.BackColor = SystemColors.HotTrack;
            btnProductosLimpieza.ForeColor = SystemColors.Control;
            btnProductosLimpieza.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            btnProductosLimpieza.IconColor = Color.White;
            btnProductosLimpieza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductosLimpieza.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductosLimpieza.Location = new Point(923, 166);
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
            btnMeneitos.Location = new Point(592, 167);
            btnMeneitos.Name = "btnMeneitos";
            btnMeneitos.Size = new Size(124, 63);
            btnMeneitos.TabIndex = 14;
            btnMeneitos.Text = "Meneitos";
            btnMeneitos.TextAlign = ContentAlignment.MiddleRight;
            btnMeneitos.UseVisualStyleBackColor = false;
            // 
            // btnComidasCongelada
            // 
            btnComidasCongelada.BackColor = SystemColors.HotTrack;
            btnComidasCongelada.ForeColor = SystemColors.Window;
            btnComidasCongelada.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnComidasCongelada.IconColor = Color.White;
            btnComidasCongelada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComidasCongelada.ImageAlign = ContentAlignment.MiddleLeft;
            btnComidasCongelada.Location = new Point(722, 168);
            btnComidasCongelada.Name = "btnComidasCongelada";
            btnComidasCongelada.Size = new Size(195, 62);
            btnComidasCongelada.TabIndex = 15;
            btnComidasCongelada.Text = "Comidas Congeladas";
            btnComidasCongelada.TextAlign = ContentAlignment.MiddleRight;
            btnComidasCongelada.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(-2, 611);
            panel3.Name = "panel3";
            panel3.Size = new Size(1386, 83);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(465, 520);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(113, 69);
            btnEditarProducto.TabIndex = 8;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnHigienePersonal
            // 
            btnHigienePersonal.BackColor = SystemColors.HotTrack;
            btnHigienePersonal.ForeColor = SystemColors.Window;
            btnHigienePersonal.IconChar = FontAwesome.Sharp.IconChar.PumpMedical;
            btnHigienePersonal.IconColor = SystemColors.Window;
            btnHigienePersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHigienePersonal.ImageAlign = ContentAlignment.MiddleLeft;
            btnHigienePersonal.Location = new Point(1137, 166);
            btnHigienePersonal.Name = "btnHigienePersonal";
            btnHigienePersonal.Size = new Size(166, 63);
            btnHigienePersonal.TabIndex = 17;
            btnHigienePersonal.Text = "Higiene Personal";
            btnHigienePersonal.TextAlign = ContentAlignment.MiddleRight;
            btnHigienePersonal.UseVisualStyleBackColor = false;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 125);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 18;
            label5.Text = "Buscar:";
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
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1338, 649);
            Controls.Add(label5);
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
            Controls.Add(txtBuscarProducto);
            Controls.Add(dvgProductosExistencia);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosExistencia).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label11;
        private Label lblRol;
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
        private Label label20;
        private PictureBox pictureBox6;
        private Label label17;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Label label15;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconButton btnComidasCongelada;
        private Panel panel3;
        private Button btnEditarProducto;
        private FontAwesome.Sharp.IconButton btnHigienePersonal;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}