namespace Proyecto_Integrador
{
    partial class ActualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarUsuario));
            panel1 = new Panel();
            label10 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dvgUsuarios = new DataGridView();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            txtNombreCompleto = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCorreoElectronico = new TextBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            label9 = new Label();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            btnDesactivarUsuario = new FontAwesome.Sharp.IconButton();
            btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtContraseñaActual = new TextBox();
            groupBox2 = new GroupBox();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            cbRol = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 599);
            panel1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(46, 341);
            label10.Name = "label10";
            label10.Size = new Size(175, 20);
            label10.TabIndex = 3;
            label10.Text = "Se encuentra disponible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 321);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 2;
            label2.Text = "Y poder desactivarlo si no ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(44, 301);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 1;
            label4.Text = "Usuario dentro del sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 281);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 1;
            label3.Text = "Podran Actualizar los datos del";
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
            label1.Location = new Point(33, 199);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 1;
            label1.Text = "Editor de Usuario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dvgUsuarios);
            groupBox1.Location = new Point(321, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 233);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dvgUsuarios
            // 
            dvgUsuarios.BackgroundColor = Color.LightSkyBlue;
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.Location = new Point(6, 19);
            dvgUsuarios.Name = "dvgUsuarios";
            dvgUsuarios.RowHeadersWidth = 51;
            dvgUsuarios.Size = new Size(787, 208);
            dvgUsuarios.TabIndex = 5;
            dvgUsuarios.CellClick += dvgUsuarios_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 28);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 5;
            label5.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(327, 52);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(288, 27);
            txtNombreUsuario.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(663, 52);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(288, 27);
            txtNombreCompleto.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 28);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 8;
            label6.Text = "Nombre Completo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 171);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 9;
            label7.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(327, 194);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(288, 27);
            txtCorreoElectronico.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(660, 104);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 11;
            label8.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(663, 127);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(288, 27);
            txtTelefono.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(663, 171);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 13;
            label9.Text = "Rol";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            btnActualizar.IconColor = Color.White;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(157, 26);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(132, 57);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarUsuario
            // 
            btnDesactivarUsuario.BackColor = Color.Red;
            btnDesactivarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesactivarUsuario.ForeColor = Color.White;
            btnDesactivarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            btnDesactivarUsuario.IconColor = Color.White;
            btnDesactivarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDesactivarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesactivarUsuario.Location = new Point(468, 26);
            btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            btnDesactivarUsuario.Size = new Size(188, 58);
            btnDesactivarUsuario.TabIndex = 16;
            btnDesactivarUsuario.Text = "Desactivar Usuario";
            btnDesactivarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnDesactivarUsuario.UseVisualStyleBackColor = false;
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
            btnLimpiarCampos.Location = new Point(295, 26);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(167, 58);
            btnLimpiarCampos.TabIndex = 17;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(327, 104);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 18;
            label11.Text = "Contraseña Actual";
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Location = new Point(327, 127);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(288, 27);
            txtContraseñaActual.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegresar);
            groupBox2.Controls.Add(btnDesactivarUsuario);
            groupBox2.Controls.Add(btnLimpiarCampos);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Location = new Point(321, 493);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 94);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
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
            btnRegresar.Location = new Point(662, 26);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(123, 56);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Administrador", "Trabajador" });
            cbRol.Location = new Point(663, 194);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(288, 28);
            cbRol.TabIndex = 21;
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 599);
            Controls.Add(cbRol);
            Controls.Add(groupBox2);
            Controls.Add(txtContraseñaActual);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(txtTelefono);
            Controls.Add(label8);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ActualizarUsuario";
            Text = "ActualizarUsuario";
            Load += ActualizarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dvgUsuarios;
        private Label label5;
        private TextBox txtNombreUsuario;
        private TextBox txtNombreCompleto;
        private Label label6;
        private Label label7;
        private TextBox txtCorreoElectronico;
        private Label label8;
        private TextBox txtTelefono;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnDesactivarUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private Label label10;
        private Label label11;
        private TextBox txtContraseñaActual;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private ComboBox cbRol;
    }
}