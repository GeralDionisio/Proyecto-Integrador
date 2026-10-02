namespace Proyecto_Integrador
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbRol = new ComboBox();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            txtNumeroTelefono = new TextBox();
            label11 = new Label();
            txtCorreoEletrónico = new TextBox();
            label10 = new Label();
            txtConfirmarContraseña = new TextBox();
            label9 = new Label();
            txtContraseña = new TextBox();
            label8 = new Label();
            txtNombreCompleto = new TextBox();
            label7 = new Label();
            txtNombreUsuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 559);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 321);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "o (Administrador)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(44, 301);
            label4.Name = "label4";
            label4.Size = new Size(218, 20);
            label4.TabIndex = 1;
            label4.Text = "dentro del sistema (Trabajador)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 281);
            label3.Name = "label3";
            label3.Size = new Size(222, 20);
            label3.TabIndex = 1;
            label3.Text = "Podra registrar un nuevo usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(58, 199);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 1;
            label1.Text = "Crear Usuario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbRol);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtNumeroTelefono);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCorreoEletrónico);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtConfirmarContraseña);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(335, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 442);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // cbRol
            // 
            cbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Administrador", "Trabajador" });
            cbRol.Location = new Point(6, 372);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(294, 36);
            cbRol.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 349);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 13;
            label12.Text = "Rol";
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroTelefono.Location = new Point(385, 283);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(294, 34);
            txtNumeroTelefono.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 261);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 11;
            label11.Text = "Numero Telefono";
            // 
            // txtCorreoEletrónico
            // 
            txtCorreoEletrónico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoEletrónico.Location = new Point(6, 283);
            txtCorreoEletrónico.Name = "txtCorreoEletrónico";
            txtCorreoEletrónico.Size = new Size(294, 34);
            txtCorreoEletrónico.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 261);
            label10.Name = "label10";
            label10.Size = new Size(132, 20);
            label10.TabIndex = 9;
            label10.Text = "Correo electrónico";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarContraseña.Location = new Point(385, 200);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(294, 34);
            txtConfirmarContraseña.TabIndex = 8;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 177);
            label9.Name = "label9";
            label9.Size = new Size(151, 20);
            label9.TabIndex = 7;
            label9.Text = "Confirmar contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(6, 200);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(294, 34);
            txtContraseña.TabIndex = 6;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 177);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 5;
            label8.Text = "Contraseña";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.Location = new Point(385, 112);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(294, 34);
            txtNombreCompleto.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 89);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 3;
            label7.Text = "Nombre Completo";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(6, 112);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(294, 34);
            txtNombreUsuario.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 89);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 1;
            label6.Text = "Nombre de usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 23);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 0;
            label5.Text = "Datos del Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLimpiarCampos);
            groupBox2.Controls.Add(btnRegresar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Location = new Point(335, 448);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(761, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.Orange;
            btnLimpiarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarCampos.IconColor = Color.White;
            btnLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarCampos.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarCampos.Location = new Point(465, 26);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(165, 54);
            btnLimpiarCampos.TabIndex = 2;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
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
            btnRegresar.Location = new Point(636, 26);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 54);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(337, 27);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 54);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 559);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            Load += CrearUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtNombreCompleto;
        private Label label7;
        private TextBox txtNombreUsuario;
        private Label label6;
        private Label label5;
        private TextBox textBox7;
        private Label label12;
        private TextBox txtNumeroTelefono;
        private Label label11;
        private TextBox txtCorreoEletrónico;
        private Label label10;
        private TextBox txtConfirmarContraseña;
        private Label label9;
        private TextBox txtContraseña;
        private Label label8;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private PictureBox pictureBox2;
        private ComboBox cbRol;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
    }
}