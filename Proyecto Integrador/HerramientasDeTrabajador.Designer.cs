namespace Proyecto_Integrador
{
    partial class HerramientasDeTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HerramientasDeTrabajador));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnCerrarVenta = new FontAwesome.Sharp.IconButton();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btnColorOscuro = new FontAwesome.Sharp.IconButton();
            btnColorVerde = new FontAwesome.Sharp.IconButton();
            btnColorMorado = new FontAwesome.Sharp.IconButton();
            btnColorAzul = new FontAwesome.Sharp.IconButton();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 331);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCerrarVenta);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Location = new Point(547, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 277);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ventas";
            // 
            // btnCerrarVenta
            // 
            btnCerrarVenta.BackColor = SystemColors.Highlight;
            btnCerrarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarVenta.ForeColor = SystemColors.ControlLightLight;
            btnCerrarVenta.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btnCerrarVenta.IconColor = Color.White;
            btnCerrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarVenta.Location = new Point(57, 198);
            btnCerrarVenta.Name = "btnCerrarVenta";
            btnCerrarVenta.Size = new Size(218, 53);
            btnCerrarVenta.TabIndex = 9;
            btnCerrarVenta.Text = "Cerrar Venta";
            btnCerrarVenta.UseVisualStyleBackColor = false;
            btnCerrarVenta.Click += btnCerrarVenta_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(109, 157);
            label14.Name = "label14";
            label14.Size = new Size(113, 20);
            label14.TabIndex = 8;
            label14.Text = "Hecho en el dia";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(71, 137);
            label13.Name = "label13";
            label13.Size = new Size(185, 20);
            label13.TabIndex = 7;
            label13.Text = "Se cierra la venta que se a ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(86, 117);
            label12.Name = "label12";
            label12.Size = new Size(157, 20);
            label12.TabIndex = 6;
            label12.Text = "Cerrar Ventas Del Dia";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(46, 33);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(238, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnColorOscuro);
            groupBox1.Controls.Add(btnColorVerde);
            groupBox1.Controls.Add(btnColorMorado);
            groupBox1.Controls.Add(btnColorAzul);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 277);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aparencia del sistema";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 162);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 9;
            label5.Text = "Para su sistema";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 142);
            label4.Name = "label4";
            label4.Size = new Size(252, 20);
            label4.TabIndex = 10;
            label4.Text = "Seleccione el color de su preferencia";
            // 
            // btnColorOscuro
            // 
            btnColorOscuro.BackColor = Color.Black;
            btnColorOscuro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColorOscuro.ForeColor = SystemColors.ControlLightLight;
            btnColorOscuro.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnColorOscuro.IconColor = Color.White;
            btnColorOscuro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColorOscuro.Location = new Point(347, 38);
            btnColorOscuro.Name = "btnColorOscuro";
            btnColorOscuro.Size = new Size(94, 88);
            btnColorOscuro.TabIndex = 8;
            btnColorOscuro.Text = "Oscuro";
            btnColorOscuro.TextAlign = ContentAlignment.BottomCenter;
            btnColorOscuro.UseVisualStyleBackColor = false;
            btnColorOscuro.Click += btnColorOscuro_Click;
            // 
            // btnColorVerde
            // 
            btnColorVerde.BackColor = Color.Teal;
            btnColorVerde.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColorVerde.ForeColor = SystemColors.ControlLightLight;
            btnColorVerde.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnColorVerde.IconColor = Color.White;
            btnColorVerde.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColorVerde.Location = new Point(236, 38);
            btnColorVerde.Name = "btnColorVerde";
            btnColorVerde.Size = new Size(94, 88);
            btnColorVerde.TabIndex = 7;
            btnColorVerde.Text = "Verde ";
            btnColorVerde.TextAlign = ContentAlignment.BottomCenter;
            btnColorVerde.UseVisualStyleBackColor = false;
            btnColorVerde.Click += btnColorNaranja_Click;
            // 
            // btnColorMorado
            // 
            btnColorMorado.BackColor = Color.Purple;
            btnColorMorado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColorMorado.ForeColor = SystemColors.ControlLightLight;
            btnColorMorado.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnColorMorado.IconColor = Color.White;
            btnColorMorado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColorMorado.Location = new Point(126, 38);
            btnColorMorado.Name = "btnColorMorado";
            btnColorMorado.Size = new Size(94, 88);
            btnColorMorado.TabIndex = 6;
            btnColorMorado.Text = "Morado";
            btnColorMorado.TextAlign = ContentAlignment.BottomCenter;
            btnColorMorado.UseVisualStyleBackColor = false;
            btnColorMorado.Click += btnColorMorado_Click;
            // 
            // btnColorAzul
            // 
            btnColorAzul.BackColor = SystemColors.Highlight;
            btnColorAzul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColorAzul.ForeColor = SystemColors.ControlLightLight;
            btnColorAzul.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnColorAzul.IconColor = Color.White;
            btnColorAzul.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColorAzul.Location = new Point(15, 38);
            btnColorAzul.Name = "btnColorAzul";
            btnColorAzul.Size = new Size(94, 88);
            btnColorAzul.TabIndex = 5;
            btnColorAzul.Text = "Azul";
            btnColorAzul.TextAlign = ContentAlignment.BottomCenter;
            btnColorAzul.UseVisualStyleBackColor = false;
            btnColorAzul.Click += btnColorAzul_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.HotTrack;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            btnRegresar.IconColor = Color.White;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegresar.Location = new Point(796, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 65);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(155, 57);
            label2.Name = "label2";
            label2.Size = new Size(536, 20);
            label2.TabIndex = 4;
            label2.Text = "Opciones de cambio de interfaz y cerrar ventas al finalizar la jornada laboral";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(155, 27);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Herramientas";
            // 
            // HerramientasDeTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(925, 445);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HerramientasDeTrabajador";
            Text = "HerramientasDeTrabajador";
            Load += HerramientasDeTrabajador_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnColorOscuro;
        private FontAwesome.Sharp.IconButton btnColorVerde;
        private FontAwesome.Sharp.IconButton btnColorMorado;
        private FontAwesome.Sharp.IconButton btnColorAzul;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnCerrarVenta;
        private Label label14;
        private Label label13;
        private Label label12;
        private PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}