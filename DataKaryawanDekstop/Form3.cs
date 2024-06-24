using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawanDekstop
{
    public partial class Form3 : Form
    {
        private string _nik;
        public Form3(string nik)
        {
            InitializeComponent();
            _nik = nik;
            using (KaryawanDBEntities db = new KaryawanDBEntities())
            {
                var karyawan = db.Karyawans.FirstOrDefault(k => k.NIK.ToString() == _nik);
                if (karyawan != null)
                {
                    labelNik.Text = karyawan.NIK.ToString();
                    labelNama.Text = karyawan.Nama_Lengkap.ToString();
                    labelKelamin.Text = karyawan.Jenis_Kelamin.ToString();
                    labelTanggal.Text = karyawan.Tanggal_Lahir.ToString();
                    labelAlamat.Text = karyawan.Alamat.ToString();
                    labelNegara.Text = karyawan.Negara.ToString();
                }
            }
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            Form1 dataForm = new Form1();
            dataForm.Show();
            this.Close();
        }
    }
}
