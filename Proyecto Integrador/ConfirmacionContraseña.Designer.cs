namespace Proyecto_Integrador
{
    partial class ConfirmacionContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacionContraseña));
            panel1 = new Panel();
            btnVolverEnviarCorreo = new FontAwesome.Sharp.IconButton();
            btnCambiarContraseña = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNuevaContraseña = new TextBox();
            txtConfirmacionContraseña = new TextBox();
            txtCodigoverificacion = new TextBox();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(btnVolverEnviarCorreo);
            panel1.Controls.Add(btnCambiarContraseña);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNuevaContraseña);
            panel1.Controls.Add(txtConfirmacionContraseña);
            panel1.Controls.Add(txtCodigoverificacion);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(409, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 468);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnVolverEnviarCorreo
            // 
            btnVolverEnviarCorreo.BackColor = SystemColors.Highlight;
            btnVolverEnviarCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverEnviarCorreo.ForeColor = SystemColors.ControlLightLight;
            btnVolverEnviarCorreo.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnVolverEnviarCorreo.IconColor = Color.White;
            btnVolverEnviarCorreo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVolverEnviarCorreo.ImageAlign = ContentAlignment.MiddleLeft;
            btnVolverEnviarCorreo.Location = new Point(241, 347);
            btnVolverEnviarCorreo.Name = "btnVolverEnviarCorreo";
            btnVolverEnviarCorreo.Size = new Size(221, 58);
            btnVolverEnviarCorreo.TabIndex = 9;
            btnVolverEnviarCorreo.Text = "Volver Enviar El Correo";
            btnVolverEnviarCorreo.TextAlign = ContentAlignment.MiddleRight;
            btnVolverEnviarCorreo.UseVisualStyleBackColor = false;
            btnVolverEnviarCorreo.Click += btnVolverEnviarCorreo_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = SystemColors.Highlight;
            btnCambiarContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = SystemColors.ControlLightLight;
            btnCambiarContraseña.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnCambiarContraseña.IconColor = Color.White;
            btnCambiarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarContraseña.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiarContraseña.Location = new Point(18, 347);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(199, 58);
            btnCambiarContraseña.TabIndex = 8;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.TextAlign = ContentAlignment.MiddleRight;
            btnCambiarContraseña.UseVisualStyleBackColor = false;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 207);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 7;
            label5.Text = "Confirme la nueva contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 119);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 6;
            label4.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 25);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 5;
            label3.Text = "Codigo de verificacion";
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuevaContraseña.Location = new Point(18, 142);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(444, 43);
            txtNuevaContraseña.TabIndex = 2;
            txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmacionContraseña
            // 
            txtConfirmacionContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmacionContraseña.Location = new Point(18, 230);
            txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            txtConfirmacionContraseña.Size = new Size(444, 43);
            txtConfirmacionContraseña.TabIndex = 1;
            txtConfirmacionContraseña.UseSystemPasswordChar = true;
            // 
            // txtCodigoverificacion
            // 
            txtCodigoverificacion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoverificacion.Location = new Point(18, 48);
            txtCodigoverificacion.Name = "txtCodigoverificacion";
            txtCodigoverificacion.Size = new Size(444, 43);
            txtCodigoverificacion.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(31, 276);
            label6.Name = "label6";
            label6.Size = new Size(291, 20);
            label6.TabIndex = 9;
            label6.Text = "Para poderle validar la nueva contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 230);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el codigo de verificacion  ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 253);
            label2.Name = "label2";
            label2.Size = new Size(354, 20);
            label2.TabIndex = 10;
            label2.Text = "de 6 digitos que enviamos a su correo electrónico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 296);
            label7.Name = "label7";
            label7.Size = new Size(200, 20);
            label7.TabIndex = 11;
            label7.Text = " sin ella no podra cambiarla";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(53, 168);
            label8.Name = "label8";
            label8.Size = new Size(286, 31);
            label8.TabIndex = 12;
            label8.Text = "Validacion De Contraseña";
            // 
            // ConfirmacionContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(897, 468);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ConfirmacionContraseña";
            Text = "ConfirmacionContraseña";
            Load += ConfirmacionContraseña_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNuevaContraseña;
        private TextBox txtConfirmacionContraseña;
        private TextBox txtCodigoverificacion;
        private FontAwesome.Sharp.IconButton btnCambiarContraseña;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnVolverEnviarCorreo;
        private Label label2;
        private Label label7;
        private Label label8;
    }
}