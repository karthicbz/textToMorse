using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textToMorse
{
    public partial class Form1 : Form
    {
        textToMorse tm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tm = new textToMorse();
            tm.textToMorseCode(textBox1.TextLength, textBox1.Text);
            textBox2.Text = tm.returnMorse(textBox1.TextLength);
        }
    }
}
