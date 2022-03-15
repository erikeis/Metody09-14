using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int PocetSlov(string s1, out string s2)
        {
            char[] oddelovace = { ' ' };
            string[] pole = s1.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            while (index < s1.Length)
            {
                if (Char.IsDigit(s1[index]))
                {
                    s1.Remove(index, 1);
                }
            }
            s2 = s1;
            return pole.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string novyRetezec;
            PocetSlov(str, out novyRetezec);
            MessageBox.Show("Pocet slov je " + PocetSlov(str, out novyRetezec).ToString() + " a novy retezec je " + novyRetezec);
        }
    }
}
