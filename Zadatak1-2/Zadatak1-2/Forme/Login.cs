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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e) {

            if(DbBroker.Login(txt_username.Text, txt_password.Text)){
                MessageBox.Show($"Korisnik {txt_username.Text} uspesno ulogovan!");
                PorudzbinaForm porudzbinaForm = new PorudzbinaForm();
                porudzbinaForm.Show();
                this.Hide();
            } else MessageBox.Show($"Korisnik ne postoji u bazi!");
        }

        private void register_btn_Click(object sender, EventArgs e) {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            KnjigaForm knjigaForm = new KnjigaForm();
            knjigaForm.Show();
            this.Hide();
        }
    }
}
