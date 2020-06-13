using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1_2.Forme
{
    public partial class KnjigaForm : Form
    {
        public KnjigaForm() {
            InitializeComponent();
        }

        private void Knjiga_Load(object sender, EventArgs e) {

            NapuniGrid();
        }

        private void NapuniGrid() {
            try {
                dataGridView1.DataSource = DbBroker.VratiSveKnjige();
            } catch (Exception ex) {
                MessageBox.Show(string.Format("Greška prilikom vraćanja podataka iz baze: {0}", ex.Message), "Greška");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBoxId.Text == "" || textBoxId.Text == null) {
                MessageBox.Show("morate uneti id polja koje se updateuje!");
            }
            Knjiga knjiga = new Knjiga();

            try { knjiga.id = Int32.Parse(textBoxId.Text); } catch { MessageBox.Show("Nije u dobrom formatu ID"); };
            knjiga.autor = textBoxAutor.Text;
            knjiga.naziv = textBoxNaziv.Text;
            try { knjiga.cena = Int32.Parse(textBoxCena.Text); } catch { MessageBox.Show("Nije u dobrom formatu cena"); };
            knjiga.slika = textBoxSlika.Text;
            knjiga.kategorija = textBoxKategorija.Text;

            DbBroker.UpdateKnjigu(knjiga);

            NapuniGrid();
        }

        private void button1_Click(object sender, EventArgs e) {
            Knjiga knjiga = new Knjiga();


            knjiga.autor = textBoxAutor.Text;
            knjiga.naziv = textBoxNaziv.Text;
            try { knjiga.cena = Int32.Parse(textBoxCena.Text); } catch { MessageBox.Show("Nije u dobrom formatu cena"); };
            knjiga.slika = textBoxSlika.Text;
            knjiga.kategorija = textBoxKategorija.Text;

            DbBroker.InsertKnjiga(knjiga);

            NapuniGrid();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (textBoxId.Text == "" || textBoxId.Text == null) {
                MessageBox.Show("morate uneti id polja koje se brise!");
            }
            Knjiga knjiga = new Knjiga();
            try { knjiga.id = Int32.Parse(textBoxId.Text); } catch { MessageBox.Show("Nije u dobrom formatu ID"); };
            DbBroker.DeleteKnjiga(knjiga);

            NapuniGrid();
        }

        private void resetall() {
            textBoxId.Text = "";
            textBoxAutor.Text = "";
            textBoxCena.Text = "";
            textBoxNaziv.Text = "";
            textBoxKategorija.Text = "";
            textBoxSlika.Text = "";

            NapuniGrid();
        }

        private void button4_Click(object sender, EventArgs e) {
            resetall();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
        }
    }
}
