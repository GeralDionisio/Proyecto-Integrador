namespace Proyecto_Integrador
{
    partial class OlvidoSuContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlvidoSuContraseña));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label8 = new Label();
            btnEnviarCorreo = new FontAwesome.Sharp.IconButton();
            txtCorreoElectronico = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 548);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 339);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 4;
            label6.Text = "contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 319);
            label5.Name = "label5";
            label5.Size = new Size(239, 20);
            label5.TabIndex = 3;
            label5.Text = "Para enviarle un correo de cambio ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 299);
            label4.Name = "label4";
            label4.Size = new Size(269, 20);
            label4.TabIndex = 1;
            label4.Text = "Que se encuentra asociado a su usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(265, 20);
            label3.TabIndex = 1;
            label3.Text = "Ingrese por favor su correo electronico";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-72, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 191);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 1;
            label1.Text = "Recuperacion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegresar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEnviarCorreo);
            groupBox1.Controls.Add(txtCorreoElectronico);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(382, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 477);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.Highlight;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ControlLightLight;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = Color.White;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(51, 334);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(256, 55);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar A Inicio De Sesion";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 174);
            label9.Name = "label9";
            label9.Size = new Size(255, 20);
            label9.TabIndex = 4;
            label9.Text = "o no se encuentren en ningun usuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 154);
            label8.Name = "label8";
            label8.Size = new Size(256, 20);
            label8.TabIndex = 3;
            label8.Text = "No se puede usar correo no asociado";
            // 
            // btnEnviarCorreo
            // 
            btnEnviarCorreo.BackColor = SystemColors.Highlight;
            btnEnviarCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarCorreo.ForeColor = SystemColors.ControlLightLight;
            btnEnviarCorreo.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnEnviarCorreo.IconColor = Color.White;
            btnEnviarCorreo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnviarCorreo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviarCorreo.Location = new Point(51, 274);
            btnEnviarCorreo.Name = "btnEnviarCorreo";
            btnEnviarCorreo.Size = new Size(256, 54);
            btnEnviarCorreo.TabIndex = 2;
            btnEnviarCorreo.Text = "Enviar Correo";
            btnEnviarCorreo.UseVisualStyleBackColor = false;
            btnEnviarCorreo.Click += btnEnviarCorreo_Click;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoElectronico.Location = new Point(6, 85);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(350, 51);
            txtCorreoElectronico.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 0;
            label7.Text = "Datos De Recuperacion";
            // 
            // OlvidoSuContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "OlvidoSuContraseña";
            Text = "OlvidoSuContraseña";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private Label label9;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEnviarCorreo;
        private TextBox txtCorreoElectronico;
        private Label label7;
    }
}