using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionBasketball
{
    public partial class SimulacionBasketball : Form
    {
        int Jugador1 = 0, Jugador2 = 0;
        int encesto = 0, fallo = 0;
        int encesto2 = 0, fallo2 = 0;

        public SimulacionBasketball()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turno();
        }

        public void turno()
        {
            Random rand = new Random();

            int num;
            num = rand.Next(1, 101);

            if (num > 87) //Jugador 2
            {
                turno2.Visible = true;
                turno1.Visible = false;
                Jugador2 = 2;
                encesto = 0; fallo = 0;
                encestolabel.Text = "0";
                fallolabel.Text = "0";
                Posicion2();
            }
            else //Jugador 1
            {
                Jugador1 = 1;
                turno1.Visible = true;
                turno2.Visible = false;
                encesto2 = 0; fallo2 = 0;
                encesto2label.Text = "0";
                fallo2label.Text = "0";
                Posicion1();
            }
        }

        public void Posicion1()
        {

            int IZ2 = 1, IZ1 = 2, CE = 3, DE2 = 4, DE = 5, CO = 6;
            if (Jugador1 == 1) //Jugador diestro Jugador 1
            {
                Random rando = new Random();

                for (int i = 0; i < 20; i++)
                {
                    Random rand = new Random();
                    decimal posicion = rand.Next(1, 7);
                    if (posicion == IZ2)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                    if (posicion == IZ1)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                    if (posicion == CE)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                    if (posicion == DE)
                    {
                        int probabilidad = rando.Next(1, 101);
                       if (probabilidad > 35)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                    if (posicion == DE2)
                    {
                        int probabilidad = rando.Next(1, 101);
                        if (probabilidad > 35)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                    if (posicion == CO)
                    {
                        int probabilidad = rando.Next(1, 101);
                                   if (probabilidad > 85)
                        {
                            encesto++;
                            encestolabel.Text = encesto.ToString();
                        }
                        else
                        {
                            fallo++;
                            fallolabel.Text = fallo.ToString();
                        }
                    }
                }
                encesto = 0; fallo = 0;
            }
        }

        public void Posicion2()
        {
            int IZ22 = 1, IZ11 = 2, CE1 = 3, DE22 = 4, DE1 = 5, CO1 = 6;

            if (Jugador2 == 2) //jugador 2
            {

                Random rando = new Random();

                for (int i = 0; i < 20; i++)
                {
                    Random rand = new Random();
                    decimal posicion = rand.Next(1, 7);
                    if (posicion == IZ22)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 25)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                    if (posicion == IZ11)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 25)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                    if (posicion == CE1)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                    if (posicion == DE1)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                    if (posicion == DE22)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                    if (posicion == CO1)
                    {
                        int probabilidad = rando.Next(1, 101);

                        if (probabilidad > 85)
                        {
                            encesto2++;
                            encesto2label.Text = encesto2.ToString();
                        }
                        else
                        {
                            fallo2++;
                            fallo2label.Text = fallo2.ToString();
                        }
                    }
                }
                encesto2 = 0; fallo2 = 0;
            }
        }

    }
}

