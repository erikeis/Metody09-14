using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici(string vstup, out int soucetCifer, out int soucetSud, out int soucetLich)
        {
            bool obsahujeCislo = false;
            for (int i = 0; i < vstup.Length && !obsahujeCislo; i++)
            {
                if (Char.IsDigit(vstup[i])) obsahujeCislo = true;
            }
            soucetCifer = 0;
            soucetSud = 0;
            soucetLich = 0;
            if (obsahujeCislo == true)
            {

                int cislo;
                //ciferny soucet + soucet sudych a lichych cifer
                foreach (char znak in vstup)
                {
                    if (Char.IsDigit(znak))
                    {
                        cislo = Convert.ToInt32(znak.ToString());
                        soucetCifer += cislo;
                        if (znak % 2 == 0) soucetSud += cislo;
                        else soucetLich += cislo;
                    }
                }
            }
            else MessageBox.Show("Retezec neobsahuje cislici.");
            return obsahujeCislo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int cifSoucet, soucetLichCif, soucetSudCif;

            if (ObsahujeCislici(s, out cifSoucet, out soucetLichCif, out soucetSudCif))
            {
                MessageBox.Show("Součet cifer je " + cifSoucet + "\nSoučet lichých cifer je " + soucetLichCif + "\nSoučet sudých cifer je " + soucetSudCif);
            }
            else MessageBox.Show("Řetězec neobsahuje žádnou cifru");
        }
    }
}
