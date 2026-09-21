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
            label6 = new Label();
            btnCambiarContraseña = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtNuevaContraseña = new TextBox();
            txtConfirmacionContraseña = new TextBox();
            txtCodigoverificacion = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(btnCambiarContraseña);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNuevaContraseña);
            panel1.Controls.Add(txtConfirmacionContraseña);
            panel1.Controls.Add(txtCodigoverificacion);
            panel1.Location = new Point(21, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 388);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(185, 59);
            label6.Name = "label6";
            label6.Size = new Size(486, 20);
            label6.TabIndex = 9;
            label6.Text = "Para poderle validar la nueva contraseña, sin ella no podra cambiarla";
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
            btnCambiarContraseña.Location = new Point(193, 297);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(152, 32);
            label1.Name = "label1";
            label1.Size = new Size(548, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el codigo de verificacion digitos que enviamos a su correo electronico";
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuevaContraseña.Location = new Point(18, 142);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(553, 43);
            txtNuevaContraseña.TabIndex = 2;
            // 
            // txtConfirmacionContraseña
            // 
            txtConfirmacionContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmacionContraseña.Location = new Point(18, 230);
            txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            txtConfirmacionContraseña.Size = new Size(553, 43);
            txtConfirmacionContraseña.TabIndex = 1;
            // 
            // txtCodigoverificacion
            // 
            txtCodigoverificacion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoverificacion.Location = new Point(18, 48);
            txtCodigoverificacion.Name = "txtCodigoverificacion";
            txtCodigoverificacion.Size = new Size(553, 43);
            txtCodigoverificacion.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ConfirmacionContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(718, 522);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ConfirmacionContraseña";
            Text = "ConfirmacionContraseña";
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
    }
}