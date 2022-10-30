using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbjadwal1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {   

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            if (cbpiano.Checked)
            {
                kelas = kelas + " piano ";
            }
            if (cbangklung.Checked)
            {
                kelas = kelas + " angklung ";
            }
            if (cbbiola.Checked)
            {
                kelas = kelas + " biola ";

            }
            if (cbgitar.Checked)
            {
                kelas = kelas + " gitar ";
            }
            if (cbkonduktor.Checked)
            {
                kelas = kelas + " konduktor ";

            }
            if (cbdrum.Checked)
            {
                kelas = kelas + " drum ";
            }
            if (cbvokal.Checked)
            {
                kelas = kelas + " vokal ";
            }
            if (cbkomposer.Checked)
            {
                kelas = kelas + " komposer ";
            }
            if (kelas == "")
            {
                MessageBox.Show("wajib memilih salah satu dari pilihan kelas", "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string jadwal = "";

            if (rbjadwal1.Checked)
            {
                jadwal = "senin & Rabu, 14.00 - 16.00";
            }
            else if (rbjadwal2.Checked)
            {
                jadwal = "selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbjadwal3.Checked)
            {
                jadwal = "sabtu & Minggu, 09.00 - 11.00";

            }
            else if (rbjadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
            MessageBox.Show
            ("Nama : " + txtNama.Text + 
              "\nJenis Kelamin : " + cbjk.Text +
              "\nTanggal Lahir : " + dtTglLahir.Text +
              "\nPilihan Kelas : " + kelas + 
              "\nPilihan Jadwal : " + jadwal, 
              "informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbpiano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbangklung_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbiola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbgitar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbkonduktor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbdrum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbvokal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbkomposer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbjadwal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbjadwal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbjadwal4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbjk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

