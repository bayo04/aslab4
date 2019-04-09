using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aslab4
{
    public partial class Form1 : Form
    {
        List<Boja> listaBoja;
        Operacija operacija;
        int brojac;
        public Form1()
        {
            InitializeComponent();
            listaBoja = new List<Boja>();
            operacija = new Operacija();
            brojac = 0;
        }

        private void btdodaj_Click(object sender, EventArgs e)
        {
            operacija.dodaj(txboja.Text, listaBoja);
            textBox1.Text += txboja.Text + "  ";
        }

        private void btpromijeni_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromName(operacija.promjeni(brojac,listaBoja));
            brojac++;
        }
    }
}
