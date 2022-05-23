using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Imposible
{
    class Boton : Button
    {
        private Form1 form;
        private string nombre;

        public Boton(int indice,int x, int y,Form1 f)
        {
            this.Size = new Size(88, 85);
            this.Location = new Point(x, y);
            this.Click += new EventHandler(Boton_Click);
            this.AccessibleName = indice.ToString();
            this.BackColor = Color.Orange;
            this.ForeColor = Color.White;
            form = f;
            indice++;
            nombre = indice.ToString();
            this.Text = nombre;
        }

        void Boton_Click(object sender, EventArgs e)
        {
            form.mueveBoton(int.Parse(this.AccessibleName));
        }
    }
}
