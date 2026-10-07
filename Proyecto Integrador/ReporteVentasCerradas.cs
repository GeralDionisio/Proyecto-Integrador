using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class ReporteVentasCerradas : Form
    {

        private Form parentForm;
        private object UsuarioSesion;
        public ReporteVentasCerradas(Form parentForm, object usuarioSesion)
        {
            InitializeComponent();
            this.UsuarioSesion = usuarioSesion;
            this.parentForm = parentForm;
        }

        private void ReporteVentasCerradas_Load(object sender, EventArgs e)
        {

        }
    }
}
