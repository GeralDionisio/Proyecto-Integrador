namespace Proyecto_Integrador
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            txtUsuario = new TextBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            btnSalir1 = new FontAwesome.Sharp.IconButton();
            btnIngresar1 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            checkBox2 = new CheckBox();
            txtClave2 = new TextBox();
            txtUsuario1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga_removebg_preview_negate1;
            pictureBox1.Location = new Point(18, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 140);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(26, 65);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(423, 34);
            txtClave.TabIndex = 4;
            txtClave.UseSystemPasswordChar = true;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(117, 85);
            label3.Name = "label3";
            label3.Size = new Size(191, 38);
            label3.TabIndex = 7;
            label3.Text = "Iniciar Sesión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(8, 379);
            label4.Name = "label4";
            label4.Size = new Size(331, 28);
            label4.TabIndex = 8;
            label4.Text = "Sistema De Gestion De Inventario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(40, 407);
            label5.Name = "label5";
            label5.Size = new Size(253, 28);
            label5.TabIndex = 9;
            label5.Text = "Pulperia Oscar Gamez N2";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 616);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(402, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 460);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 228);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Recordarme";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.HotTrack;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            btnIngresar.IconColor = Color.White;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.ImageAlign = ContentAlignment.MiddleRight;
            btnIngresar.Location = new Point(124, 259);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(191, 51);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Highlight;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = SystemColors.Highlight;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(133, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(191, 47);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(26, 171);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(423, 34);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(145, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalir1);
            groupBox2.Controls.Add(btnIngresar1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(txtClave2);
            groupBox2.Controls.Add(txtUsuario1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(362, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 421);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // btnSalir1
            // 
            btnSalir1.BackColor = Color.White;
            btnSalir1.ForeColor = SystemColors.Highlight;
            btnSalir1.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSalir1.IconColor = SystemColors.Highlight;
            btnSalir1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir1.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir1.Location = new Point(88, 351);
            btnSalir1.Name = "btnSalir1";
            btnSalir1.Size = new Size(232, 54);
            btnSalir1.TabIndex = 7;
            btnSalir1.Text = "Salir";
            btnSalir1.UseVisualStyleBackColor = false;
            btnSalir1.Click += btnSalir1_Click;
            // 
            // btnIngresar1
            // 
            btnIngresar1.BackColor = SystemColors.Highlight;
            btnIngresar1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar1.ForeColor = SystemColors.ControlLightLight;
            btnIngresar1.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnIngresar1.IconColor = SystemColors.ControlLightLight;
            btnIngresar1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar1.ImageAlign = ContentAlignment.BottomLeft;
            btnIngresar1.Location = new Point(88, 287);
            btnIngresar1.Name = "btnIngresar1";
            btnIngresar1.Size = new Size(232, 58);
            btnIngresar1.TabIndex = 6;
            btnIngresar1.Text = "Ingresar";
            btnIngresar1.UseVisualStyleBackColor = false;
            btnIngresar1.Click += btnIngresar1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 225);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 5;
            label8.Text = "¿Olvido Su Contraseña?";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.Desktop;
            checkBox2.Location = new Point(6, 224);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Recordarme";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtClave2
            // 
            txtClave2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave2.Location = new Point(6, 171);
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(398, 38);
            txtClave2.TabIndex = 3;
            txtClave2.UseSystemPasswordChar = true;
            // 
            // txtUsuario1
            // 
            txtUsuario1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario1.Location = new Point(6, 65);
            txtUsuario1.Name = "txtUsuario1";
            txtUsuario1.Size = new Size(398, 38);
            txtUsuario1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(6, 148);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 1;
            label7.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(6, 42);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 0;
            label6.Text = "Usuario:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(362, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(422, 133);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(805, 616);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InicioSesion";
            Text = "Inicio De Sesion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtClave;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private TextBox txtUsuario;
        private CheckBox checkBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnIngresar1;
        private Label label8;
        private CheckBox checkBox2;
        private TextBox txtClave2;
        private TextBox txtUsuario1;
        private Label label7;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnSalir1;
        private GroupBox groupBox3;
    }
}
