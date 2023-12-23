using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Czigleczki_LogikaiMuveletek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Alapotvaltas_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked; 
            checkBox2.Checked = !checkBox2.Checked;
        }

        private void button_ES_Click(object sender, EventArgs e)
        {
            bool l = checkBox1.Checked && checkBox2.Checked;
            MessageBox.Show("A logikai ÉS eredménye: " + l.ToString());

        }

        private void button_Vagy_Click(object sender, EventArgs e)
        {
            bool l = checkBox1.Checked || checkBox2.Checked;
            MessageBox.Show("A logikai VAGY eredménye: " + l.ToString());
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
