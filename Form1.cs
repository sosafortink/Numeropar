using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroParImparPlusNegative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("El numero es: " +(numero)+"\n y tambien es: "+(numero));
        }

        private string PositivoNegativo(int n)
        {
            if (n==0)
            {
                return "0";
            }
            else if (n>=1)
            {
                return "Positivo";
            }
            else
            {
                return "Negativo";
            }
        }

        private string ParImpar(int n)
        {
            if (n % 2 == 0)
            {
                return "Par";
            }

            return "Impar";
        }

    }
}
