using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaProyecto
{
    class OcultarDatos
    {
        public static void Ocultartextbox(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Visible = false;
                }
                if (c is Label)
                {
                    c.Visible = false;
                }
                if (c is DateTimePicker)
                {
                    c.Visible = false;
                }
            }
        }

        public static void ocultartexto(Control a)
        {
            foreach (Control control in a.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }

            }
        }

        public static void estatus(Control a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "True" || c.Text == "true")
                    {
                        c.Text = "1";
                    }

                    if (c.Text == "False"||c.Text == "false")
                    {
                        c.Text = "0";
                    }
                }
            }
        }
    }
}
