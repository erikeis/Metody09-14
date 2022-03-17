using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Vytvořte metodu ObsahujeSlovo, která pro zadaný řetězec zjistí, zda obsahuje alespoň jedno slovo, 
        //nejdelší slovo a nejkratší slovo.Slova jsou oddělena libovolným počtem mezer.
        //Pro řetězec v TextBox zavolejte metodu ObsahujeSlovo. V TextBox je řetězec obsahující slova oddělená 
        //libovolným počtem mezer, ale tento řetězec může být i prázdný nebo obsahovat pouze mezery.

        private bool ObsahujeSlovo(string vstup, out string nejdelsi, out string nejkratsi)
        {
            bool obsahujeSlovo = false;
            char[] oddelovac = { ' ' };
            string[] poleSlov = vstup.Split(oddelovac, StringSplitOptions.RemoveEmptyEntries);
            nejdelsi = poleSlov[0];
            nejkratsi = poleSlov[0];
            foreach (string slovo in poleSlov)
            {
                if (slovo.Length > nejdelsi.Length) nejdelsi = slovo;
                else if (slovo.Length < nejkratsi.Length) nejkratsi = slovo;
            }


            return obsahujeSlovo;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            string nejdelsiR, nejkratsiR;
            if (ObsahujeSlovo(retezec, out nejdelsiR, out nejkratsiR)) MessageBox.Show("Obsahuje slovo.");
            else MessageBox.Show("Neobsahuje slovo.");

        }
    }
}
