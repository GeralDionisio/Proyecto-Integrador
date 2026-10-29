namespace Proyecto_Integrador
{
    partial class ReporteVentasCerradasTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasCerradasTrabajador));
            panel1 = new Panel();
            dvgDetalleVentasCerradas = new DataGridView();
            dvgVentasCerradas = new DataGridView();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnImprimirVentas = new FontAwesome.Sharp.IconButton();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVentasCerradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgVentasCerradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnImprimirVentas);
            panel1.Controls.Add(dvgDetalleVentasCerradas);
            panel1.Controls.Add(dvgVentasCerradas);
            panel1.Location = new Point(26, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 635);
            panel1.TabIndex = 0;
            // 
            // dvgDetalleVentasCerradas
            // 
            dvgDetalleVentasCerradas.AllowUserToAddRows = false;
            dvgDetalleVentasCerradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDetalleVentasCerradas.BackgroundColor = Color.LightSkyBlue;
            dvgDetalleVentasCerradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetalleVentasCerradas.Location = new Point(566, 43);
            dvgDetalleVentasCerradas.Name = "dvgDetalleVentasCerradas";
            dvgDetalleVentasCerradas.RowHeadersWidth = 51;
            dvgDetalleVentasCerradas.Size = new Size(524, 515);
            dvgDetalleVentasCerradas.TabIndex = 1;
            // 
            // dvgVentasCerradas
            // 
            dvgVentasCerradas.AllowUserToAddRows = false;
            dvgVentasCerradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgVentasCerradas.BackgroundColor = Color.LightSkyBlue;
            dvgVentasCerradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVentasCerradas.Location = new Point(24, 43);
            dvgVentasCerradas.Name = "dvgVentasCerradas";
            dvgVentasCerradas.RowHeadersWidth = 51;
            dvgVentasCerradas.Size = new Size(521, 515);
            dvgVentasCerradas.TabIndex = 0;
            dvgVentasCerradas.CellClick += dvgVentasCerradas_CellClick;
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
            btnRegresar.Location = new Point(1016, 6);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 76);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 21);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 4;
            label1.Text = "Las Ventas Que Fueron Cerradas Anteriormente ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(186, 41);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 5;
            label2.Text = "Se Veran aqui dentro del sistema";
            // 
            // btnImprimirVentas
            // 
            btnImprimirVentas.BackColor = SystemColors.Highlight;
            btnImprimirVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimirVentas.ForeColor = Color.White;
            btnImprimirVentas.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnImprimirVentas.IconColor = Color.White;
            btnImprimirVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimirVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimirVentas.Location = new Point(923, 562);
            btnImprimirVentas.Name = "btnImprimirVentas";
            btnImprimirVentas.Size = new Size(167, 68);
            btnImprimirVentas.TabIndex = 2;
            btnImprimirVentas.Text = "Imprimir Ventas Realizadas";
            btnImprimirVentas.TextAlign = ContentAlignment.MiddleRight;
            btnImprimirVentas.UseVisualStyleBackColor = false;
            btnImprimirVentas.Click += btnImprimirVentas_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteVentasCerradasTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1163, 735);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReporteVentasCerradasTrabajador";
            Text = "ReporteVentasCerradasTrabajador";
            Load += ReporteVentasCerradasTrabajador_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDetalleVentasCerradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgVentasCerradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dvgDetalleVentasCerradas;
        private DataGridView dvgVentasCerradas;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnImprimirVentas;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}