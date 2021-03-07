using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_sabado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, n, suma = 0;
            listBox1.Items.Clear();

            n = int.Parse(textBox1.Text);

            for (int i = 1; i <= n; i++)
            {

                suma = suma + i;

                if (checkBox1.Checked==true)
                {

                    listBox1.Items.Add("Sumando: " + i + "  Suma parcial: " + suma);

                }
            }

            listBox1.Items.Add("La suma total es: " + suma);

        }
    }
}
