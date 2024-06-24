using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawanDekstop
{
    public partial class Form2 : Form
    {
        private string _nik;
        public Form2(string nik)
        {
            InitializeComponent();
            _nik = nik;

            // Sample list of departments (replace with your actual data)
            List<string> departments = new List<string> { "Indonesia", "Malaysia", "Brunei", "Singapore", "Myanmar" };

            // Populate the ComboBox
            comboBox1.Items.AddRange(departments.ToArray());

            // Retrieve the data from the database based on the NIK
            using (KaryawanDBEntities db = new KaryawanDBEntities())
            {
                var karyawan = db.Karyawans.FirstOrDefault(k => k.NIK.ToString() == _nik);

                if (karyawan != null)
                {
                    // Populate the TextBox with the retrieved data
                    labelNik.Text = karyawan.NIK.ToString(); // Convert NIK to string
                    txtNamaLengkap.Text = karyawan.Nama_Lengkap;

                    string gender = karyawan.Jenis_Kelamin?.Trim(); // Trim to remove leading and trailing spaces

                    if (gender == "Laki")
                    {
                        radioButtonLaki.Checked = true;
                        radioButtonPerempuan.Checked = false;
                    }
                    else if (gender == "Perempuan")
                    {
                        radioButtonLaki.Checked = false;
                        radioButtonPerempuan.Checked = true;
                    }
                    else
                    {
                        radioButtonLaki.Checked = false;
                        radioButtonPerempuan.Checked = false;
                    }

                    dateTimePicker1.Value = (DateTime)karyawan.Tanggal_Lahir;
                    txtAlamat.Text = karyawan.Alamat;

                    // Trim to handle leading/trailing spaces
                    string negara = karyawan.Negara.Trim();

                    // Check if the item is already in the ComboBox's items collection
                    if (!comboBox1.Items.Contains(karyawan.Negara))
                    {
                        // If not, add it to the ComboBox's items collection
                        comboBox1.Items.Add(karyawan.Negara);
                    }

                    // Set the selected item in the ComboBox
                    comboBox1.SelectedItem = karyawan.Negara;
                }
                else
                {
                    MessageBox.Show("Data not found for the selected NIK.");
                    this.Close(); // Close Form3 if data is not found
                }
            }
        }

        private void UbahButton_Click(object sender, EventArgs e)
        {
            string editedNamaLengkap = txtNamaLengkap.Text;
            string editedJenisKelamin = radioButtonLaki.Checked ? "Laki" : radioButtonPerempuan.Checked ? "Perempuan" : "";
            DateTime editedTanggalLahir = dateTimePicker1.Value;
            string editedAlamat = txtAlamat.Text;
            string editedNegara = comboBox1.SelectedItem?.ToString();

            // Retrieve the data from the database based on the NIK
            using (KaryawanDBEntities db = new KaryawanDBEntities())
            {
                var karyawan = db.Karyawans.FirstOrDefault(k => k.NIK.ToString() == _nik);

                if (karyawan != null)
                {
                    karyawan.Nama_Lengkap = editedNamaLengkap;
                    karyawan.Jenis_Kelamin = editedJenisKelamin;
                    karyawan.Tanggal_Lahir = editedTanggalLahir;
                    karyawan.Alamat = editedAlamat;
                    karyawan.Negara = editedNegara;
                    db.SaveChanges();

                    MessageBox.Show("Data updated successfully.");
                    Form1 dataForm = new Form1();
                    dataForm.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Data not found for the selected NIK.");
                    this.Close(); // Close Form3 if data is not found
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
