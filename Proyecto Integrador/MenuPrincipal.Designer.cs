namespace Proyecto_Integrador
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblFecha = new Label();
            lblRol = new Label();
            label17 = new Label();
            label11 = new Label();
            lblBienvenido = new Label();
            panel3 = new Panel();
            label5 = new Label();
            lblProductosRegistrados = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            lblBajoStock = new Label();
            label12 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            lblVentasDia = new Label();
            label7 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            label21 = new Label();
            dvgProductosBajo = new DataGridView();
            panel8 = new Panel();
            label4 = new Label();
            dvgProductosMasVendidos = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosBajo).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosMasVendidos).BeginInit();
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
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 646);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
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
            label6.Location = new Point(53, 240);
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
            label2.Location = new Point(161, 220);
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
            label1.Location = new Point(21, 220);
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
            btnVentas.Location = new Point(3, 368);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(281, 64);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseCompatibleTextRendering = true;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
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
            btnInventario.Location = new Point(3, 295);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(281, 67);
            btnInventario.TabIndex = 2;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(121, 571);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 534);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(121, 547);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 10;
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
            btnCerrarSesion.Location = new Point(855, 7);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(161, 50);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(290, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 67);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(242, 13);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(175, 7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(6, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.Control;
            lblFecha.Location = new Point(242, 37);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 20);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "31/5/2026";
            lblFecha.Click += MiReloj_Tick;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(65, 37);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 11;
            lblRol.Text = "Administrador";
            lblRol.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(67, 13);
            label17.Name = "label17";
            label17.Size = new Size(34, 20);
            label17.TabIndex = 11;
            label17.Text = "Rol:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(18, 0);
            label11.Name = "label11";
            label11.Size = new Size(283, 20);
            label11.TabIndex = 13;
            label11.Text = "Este es el resumen general del negocio!";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.ForeColor = SystemColors.HotTrack;
            lblBienvenido.Location = new Point(339, 80);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(174, 20);
            lblBienvenido.TabIndex = 9;
            lblBienvenido.Text = "¡Bienvenido, De Nuevo!";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblProductosRegistrados);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(18, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 125);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 83);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 6;
            label5.Text = "Productos Registrados";
            // 
            // lblProductosRegistrados
            // 
            lblProductosRegistrados.AutoSize = true;
            lblProductosRegistrados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductosRegistrados.Location = new Point(81, 49);
            lblProductosRegistrados.Name = "lblProductosRegistrados";
            lblProductosRegistrados.Size = new Size(18, 20);
            lblProductosRegistrados.TabIndex = 6;
            lblProductosRegistrados.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 13);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = "Total Productos";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__1__removebg_preview;
            pictureBox3.Location = new Point(3, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Location = new Point(336, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 160);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(label14);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(lblBajoStock);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(594, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(280, 125);
            panel5.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(93, 83);
            label14.Name = "label14";
            label14.Size = new Size(179, 20);
            label14.TabIndex = 9;
            label14.Text = "Productos Con Stock Bajo";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images__3__removebg_preview;
            pictureBox5.Location = new Point(3, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(84, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // lblBajoStock
            // 
            lblBajoStock.AutoSize = true;
            lblBajoStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBajoStock.Location = new Point(93, 49);
            lblBajoStock.Name = "lblBajoStock";
            lblBajoStock.Size = new Size(18, 20);
            lblBajoStock.TabIndex = 8;
            lblBajoStock.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 13);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 7;
            label12.Text = "Bajo Stock";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblVentasDia);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(304, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(261, 125);
            panel4.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(77, 83);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 9;
            label10.Text = "Total En Ventas";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images__2__removebg_preview;
            pictureBox4.Location = new Point(3, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // lblVentasDia
            // 
            lblVentasDia.AutoSize = true;
            lblVentasDia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasDia.Location = new Point(77, 49);
            lblVentasDia.Name = "lblVentasDia";
            lblVentasDia.Size = new Size(18, 20);
            lblVentasDia.TabIndex = 8;
            lblVentasDia.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 13);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 7;
            label7.Text = "Ventas Del Dia";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(0, 632);
            panel6.Name = "panel6";
            panel6.Size = new Size(1324, 79);
            panel6.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(12, 10);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 12;
            label9.Text = "Menu Principal";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Window;
            panel7.Controls.Add(label21);
            panel7.Controls.Add(dvgProductosBajo);
            panel7.Location = new Point(336, 281);
            panel7.Name = "panel7";
            panel7.Size = new Size(432, 321);
            panel7.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.HotTrack;
            label21.Location = new Point(3, 16);
            label21.Name = "label21";
            label21.Size = new Size(188, 20);
            label21.TabIndex = 11;
            label21.Text = "Productos Con Bajo Stock";
            // 
            // dvgProductosBajo
            // 
            dvgProductosBajo.AllowUserToAddRows = false;
            dvgProductosBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductosBajo.BackgroundColor = Color.LightSkyBlue;
            dvgProductosBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosBajo.Location = new Point(3, 39);
            dvgProductosBajo.Name = "dvgProductosBajo";
            dvgProductosBajo.RowHeadersWidth = 51;
            dvgProductosBajo.Size = new Size(424, 270);
            dvgProductosBajo.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Window;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(dvgProductosMasVendidos);
            panel8.Location = new Point(786, 281);
            panel8.Name = "panel8";
            panel8.Size = new Size(462, 321);
            panel8.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(181, 20);
            label4.TabIndex = 1;
            label4.Text = "Productos Mas Vendidos";
            // 
            // dvgProductosMasVendidos
            // 
            dvgProductosMasVendidos.AllowUserToAddRows = false;
            dvgProductosMasVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductosMasVendidos.BackgroundColor = Color.LightSkyBlue;
            dvgProductosMasVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosMasVendidos.Location = new Point(3, 39);
            dvgProductosMasVendidos.Name = "dvgProductosMasVendidos";
            dvgProductosMasVendidos.RowHeadersWidth = 51;
            dvgProductosMasVendidos.Size = new Size(456, 270);
            dvgProductosMasVendidos.TabIndex = 0;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1312, 671);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(groupBox1);
            Controls.Add(lblBienvenido);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosBajo).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosMasVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label11;
        private Label lblBienvenido;
        private Panel panel3;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Panel panel5;
        private Panel panel4;
        private Label label5;
        private Label lblProductosRegistrados;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label14;
        private PictureBox pictureBox5;
        private Label lblBajoStock;
        private Label label12;
        private Label label10;
        private Label lblVentasDia;
        private Label label7;
        private Panel panel6;
        private Label label17;
        private Label lblUsuario;
        private Label label15;
        private Label lblRol;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label lblFecha;
        private Panel panel7;
        private DataGridView dvgProductosBajo;
        private Label label21;
        private Panel panel8;
        private Label label4;
        private DataGridView dvgProductosMasVendidos;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label8;
    }
}