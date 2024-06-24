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
    public partial class Form4 : Form
    {
        Karyawan model = new Karyawan();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming NIK is a decimal property in your model
            if (decimal.TryParse(txtNIK.Text.Trim(), out decimal nikValue))
            {
                // Check if the NIK already exists in the database
                using (KaryawanDBEntities db = new KaryawanDBEntities())
                {
                    if (db.Karyawans.Any(k => k.NIK == nikValue))
                    {
                        MessageBox.Show("NIK is already in use. Please enter a different one.");
                        return;
                    }
                }
                model.NIK = nikValue;
            }
            else
            {
                // Handle the case where the conversion fails
                MessageBox.Show("Invalid NIK. Please enter a valid numeric value.");
                return;
            }
            // Check if Nama_Lengkap is empty
            if (string.IsNullOrWhiteSpace(txtNamaLengkap.Text))
            {
                MessageBox.Show("Please enter Nama Lengkap.");
                return;
            }
            model.Nama_Lengkap = txtNamaLengkap.Text.Trim();
            if (radioButtonLaki.Checked)
            {
                // Assuming Gender is a property in your model
                model.Jenis_Kelamin = "Laki"; // You can change this based on your model structure
            }
            else if (radioButtonPerempuan.Checked)
            {
                // Assuming Gender is a property in your model
                model.Jenis_Kelamin = "Perempuan"; // You can change this based on your model structure
            }
            else
            {
                // Handle the case where neither RadioButton is checked
                MessageBox.Show("Please select a gender.");
            }
            model.Tanggal_Lahir = dateTimePicker1.Value;
            model.Alamat = txtAlamat.Text.Trim();
            // Assuming Department is a property in your model
            model.Negara = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(model.Negara))
            {
                // Handle the case where no department is selected
                MessageBox.Show("Please select a department.");
                return; // Don't proceed further if department is not selected
            }
            using (KaryawanDBEntities db = new KaryawanDBEntities())
            {
                db.Karyawans.Add(model);
                db.SaveChanges();
            }

            //LoadData();
            MessageBox.Show("Submitted Successfully");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Sample list of departments (replace with your actual data)
            List<string> departments = new List<string> { "Indonesia", "Malaysia", "Brunei", "Singapore", "Myanmar" };

            // Populate the ComboBox
            comboBox1.Items.AddRange(departments.ToArray());
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            Form1 dataForm = new Form1();
            dataForm.Show();
            this.Close();
        }
    }
}
