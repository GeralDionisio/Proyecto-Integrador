using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador
{
    public class SeguidorPila
    {
        private static Stack<Form> historial = new Stack<Form>();

        // 1. Método para ir al siguiente formulario
        public static void AbrirSiguiente(Form formularioActual, Form formularioNuevo)
        {
            historial.Push(formularioActual); 
            formularioActual.Hide();          
            formularioNuevo.Show();            
        }

        // 2. Método para el botón Regresar
        public static void Regresar(Form formularioActual)
        {
            if (historial.Count > 0)
            {
                Form formularioAnterior = historial.Pop(); 
                formularioAnterior.Show();                
                formularioActual.Close();                 
            }
        }

    }
}
