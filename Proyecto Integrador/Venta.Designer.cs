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
            groupBox2 = new GroupBox();
            dvgDetalleVenta = new DataGridView();
            label3 = new Label();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            groupBox3 = new GroupBox();
            label14 = new Label();
            lblCambio = new Label();
            label11 = new Label();
            txtRecibido = new TextBox();
            label10 = new Label();
            lblTotalaPagar = new Label();
            label8 = new Label();
            lblSubtotal = new Label();
            label5 = new Label();
            label12 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgProductosDisponible).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVenta).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(dvgProductosDisponible);
            groupBox1.Location = new Point(15, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 406);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // dvgProductosDisponible
            // 
            dvgProductosDisponible.AllowUserToAddRows = false;
            dvgProductosDisponible.BackgroundColor = Color.LightSkyBlue;
            dvgProductosDisponible.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosDisponible.Location = new Point(6, 26);
            dvgProductosDisponible.Name = "dvgProductosDisponible";
            dvgProductosDisponible.RowHeadersWidth = 51;
            dvgProductosDisponible.Size = new Size(460, 374);
            dvgProductosDisponible.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgDetalleVenta);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(539, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(581, 262);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // dvgDetalleVenta
            // 
            dvgDetalleVenta.AllowUserToAddRows = false;
            dvgDetalleVenta.BackgroundColor = Color.LightSkyBlue;
            dvgDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetalleVenta.Location = new Point(7, 54);
            dvgDetalleVenta.Name = "dvgDetalleVenta";
            dvgDetalleVenta.RowHeadersWidth = 51;
            dvgDetalleVenta.Size = new Size(568, 202);
            dvgDetalleVenta.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 23);
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
            btnFinalizarVenta.Location = new Point(744, 472);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(176, 60);
            btnFinalizarVenta.TabIndex = 12;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(15, 66);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(472, 27);
            txtBuscar.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblCambio);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtRecibido);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblTotalaPagar);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblSubtotal);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(577, 334);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(477, 115);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(7, 0);
            label14.Name = "label14";
            label14.Size = new Size(134, 20);
            label14.TabIndex = 16;
            label14.Text = "Resumen de Pago";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Location = new Point(280, 74);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(17, 20);
            lblCambio.TabIndex = 19;
            lblCambio.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(208, 74);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 18;
            label11.Text = "Cambio:";
            // 
            // txtRecibido
            // 
            txtRecibido.Location = new Point(283, 41);
            txtRecibido.Name = "txtRecibido";
            txtRecibido.Size = new Size(188, 27);
            txtRecibido.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(208, 44);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 16;
            label10.Text = "Recibido:";
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
            label5.Location = new Point(7, 44);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(165, 45);
            label12.Name = "label12";
            label12.Size = new Size(320, 20);
            label12.TabIndex = 15;
            label12.Text = "Selecciona los productos y complete la venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 109);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 16;
            label7.Text = "Productos Disponibles";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnFinalizarVenta);
            panel1.Controls.Add(txtBuscar);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 561);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 17;
            label2.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(165, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 19;
            label1.Text = "Nueva Venta";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = SystemColors.Window;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleRight;
            btnRegresar.Location = new Point(1041, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(122, 60);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += iconButton1_Click;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1175, 665);
            Controls.Add(btnRegresar);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgProductosDisponible).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVenta).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label12;
        private Label label14;
        private Label lblCambio;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private Label label2;
        private Label label1;
    }
}