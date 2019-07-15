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
    public partial class Winner : Form
    {
        
        public Winner()
        {
            InitializeComponent();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Permainan p = new Permainan();
            p.Show();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
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
    }
}
