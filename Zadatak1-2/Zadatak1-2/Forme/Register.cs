using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak1_2.Forme;

namespace Zadatak1_2
{
    public partial class Register : Form
    {
        public Register() {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e) {
            try {
                Klijent klijent = new Klijent();
                klijent.korisnickoIme = txt_korisnickoIme.Text;
                klijent.sifra = txt_sifra.Text;
                klijent.ime = txt_ime.Text;
                klijent.prezime = txt_prezime.Text;
                klijent.adresa = txt_adresa.Text;
                klijent.email = txt_email.Text;
                klijent.telefon = txt_telefon.Text;

                DbBroker.UnesiKlijenta(klijent);
                MessageBox.Show("Uspešno unet korisnik!");
                login login = new login();
                login.Show();
                this.Hide();
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Greška prilikom unosa podataka u bazu: {0}", ex.Message), "Greška");
                throw;
            }
        }

        private void Register_Load(object sender, EventArgs e) {

        }

        protected override void OnClosed(EventArgs e) {
            login login = new login();
            login.Show();
        }
    }
}
