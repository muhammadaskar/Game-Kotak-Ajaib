using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotakAjaib
{
    class MKotakAjaib
    {
        public double angkaPojokKiri_Atas;
        public double angkaTengah_Atas;
        public double angkaPojokKanan_Atas;
        public double angkaKiri_Tengah;
        public double angka_Tengah;
        public double angkaKanan_Tengah;
        public double angkaKiri_Bawah;
        public double angkaTengah_Bawah;
        public double angkaKanan_Bawah;

        private double angkaUntukMenang = 15;
       // private double hitung;

        private double horizontal1;
        private double horizontal2;
        private double horizontal3;

        private double diagonal1;
        private double diagonal2;

        private double vertikal1;
        private double vertikal2;
        private double vertikal3;

        private bool cekWinner = false;
        
        /*=================================
         |            ANGKA ATAS          | 
         ================================== */
        public double getAngkaPojokKiri_Atas()
        {
            angkaPojokKiri_Atas += 1;
            if(angkaPojokKiri_Atas == 10)
            {
                angkaPojokKiri_Atas = 1;
            }
            
            return angkaPojokKiri_Atas;
        }

        public double getAngkaTengah_Atas()
        {
            angkaTengah_Atas += 1;
            if(angkaTengah_Atas == 10)
            {
                angkaTengah_Atas = 1;
            }

            return angkaTengah_Atas;

        }

        public double getAngkaPojokKanan_Atas()
        {
            angkaPojokKanan_Atas += 1;
            if(angkaPojokKanan_Atas == 10)
            {
                angkaPojokKanan_Atas = 1;
            }

            return angkaPojokKanan_Atas;
        }


        /*=================================
         |            ANGKA TENGAH        | 
         ================================== */
        public double getAngkaKiri_Tengah()
        {
            angkaKiri_Tengah += 1;
            if(angkaKiri_Tengah == 10)
            {
                angkaKiri_Tengah = 1;
            }
            return angkaKiri_Tengah;
        }

        public double getAngka_Tengah()
        {
            angka_Tengah += 1;
            if(angka_Tengah == 10)
            {
                angka_Tengah = 1;
            }
            return angka_Tengah;
        }

        public double getAngkaKanan_Tengah()
        {
            angkaKanan_Tengah += 1;
            if(angkaKanan_Tengah == 10)
            {
                angkaKanan_Tengah = 1;
            }
            return angkaKanan_Tengah;
        }

        /*=================================
         |            ANGKA BAWAH         | 
         ================================== */
        public double getAngkaKiri_Bawah()
        {
            angkaKiri_Bawah += 1;
            if(angkaKiri_Bawah == 10)
            {
                angkaKiri_Bawah = 1;
            }
            return angkaKiri_Bawah;
        }

        public double getAngkaTengah_Bawah()
        {
            angkaTengah_Bawah += 1;
            if(angkaTengah_Bawah == 10)
            {
                angkaTengah_Bawah = 1;
            }
            return angkaTengah_Bawah;
        }

        public double getAngkaKanan_Bawah()
        {
            angkaKanan_Bawah += 1;
            if(angkaKanan_Bawah == 10)
            {
                angkaKanan_Bawah = 1;
            }
            return angkaKanan_Bawah;
        }

        public void getHitung()
        {
            /*=================================
             |            HORIZONTAL          | 
             ================================== */
            this.horizontal1 = angkaPojokKiri_Atas + angkaTengah_Atas + angkaPojokKanan_Atas;
            this.horizontal2 = angkaKiri_Tengah + angka_Tengah + angkaKanan_Tengah;
            this.horizontal3 = angkaKiri_Bawah + angkaTengah_Bawah + angkaKanan_Bawah;

            /*=================================
             |            VERTIKAL            |
             ================================== */
            this.vertikal1 = angkaPojokKiri_Atas + angkaKiri_Tengah + angkaKiri_Bawah;
            this.vertikal2 = angkaTengah_Atas + angka_Tengah + angkaTengah_Bawah;
            this.vertikal3 = angkaPojokKanan_Atas + angkaKanan_Tengah + angkaKanan_Bawah;

            /*=================================
             |            DIAGONAL            |
             ================================== */
            this.diagonal1 = angkaPojokKiri_Atas + angka_Tengah + angkaKanan_Bawah;
            this.diagonal2 = angkaPojokKanan_Atas + angka_Tengah + angkaKiri_Bawah;
            
            if((vertikal1 == angkaUntukMenang) && (vertikal2 == angkaUntukMenang) && (vertikal3 == angkaUntukMenang)
                && (diagonal1 == angkaUntukMenang) && (diagonal2 == angkaUntukMenang)
                && (horizontal1 == angkaUntukMenang) && (horizontal2 == angkaUntukMenang) && (horizontal3 == angkaUntukMenang))
            {
                cekWinner = true; // Memberikan nilai true untuk atribut cekWinner jika kondisi terpenuhi
            }   
        }
        
        public void getWinner()
        {
            Winner w = new Winner(); // Instansiasi kelas Winner

            getHitung(); // memanggil method getHitung

            if(cekWinner == true) // Jika cekWinner bernilai true
            {
                w.Show(); // maka akan Menamplikan form Winner dari kelas Winner
            }   
        }
        
    }
}
