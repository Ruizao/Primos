using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Primos rui = new Primos();
        private void Button1_Click_1(object sender, EventArgs e)
        {
            rui.recebe = textBox1.Text;
            label2.Text = rui.envia;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            {
                rui.recebe = textBox1.Text;
                label2.Text = rui.envia;
                label2.Text = ("O dia da semana é " + rui.envia);
            }

        }
    }
}
