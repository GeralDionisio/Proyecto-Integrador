namespace Proyecto_Integrador
{
    partial class MenuPrincipalVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalVenta));
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            label21 = new Label();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblFecha1 = new Label();
            label19 = new Label();
            lblRol = new Label();
            label17 = new Label();
            lblUsuario = new Label();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnRegistrarNuevaVenta = new FontAwesome.Sharp.IconButton();
            label25 = new Label();
            dvgVentasRegistradas = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblCambio = new Label();
            lblRecibido = new Label();
            lblCliente = new Label();
            lblFecha = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label22 = new Label();
            dvgProductos = new DataGridView();
            label23 = new Label();
            lblTotalSubtotal = new Label();
            groupBox4 = new GroupBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgVentasRegistradas).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnInicio);
            panel2.Location = new Point(-7, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 646);
            panel2.TabIndex = 3;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(175, 217);
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
            label1.Location = new Point(35, 217);
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
            btnVentas.Location = new Point(14, 432);
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
            btnInventario.Location = new Point(14, 353);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(281, 67);
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
            btnInicio.Location = new Point(14, 279);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(281, 59);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Controls.Add(label21);
            panel6.Location = new Point(-10, 641);
            panel6.Name = "panel6";
            panel6.Size = new Size(1346, 89);
            panel6.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Window;
            label21.Location = new Point(22, 12);
            label21.Name = "label21";
            label21.Size = new Size(174, 20);
            label21.TabIndex = 15;
            label21.Text = "Menu Principal - Ventas";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(lblFecha1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(291, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 67);
            panel1.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.image__1__removebg_preview;
            pictureBox7.Location = new Point(405, 7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.image;
            pictureBox6.Location = new Point(215, 7);
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
            lblFecha1.Location = new Point(467, 37);
            lblFecha1.Name = "lblFecha1";
            lblFecha1.Size = new Size(77, 20);
            lblFecha1.TabIndex = 11;
            lblFecha1.Text = "31/5/2026";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(467, 13);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 11;
            label19.Text = "Fecha:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.Control;
            lblRol.Location = new Point(279, 37);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(104, 20);
            lblRol.TabIndex = 11;
            lblRol.Text = "Administrador";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(279, 13);
            label17.Name = "label17";
            label17.Size = new Size(34, 20);
            label17.TabIndex = 11;
            label17.Text = "Rol:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = SystemColors.Control;
            lblUsuario.Location = new Point(74, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 20);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "User";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(74, 13);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 10;
            label15.Text = "Usuarios:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 83);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 9;
            label3.Text = "Ventas Registradas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 105);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 10;
            label4.Text = "Consulta todas las ventas realizadas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnRegistrarNuevaVenta);
            groupBox1.Controls.Add(label25);
            groupBox1.Location = new Point(313, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 82);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 20;
            // 
            // btnRegistrarNuevaVenta
            // 
            btnRegistrarNuevaVenta.BackColor = SystemColors.HotTrack;
            btnRegistrarNuevaVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarNuevaVenta.ForeColor = SystemColors.Window;
            btnRegistrarNuevaVenta.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnRegistrarNuevaVenta.IconColor = SystemColors.Window;
            btnRegistrarNuevaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarNuevaVenta.ImageAlign = ContentAlignment.TopRight;
            btnRegistrarNuevaVenta.Location = new Point(350, 16);
            btnRegistrarNuevaVenta.Name = "btnRegistrarNuevaVenta";
            btnRegistrarNuevaVenta.Size = new Size(148, 60);
            btnRegistrarNuevaVenta.TabIndex = 23;
            btnRegistrarNuevaVenta.Text = "Nueva Venta";
            btnRegistrarNuevaVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarNuevaVenta.UseVisualStyleBackColor = false;
            btnRegistrarNuevaVenta.Click += btnRegistrarNuevaVenta_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 23);
            label25.Name = "label25";
            label25.Size = new Size(55, 20);
            label25.TabIndex = 19;
            label25.Text = "Buscar:";
            // 
            // dvgVentasRegistradas
            // 
            dvgVentasRegistradas.BackgroundColor = Color.LightSkyBlue;
            dvgVentasRegistradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVentasRegistradas.Location = new Point(313, 216);
            dvgVentasRegistradas.Name = "dvgVentasRegistradas";
            dvgVentasRegistradas.RowHeadersWidth = 51;
            dvgVentasRegistradas.Size = new Size(517, 404);
            dvgVentasRegistradas.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(1064, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(8, 8);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblCambio);
            groupBox3.Controls.Add(lblRecibido);
            groupBox3.Controls.Add(lblCliente);
            groupBox3.Controls.Add(lblFecha);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(856, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(451, 187);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(379, 150);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(17, 20);
            lblCambio.TabIndex = 21;
            lblCambio.Text = "0";
            // 
            // lblRecibido
            // 
            lblRecibido.AutoSize = true;
            lblRecibido.Location = new Point(379, 115);
            lblRecibido.Name = "lblRecibido";
            lblRecibido.Size = new Size(17, 20);
            lblRecibido.TabIndex = 20;
            lblRecibido.Text = "0";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(379, 80);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(17, 20);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "0";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(379, 48);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(17, 20);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 150);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 18;
            label11.Text = "Cambio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 115);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 17;
            label10.Text = "Recibido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 80);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 16;
            label8.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 23);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 15;
            label5.Text = "Detalle De La Venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 48);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(6, 15);
            label22.Name = "label22";
            label22.Size = new Size(80, 20);
            label22.TabIndex = 15;
            label22.Text = "Productos";
            // 
            // dvgProductos
            // 
            dvgProductos.BackgroundColor = Color.LightSkyBlue;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Location = new Point(6, 38);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(445, 188);
            dvgProductos.TabIndex = 16;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(856, 591);
            label23.Name = "label23";
            label23.Size = new Size(48, 20);
            label23.TabIndex = 17;
            label23.Text = "Total:";
            // 
            // lblTotalSubtotal
            // 
            lblTotalSubtotal.AutoSize = true;
            lblTotalSubtotal.Location = new Point(918, 591);
            lblTotalSubtotal.Name = "lblTotalSubtotal";
            lblTotalSubtotal.Size = new Size(17, 20);
            lblTotalSubtotal.TabIndex = 18;
            lblTotalSubtotal.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dvgProductos);
            groupBox4.Controls.Add(label22);
            groupBox4.Location = new Point(859, 337);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(459, 232);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            // 
            // MenuPrincipalVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 682);
            Controls.Add(groupBox4);
            Controls.Add(lblTotalSubtotal);
            Controls.Add(label23);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dvgVentasRegistradas);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Name = "MenuPrincipalVenta";
            Text = "MenuPrincipalVenta";
            Load += MenuPrincipalVenta_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgVentasRegistradas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Panel panel6;
        private Panel panel1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label lblFecha1;
        private Label label19;
        private Label lblRol;
        private Label label17;
        private Label lblUsuario;
        private Label label15;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private DataGridView dvgVentasRegistradas;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label lblCambio;
        private Label lblRecibido;
        private Label lblCliente;
        private Label lblFecha;
        private Label label11;
        private Label label10;
        private Label label21;
        private Label label22;
        private DataGridView dvgProductos;
        private Label label23;
        private Label lblTotalSubtotal;
        private TextBox textBox1;
        private Label label25;
        private FontAwesome.Sharp.IconButton btnRegistrarNuevaVenta;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private GroupBox groupBox4;
    }
}