using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proizvod a = new Proizvod();
            ProizvodUtility b = new ProizvodUtility();

            a.kategorijaProizvoda = b.randomKategorija();
            a.SetCenaProizvoda(b.randomNumber());
            a.opisProizvoda = b.RandomSentence(150);
            a.naziv = b.RandomString(221);
            MessageBox.Show(
                $"ID je : {a.ID} \n" +
                $"Naziv je : {a.naziv}\n" +
                $"Opis proizvoda je : {a.opisProizvoda}\n" +
                $"Kategorija je : {a.kategorijaProizvoda.ToString()}\n" +
                $"Cena je : {a.CenaProizvoda.ToString()}");

            MessageBox.Show(a.ToString());
        }


    }
}
