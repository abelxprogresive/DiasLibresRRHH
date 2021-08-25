using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace rrhh2
{
    class Validar
    {
        //funcion con return para validar solo numeros de los texbox
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }

        }

        public static void SoloLetras(KeyPressEventArgs V)
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }

        }





    }
}
