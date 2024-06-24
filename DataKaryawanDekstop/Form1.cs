using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;




namespace DataKaryawanDekstop
{
    public partial class Form1 : Form
    {
        Karyawan model = new Karyawan();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the click occurred in the dgAction column
                if (dataGridView1.Columns[e.ColumnIndex].Name == "dgAction")
                {
                    // Get the NIK of the selected row
                    string nik = dataGridView1.Rows[e.RowIndex].Cells["dgNIK"].Value.ToString();
                    // Open Form3 with the parsed NIK parameter
                    Form2 editForm = new Form2(nik);
                    editForm.Show(); // Show Form3 as a dialog
                    this.Hide();
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "dgAction2")
                {
                    string nik = dataGridView1.Rows[e.RowIndex].Cells["dgNIK"].Value.ToString();
                    Form3 detailForm = new Form3(nik);
                    detailForm.Show();
                    this.Hide();
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "dgAction3")
                {
                    if (MessageBox.Show("Apa kamu yakin ingin menghapus data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Get the NIK of the selected row
                        string nik = dataGridView1.Rows[e.RowIndex].Cells["dgNIK"].Value.ToString();

                        using (KaryawanDBEntities db = new KaryawanDBEntities())
                        {
                            // Retrieve the entity from the database based on the NIK
                            decimal nikDecimal = Convert.ToDecimal(nik);
                            var existingEntity = db.Karyawans.Find(nikDecimal);


                            if (existingEntity != null)
                            {
                                // If the entity is found, delete it
                                db.Karyawans.Remove(existingEntity);
                                db.SaveChanges();
                                
                                MessageBox.Show("Deleted Successfully");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Entity not found in the database. It may have been deleted by another user.");
                            }
                        }
                    }
                }

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Check that the event handler is executed
            Console.WriteLine("Form1_Load event handler executed");

            // Sample list of departments (replace with your actual data)
            List<string> departments = new List<string> { "Indonesia", "Malaysia", "Brunei", "Singapore", "Myanmar" };

            LoadData();
        }

        void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            using (KaryawanDBEntities db = new KaryawanDBEntities())
            {
                // Retrieve data from the database and store it in karyawanList
                var karyawanList = db.Karyawans.ToList();

                // Ensure dgAction column exists in the DataGridView
                if (!dataGridView1.Columns.Contains("dgAction2"))
                {
                    DataGridViewTextBoxColumn dgActionColumn2 = new DataGridViewTextBoxColumn();
                    dgActionColumn2.Name = "dgAction2";
                    dgActionColumn2.HeaderText = " Detail";
                    dataGridView1.Columns.Add(dgActionColumn2);
                }

                if (!dataGridView1.Columns.Contains("dgAction"))
                {
                    DataGridViewTextBoxColumn dgActionColumn = new DataGridViewTextBoxColumn();
                    dgActionColumn.Name = "dgAction";
                    dgActionColumn.HeaderText = "Action"; // Replace with your desired header text
                    dataGridView1.Columns.Add(dgActionColumn);
                }

                if (!dataGridView1.Columns.Contains("dgAction3"))
                {
                    DataGridViewTextBoxColumn dgActionColumn3 = new DataGridViewTextBoxColumn();
                    dgActionColumn3.Name = "dgAction3";
                    dgActionColumn3.HeaderText = " Delete";
                    dataGridView1.Columns.Add(dgActionColumn3);
                }

                // Add data to the DataGridView and set text in dgAction column for each row
                foreach (var karyawan in karyawanList)
                {
                    // Add the row and set other columns' values
                    int rowIndex = dataGridView1.Rows.Add(karyawan.NIK, karyawan.Nama_Lengkap, karyawan.Jenis_Kelamin, karyawan.Tanggal_Lahir, karyawan.Alamat);


                    // Set the value of the Negara column
                    dataGridView1.Rows[rowIndex].Cells["dgNegara"].Value = karyawan.Negara;

                    // Create a DataGridViewTextBoxCell for the dgAction column
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = "Edit"; // Replace "Edit" with your desired text

                    // Set the DataGridViewTextBoxCell in the dgAction column for this row
                    dataGridView1.Rows[rowIndex].Cells["dgAction"] = cell;

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = "Detail";
                    dataGridView1.Rows[rowIndex].Cells["dgAction2"] = cell2;

                    DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                    cell3.Value = "Delete";
                    dataGridView1.Rows[rowIndex].Cells["dgAction3"] = cell3;
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nikSearchTerm = txtNIKSearch.Text.Trim();

            try
            {
                using (KaryawanDBEntities db = new KaryawanDBEntities())
                {
                    var query = db.Karyawans.AsQueryable();

                    if (!string.IsNullOrEmpty(nikSearchTerm))
                    {
                        decimal nikValue;
                        if (decimal.TryParse(nikSearchTerm, out nikValue))
                        {
                            query = query.Where(k => k.NIK == nikValue);
                        }
                        else
                        {
                            MessageBox.Show("Invalid NIK. Please enter a valid numeric value for NIK.");
                            return;
                        }
                    }

                    dataGridView1.DataSource = query.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form4 addForm = new Form4();
            addForm.Show(); // Show Form3 as a dialog
            this.Hide();
        }

    }
}
