
namespace DataKaryawanDekstop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgNIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNamaLengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgJenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTanggalLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNegara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNIKSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNIK,
            this.dgNamaLengkap,
            this.dgJenisKelamin,
            this.dgTanggalLahir,
            this.dgAlamat,
            this.dgNegara});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 292);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dgNIK
            // 
            this.dgNIK.DataPropertyName = "NIK";
            this.dgNIK.HeaderText = "NIK";
            this.dgNIK.MinimumWidth = 8;
            this.dgNIK.Name = "dgNIK";
            this.dgNIK.Width = 150;
            // 
            // dgNamaLengkap
            // 
            this.dgNamaLengkap.DataPropertyName = "Nama_Lengkap";
            this.dgNamaLengkap.HeaderText = "Nama Lengkap";
            this.dgNamaLengkap.MinimumWidth = 8;
            this.dgNamaLengkap.Name = "dgNamaLengkap";
            this.dgNamaLengkap.Width = 150;
            // 
            // dgJenisKelamin
            // 
            this.dgJenisKelamin.DataPropertyName = "Jenis_Kelamin";
            this.dgJenisKelamin.HeaderText = "Jenis Kelamin";
            this.dgJenisKelamin.MinimumWidth = 8;
            this.dgJenisKelamin.Name = "dgJenisKelamin";
            this.dgJenisKelamin.Width = 150;
            // 
            // dgTanggalLahir
            // 
            this.dgTanggalLahir.DataPropertyName = "Tanggal_Lahir";
            this.dgTanggalLahir.HeaderText = "Tanggal Lahir";
            this.dgTanggalLahir.MinimumWidth = 8;
            this.dgTanggalLahir.Name = "dgTanggalLahir";
            this.dgTanggalLahir.Width = 150;
            // 
            // dgAlamat
            // 
            this.dgAlamat.DataPropertyName = "Alamat";
            this.dgAlamat.HeaderText = "Alamat";
            this.dgAlamat.MinimumWidth = 8;
            this.dgAlamat.Name = "dgAlamat";
            this.dgAlamat.Width = 150;
            // 
            // dgNegara
            // 
            this.dgNegara.DataPropertyName = "Negara";
            this.dgNegara.HeaderText = "Negara";
            this.dgNegara.MinimumWidth = 8;
            this.dgNegara.Name = "dgNegara";
            this.dgNegara.Width = 150;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(172, 68);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 38);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "NIK";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 28;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNIKSearch
            // 
            this.txtNIKSearch.Location = new System.Drawing.Point(12, 32);
            this.txtNIKSearch.Name = "txtNIKSearch";
            this.txtNIKSearch.Size = new System.Drawing.Size(278, 26);
            this.txtNIKSearch.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 806);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNIKSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNamaLengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgJenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTanggalLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNegara;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNIKSearch;
    }
}

