using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string[,] patentes = new string[5, 3];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGBtabla.Columns.Add("col1", "Patente");
            DGBtabla.Columns.Add("col2", "Fila");
            DGBtabla.Columns.Add("col3", "Columna");

        }

        private void imprimirGrilla()
        {
            DGBtabla.Rows.Clear();

            for (int row = 0; row < patentes.GetLength(0); row++)
            {
                for (int col = 0; col < patentes.GetLength(1); col++)
                {
                    if (patentes[row, col] != null)
                    {
                        DGBtabla.Rows.Add(patentes[row, col], row, col);
                    }
                }
            }
        }

        private bool verificacion(string patente)
        {
            for (int row = 0; row < patentes.GetLength(0); row++)
            {
                for (int col = 0; col < patentes.GetLength(1); col++)
                {
                    if (patentes[row, col] == patente)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonIngresa_Click(object sender, EventArgs e)
        {
            string patenteIngresada = textIngresa.Text;

            if (!verificacion(patenteIngresada)) // La patente no existe
            {
                for (int row = 0; row < patentes.GetLength(0); row++)
                {
                    for (int col = 0; col < patentes.GetLength(1); col++)
                    {
                        if (patentes[row, col] == null)
                        {
                            patentes[row, col] = patenteIngresada;
                            imprimirGrilla();
                            MessageBox.Show("Patente ingresada correctamente.");
                            return;
                        }
                    }
                }

                MessageBox.Show("No hay espacio disponible para ingresar más patentes.");
            }
            else
            {
                MessageBox.Show("La patente ya está ingresada.");
            }
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            string patenteEgreso = textSale.Text;

            if (verificacion(patenteEgreso)) 
            {
                for (int row = 0; row < patentes.GetLength(0); row++)
                {
                    for (int col = 0; col < patentes.GetLength(1); col++)
                    {
                        if (patentes[row, col] == patenteEgreso)
                        {
                            patentes[row, col] = null;
                            imprimirGrilla();
                            MessageBox.Show("Patente removida correctamente.");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La patente no está registrada.");
            }
        }
    }
}
