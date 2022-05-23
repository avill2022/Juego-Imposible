using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Imposible
{
    public partial class Form1 : Form
    {
        private List<Boton> listaBoton;
        private Boton boton;
        private Nivel Nivel;
        private Opciones Opciones;
        public int _nivel { get { return nivel; } set { nivel = value; } }
        private int nombreB;
        private bool juego;
        private Random rand;
        private int nivel;
        private int movimiento;
        private int minutos;
        private int segundos;


        public Form1()
        {
            InitializeComponent();

            nombreB = 0;
            this.BackColor = Color.Green;
            listaBoton = new List<Boton>();
            juego = false;
            nivel = 20;
            movimiento = nivel;
            label2.Text = "Movimientos: " + 0; 
            minutos = 0;
            segundos = 0;

            rand = new Random();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    boton = new Boton(nombreB, 12 + 95 * i, 12+90*j,this);
                    nombreB++;
                    listaBoton.Add(boton);
                    Controls.Add(boton);
                }
            }
            listaBoton[8].Text = " ";
            listaBoton[8].Visible = false;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            label1.Text = minutos + ":" + segundos;
        }
        public void mueveBoton(int num)
        {
            if (juego == true)
            {
                movimiento--;
                if (movimiento == 0)
                {
                    label2.Text = "Perdiste";
                    juego = false;
                    minutos = 0;
                    segundos = 0;
                    timer1.Stop();
                    MessageBox.Show("Perdiste");
                }
                else
                {
                    label2.Text = "Movimientos: " + movimiento;
                }

                if (num == 0)
                {
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 1)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 2)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 3)
                {
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 4)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 5)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                    if (listaBoton[num + 3].Text == " ")
                    {
                        movimientos(4, num);
                    }
                }
                if (num == 6)
                {
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                }
                if (num == 7)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num + 1].Text == " ")
                    {
                        movimientos(2, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                }
                if (num == 8)
                {
                    if (listaBoton[num - 1].Text == " ")
                    {
                        movimientos(1, num);
                    }
                    if (listaBoton[num - 3].Text == " ")
                    {
                        movimientos(3, num);
                    }
                }
                resuelto();
            }
        }

        private void nuevoJuego_Click(object sender, EventArgs e)
        {
            movimiento = nivel;
            this.solucionarToolStripMenuItem_Click(sender,e);
            this.deshacer_Click(sender,e);
            label2.Text = "Movimientos:" +movimiento;
            juego = true;
        }


        public void deshacer_Click(object sender, EventArgs e)
        {
            int rdn=0;
            juego = true;
            if (nivel == 60)
            {
                label2.Text = "Movimientos: ????";
            }
            else
            {
                movimiento = nivel;
                label2.Text = "Movimientos:" + movimiento;
            }

            for (int j = 0; j < nivel;j++ )
            {
                for (int i = 8; i >= 0; i--)
                {
                    if (listaBoton[i].Text == " ")
                    {
                        if (i == 8)
                        {
                            rdn = rand.Next(2);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;

                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 7)
                        {
                            rdn = rand.Next(3);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                            if (rdn == 2)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 6)
                        {
                            rdn = rand.Next(2);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 5)
                        {
                            rdn = rand.Next(3);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }
                            if (rdn == 2)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 4)
                        {
                            rdn = rand.Next(4);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                            if (rdn == 2)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }
                            if (rdn == 3)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 3)
                        {
                            rdn = rand.Next(3);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }
                            if (rdn == 2)
                            {
                                listaBoton[i].Text = listaBoton[i - 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 3].Text = " ";
                                listaBoton[i - 3].Visible = false;
                            }
                        }
                        if (i == 2)
                        {
                            rdn = rand.Next(2);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }

                        }
                        if (i == 1)
                        {
                            rdn = rand.Next(3);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i - 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i - 1].Text = " ";
                                listaBoton[i - 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }
                            if (rdn == 2)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                        }
                        if (i == 0)
                        {
                            rdn = rand.Next(2);
                            if (rdn == 0)
                            {
                                listaBoton[i].Text = listaBoton[i + 1].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 1].Text = " ";
                                listaBoton[i + 1].Visible = false;
                            }
                            if (rdn == 1)
                            {
                                listaBoton[i].Text = listaBoton[i + 3].Text;
                                listaBoton[i].Visible = true;
                                listaBoton[i + 3].Text = " ";
                                listaBoton[i + 3].Visible = false;
                            }

                        }

                    }
                }
            }
            timer1.Start();
        }

        private void dificultad_Click(object sender, EventArgs e)
        {
            Nivel = new Nivel(this, 1);
            Nivel.ShowDialog();
        }   

        private void opciones_Click(object sender, EventArgs e)
        {
            Opciones = new Opciones(this);
            Opciones.ShowDialog();
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            new Estadisticas().ShowDialog();
        }

        private void solucionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 1;
            juego = false;
            minutos = 0;
            segundos = 0;
            label1.Text = 0 + ":" + 0;
            if (nivel == 60)
            {
                label2.Text = "Movimientos: ????";
            }
            else
            { 
                label2.Text = "Movimientos: " + nivel;
            }
            

            for (int i = 0; i < 9; i++)
            {
                listaBoton[i].Text = n.ToString();
                listaBoton[i].Visible = true;
                n++;
            }
            listaBoton[8].Visible = false;
            listaBoton[8].Text = " ";
            timer1.Stop();
        }
        public void resuelto()
        {
            int n = 1;
            minutos = 0;
            segundos = 0;
            label1.Text = 0 + ":" + 0;

            for (int i = 0; i < 8; i++)
            {
                if (listaBoton[i].Text != n.ToString())
                {
                    return;
                }
                n++;
            }
            timer1.Stop();
            juego = false;
            label2.Text = "Movimientos:" + 0;
            MessageBox.Show("Resuelto");
        }
        public void movimientos(int numero,int num)
        {
            switch (numero)
            { 
                case 1:
                    listaBoton[num - 1].Text = listaBoton[num].Text;
                    listaBoton[num - 1].Visible = true;
                    listaBoton[num].Text = " ";
                    listaBoton[num].Visible = false;
                break;
                case 2:
                    listaBoton[num + 1].Text = listaBoton[num].Text;
                    listaBoton[num + 1].Visible = true;
                    listaBoton[num].Text = " ";
                    listaBoton[num].Visible = false;
                break;
                case 3:
                    listaBoton[num - 3].Text = listaBoton[num].Text;
                    listaBoton[num - 3].Visible = true;
                    listaBoton[num].Text = " ";
                    listaBoton[num].Visible = false;
                break;
                case 4: 
                    listaBoton[num + 3].Text = listaBoton[num].Text;
                    listaBoton[num + 3].Visible = true;
                    listaBoton[num].Text = " ";
                    listaBoton[num].Visible = false;
                break;
                
            }
        }

        private void acercaDeImposibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Informacion().ShowDialog();
        }
    }
}
