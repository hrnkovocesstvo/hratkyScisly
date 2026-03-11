using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hratkyScisly
    {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] kok = new int[201];

        private void makenums(int min, int max)
        {
            string totext = "";
            for(int i = min; i <= max; i++)
            {
                kok[i + 100] = i;
                totext += $"{Convert.ToString(i)}, ";
                Console.WriteLine(kok[i+100]);
            }
            
            totext = totext.Substring(0, totext.Length - 2);
            textBox.Text = totext;
        }

        private void buttonLicha_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMax_ValueChanged(null, null);
        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMax.Value != 0 && numericUpDownMin.Value != 0)
            {
                makenums((int)numericUpDownMin.Value, (int)numericUpDownMax.Value);
            }
        }
    }
}
