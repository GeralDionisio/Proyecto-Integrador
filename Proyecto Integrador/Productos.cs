using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador
{
    public class Productos
    {
        public string IdProductos { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string PrecioActual { get; set; }
        public string StockActual { get; set; }
        public string StockMinimo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Categoria { get; set; }
    }
    
}
