namespace Proyecto_Integrador
{
    partial class ReporteVentasCerradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasCerradas));
            panel1 = new Panel();
            dvgDetallesProductosCerrados = new DataGridView();
            dvgProductosCerrados = new DataGridView();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDetallesProductosCerrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosCerrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dvgDetallesProductosCerrados);
            panel1.Controls.Add(dvgProductosCerrados);
            panel1.Location = new Point(31, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 529);
            panel1.TabIndex = 0;
            // 
            // dvgDetallesProductosCerrados
            // 
            dvgDetallesProductosCerrados.BackgroundColor = Color.LightSkyBlue;
            dvgDetallesProductosCerrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDetallesProductosCerrados.Location = new Point(566, 34);
            dvgDetallesProductosCerrados.Name = "dvgDetallesProductosCerrados";
            dvgDetallesProductosCerrados.RowHeadersWidth = 51;
            dvgDetallesProductosCerrados.Size = new Size(524, 474);
            dvgDetallesProductosCerrados.TabIndex = 1;
            // 
            // dvgProductosCerrados
            // 
            dvgProductosCerrados.BackgroundColor = Color.LightSkyBlue;
            dvgProductosCerrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductosCerrados.Location = new Point(18, 34);
            dvgProductosCerrados.Name = "dvgProductosCerrados";
            dvgProductosCerrados.RowHeadersWidth = 51;
            dvgProductosCerrados.Size = new Size(522, 474);
            dvgProductosCerrados.TabIndex = 0;
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
            btnRegresar.Location = new Point(1021, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(123, 63);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 16);
            label1.Name = "label1";
            label1.Size = new Size(345, 20);
            label1.TabIndex = 3;
            label1.Text = "Las Ventas Que Fueron Cerradas Anteriormente ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 42);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 4;
            label2.Text = "Se Veran aqui dentro del sistema";
            // 
            // ReporteVentasCerradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1171, 645);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReporteVentasCerradas";
            Text = "ReporteVentasCerradas";
            Load += ReporteVentasCerradas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDetallesProductosCerrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductosCerrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private DataGridView dvgDetallesProductosCerrados;
        private DataGridView dvgProductosCerrados;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}