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
            label3 = new Label();
            label4 = new Label();
            dvgVentasRegistradas = new DataGridView();
            label22 = new Label();
            dvgProductos = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox1 = new GroupBox();
            lblTotalVentas = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label1 = new Label();
            txtBuscarSalida = new TextBox();
            BtnBuscarSalida = new FontAwesome.Sharp.IconButton();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dvgVentasRegistradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(32, 20);
            label3.Name = "label3";
            label3.Size = new Size(214, 31);
            label3.TabIndex = 9;
            label3.Text = "Ventas Registradas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(32, 51);
            label4.Name = "label4";
            label4.Size = new Size(246, 20);
            label4.TabIndex = 10;
            label4.Text = "Consulta todas las ventas realizadas";
            // 
            // dvgVentasRegistradas
            // 
            dvgVentasRegistradas.AllowUserToAddRows = false;
            dvgVentasRegistradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgVentasRegistradas.BackgroundColor = Color.LightSkyBlue;
            dvgVentasRegistradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVentasRegistradas.Location = new Point(7, 38);
            dvgVentasRegistradas.Name = "dvgVentasRegistradas";
            dvgVentasRegistradas.RowHeadersWidth = 51;
            dvgVentasRegistradas.Size = new Size(436, 447);
            dvgVentasRegistradas.TabIndex = 12;
            dvgVentasRegistradas.CellClick += dvgVentasRegistradas_CellClick;
            dvgVentasRegistradas.CellContentClick += dvgVentasRegistradas_CellContentClick;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.HotTrack;
            label22.Location = new Point(6, 15);
            label22.Name = "label22";
            label22.Size = new Size(151, 20);
            label22.TabIndex = 15;
            label22.Text = "Detalle del Producto";
            // 
            // dvgProductos
            // 
            dvgProductos.AllowUserToAddRows = false;
            dvgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgProductos.BackgroundColor = Color.LightSkyBlue;
            dvgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductos.Location = new Point(6, 38);
            dvgProductos.Name = "dvgProductos";
            dvgProductos.RowHeadersWidth = 51;
            dvgProductos.Size = new Size(445, 441);
            dvgProductos.TabIndex = 16;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dvgProductos);
            groupBox4.Controls.Add(label22);
            groupBox4.Location = new Point(476, 74);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(459, 485);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalVentas);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Location = new Point(960, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 248);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVentas.ForeColor = SystemColors.HotTrack;
            lblTotalVentas.Location = new Point(9, 222);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(18, 20);
            lblTotalVentas.TabIndex = 28;
            lblTotalVentas.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 119);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 28;
            label8.Text = "Datos Registrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(37, 182);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 30;
            label7.Text = "Informacion de la venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(22, 158);
            label5.Name = "label5";
            label5.Size = new Size(207, 20);
            label5.TabIndex = 28;
            label5.Text = "Presiona La filas para sacar la ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._15376012;
            pictureBox3.Location = new Point(25, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(178, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dvgVentasRegistradas);
            groupBox2.Location = new Point(12, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 491);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(6, 15);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 29;
            label9.Text = "Total de Ventas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(39, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 581);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(192, 18);
            label12.Name = "label12";
            label12.Size = new Size(344, 20);
            label12.TabIndex = 29;
            label12.Text = "Se podran observar las ventas que se realizaron ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(192, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 31;
            label1.Text = "anteriormente";
            // 
            // txtBuscarSalida
            // 
            txtBuscarSalida.Location = new Point(557, 31);
            txtBuscarSalida.Name = "txtBuscarSalida";
            txtBuscarSalida.Size = new Size(431, 27);
            txtBuscarSalida.TabIndex = 32;
            // 
            // BtnBuscarSalida
            // 
            BtnBuscarSalida.BackColor = SystemColors.HotTrack;
            BtnBuscarSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarSalida.ForeColor = SystemColors.Window;
            BtnBuscarSalida.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarSalida.IconColor = SystemColors.Window;
            BtnBuscarSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarSalida.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarSalida.Location = new Point(1008, 18);
            BtnBuscarSalida.Name = "BtnBuscarSalida";
            BtnBuscarSalida.Size = new Size(100, 51);
            BtnBuscarSalida.TabIndex = 33;
            BtnBuscarSalida.Text = "Buscar";
            BtnBuscarSalida.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscarSalida.UseVisualStyleBackColor = false;
            BtnBuscarSalida.Click += BtnBuscarSalida_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.Highlight;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = Color.White;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(1165, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 57);
            btnRegresar.TabIndex = 34;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // MenuPrincipalVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1318, 702);
            Controls.Add(btnRegresar);
            Controls.Add(BtnBuscarSalida);
            Controls.Add(txtBuscarSalida);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipalVenta";
            Text = "MenuPrincipalVenta";
            Load += MenuPrincipalVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dvgVentasRegistradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductos).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private DataGridView dvgVentasRegistradas;
        private Label label22;
        private DataGridView dvgProductos;
        private GroupBox groupBox4;
        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label8;
        private Label lblTotalVentas;
        private GroupBox groupBox2;
        private Label label9;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label1;
        private TextBox txtBuscarSalida;
        private FontAwesome.Sharp.IconButton BtnBuscarSalida;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}