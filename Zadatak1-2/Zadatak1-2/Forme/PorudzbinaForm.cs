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
    public partial class PorudzbinaForm : Form
    {
        private int racun;
        private List<Knjiga> porudzbinaList;
        public PorudzbinaForm() {
            InitializeComponent();
        }

 

        private void PorudzbinaForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dataSet1.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.dataSet1.Knjiga);
            this.knjigaTableAdapter.Fill(this.dataSet1.Knjiga);
        }

        private void button1_Click(object sender, EventArgs e) {
            order_list.Items.Add(listBox1.Text);
            racun += DbBroker.getKnjigaPriceByName(listBox1.Text);
            label2.Text = racun.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void btn_uloni_Click(object sender, EventArgs e) {
            racun -= DbBroker.getKnjigaPriceByName(order_list.Text);
            order_list.Items.Remove(order_list.Text);
            label2.Text = racun.ToString();
        }

        private void btn_kreiraj_Click(object sender, EventArgs e) {

            List<string> porudzbine = new List<string>();

            foreach (var item in order_list.Items) {
                porudzbine.Add(item.ToString());
            }

            int id_porudzbine = DbBroker.kreirajPorudzbinu(DateTime.Now, racun);

            MessageBox.Show("Porudzbina je sacuvana.");

            order_list.Items.Clear();
            racun = 0;
            label2.Text = "0";


        }
    }
}
