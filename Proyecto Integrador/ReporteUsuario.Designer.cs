namespace Proyecto_Integrador
{
    partial class ReporteUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteUsuario));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dvgReporteUsuario = new DataGridView();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgReporteUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 242);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(385, 189);
            label3.Name = "label3";
            label3.Size = new Size(423, 20);
            label3.TabIndex = 1;
            label3.Text = "Se mostrara la actividad de cada usuario dentro del sistema";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(456, 151);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 1;
            label1.Text = "Reporte De Usuario";
            // 
            // dvgReporteUsuario
            // 
            dvgReporteUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgReporteUsuario.BackgroundColor = Color.LightSkyBlue;
            dvgReporteUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgReporteUsuario.Location = new Point(12, 259);
            dvgReporteUsuario.Name = "dvgReporteUsuario";
            dvgReporteUsuario.RowHeadersWidth = 51;
            dvgReporteUsuario.Size = new Size(1162, 317);
            dvgReporteUsuario.TabIndex = 5;
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
            btnRegresar.Location = new Point(1058, 589);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(116, 54);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ReporteUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 655);
            Controls.Add(btnRegresar);
            Controls.Add(dvgReporteUsuario);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReporteUsuario";
            Text = "ReporteUsuario";
            Load += ReporteUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgReporteUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dvgReporteUsuario;
        private FontAwesome.Sharp.IconButton btnRegresar;
    }
}