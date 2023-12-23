using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorKeruletTerulet_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Szamol_Click(object sender, EventArgs e)
        {
            double kerulet;
            double terulet;

            //bekeres(textBox_sugar.Text);
            //double r = double.Parse(textBox_sugar.Text);
            double r = bekeres(textBox_sugar.Text);
            kerulet = 2* r * Math.PI;
            terulet = r * r * Math.PI;
            label_kerulet.Text = ("A kör kerülete: "+ Math.Round(kerulet, 4));
            label_terulet.Text = ("A kör területe: " + Math.Round(terulet, 4));

        }

        private double bekeres(string text)
        {

            double sugar;
            if (!double.TryParse((textBox_sugar.Text) , out sugar))
            {
                MessageBox.Show("Hibás bevitel");
                textBox_sugar.Clear(); 

            }
            return sugar;
        }

        private void label_kerulet_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
