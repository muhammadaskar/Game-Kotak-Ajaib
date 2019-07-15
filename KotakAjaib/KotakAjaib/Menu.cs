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
    public partial class Menu : Form
    {
        PembuatPermainan pp = new PembuatPermainan(); // melakukan instansiasi kelas dari PembuatPermainan
        Permainan p = new Permainan(); // melakukan instansiasi kelas dari Permainan
        
        public Menu()
        {
            InitializeComponent();
        }
        
        private void buttonCaraBermain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klik angka pada tombol sehingga angka tersebut" +
                " akan berubah, Sesuaikan angka tersebut hingga berjumlah 15," +
                "Pemain akan menang jika jumlah keseluruhan 15 dengan syarat " +
                "Horizontal, Diagonal dan Vertikal berjumlah 15");
        }

        private void buttonPembuatPermainan_Click(object sender, EventArgs e)
        {
            pp.Show(); // menampilkan form Pembuat Permainan
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Menampilkan Pesan Pilihan dialog dengan 2 pilihan
            DialogResult dialogPilihan = MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Pilih", MessageBoxButtons.YesNo);

            if (dialogPilihan == DialogResult.Yes) // jika dialogPilihan sama dengan Yes
            {
                Application.Exit(); // maka aplikasi akan keluar
            }
            else if (dialogPilihan == DialogResult.No) // jika dialogPilihan sama dengan No
            {
                Show(); // maka akan tetap menampilkan formnya sendiri
            }
        }

        private void buttonMulaiPermainan_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text == "") // Jika Nama Pemain Kosong 
            {   // Maka akan Memberikan pesan dan permainan tidak akan dimulai
                MessageBox.Show("! Silahkan Isi Nama Anda Terlebih Dahulu !"); 
            }
            else
            {
                p.Show(); // menampilkan form permainan 
            }
            
        }
        
        private void buttonMasukkanNamaPemain_Click(object sender, EventArgs e)
        {
            // Memberikan nama pemain yang sudah di input di textbox kemudian di simpan oleh variabel data
            p.data = textBox1.Text;
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
