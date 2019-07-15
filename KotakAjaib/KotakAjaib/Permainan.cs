using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotakAjaib
{
    public partial class Permainan : Form
    {
        MKotakAjaib ka = new MKotakAjaib(); // Instansiasi kelas MKotakAjaib
        Random rand = new Random(); // Instansiasi kelas Random
        Winner w = new Winner(); // Instansiasi kelas Winner

        public String data; // Atribut data untuk menyimpan nama pemain
        
        public Permainan()
        {
            InitializeComponent();
        }

        private void Permainan_Load(object sender, EventArgs e)
        {
            nama.Text += data; //menampilkan nama pemain yang sudah disimpan atribut data
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); //instansiasi kelas menu
            menu.Show(); // menampilkan form menu
        }
        
        
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Menampilkan Pesan Pilihan dialog dengan 2 pilihan
            DialogResult dialogPilihan = MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Pilih", MessageBoxButtons.YesNo);

            if(dialogPilihan == DialogResult.Yes) // jika dialogPilihan sama dengan Yes
            {
                Application.Exit(); // maka aplikasi akan keluar
            }
            else if(dialogPilihan == DialogResult.No) // jika dialogPilihan sama dengan No
            {
                Show(); // maka akan menampilkan formnya sendiri
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = ka.getAngkaPojokKiri_Atas().ToString();
            ka.getWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = ka.getAngkaKiri_Tengah().ToString();
            ka.getWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ka.angkaKiri_Bawah = rand.Next(10);
            button7.Text = ka.getAngkaKiri_Bawah().ToString();
            ka.getWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ka.angkaTengah_Atas = rand.Next(10);
            button2.Text = ka.getAngkaTengah_Atas().ToString();
            ka.getWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ka.angka_Tengah = rand.Next(10);
            button5.Text = ka.getAngka_Tengah().ToString();
            ka.getWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ka.angkaTengah_Bawah = rand.Next(10);
            button8.Text = ka.getAngkaTengah_Bawah().ToString();
            ka.getWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ka.angkaPojokKanan_Atas = rand.Next(10);
            button3.Text = ka.getAngkaPojokKanan_Atas().ToString();
            ka.getWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ka.angkaKanan_Tengah = rand.Next(10);
            button6.Text = ka.getAngkaKanan_Tengah().ToString();
            ka.getWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ka.angkaKanan_Bawah = rand.Next(10);
            button9.Text = ka.getAngkaKanan_Bawah().ToString();
            ka.getWinner();
        }
    }
}
