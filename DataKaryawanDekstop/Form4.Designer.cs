
namespace DataKaryawanDekstop
{
    partial class Form4
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
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPerempuan = new System.Windows.Forms.RadioButton();
            this.radioButtonLaki = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KembaliButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(136, 194);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(278, 96);
            this.txtAlamat.TabIndex = 37;
            this.txtAlamat.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 28);
            this.comboBox1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // radioButtonPerempuan
            // 
            this.radioButtonPerempuan.AutoSize = true;
            this.radioButtonPerempuan.Location = new System.Drawing.Point(205, 101);
            this.radioButtonPerempuan.Name = "radioButtonPerempuan";
            this.radioButtonPerempuan.Size = new System.Drawing.Size(116, 24);
            this.radioButtonPerempuan.TabIndex = 34;
            this.radioButtonPerempuan.TabStop = true;
            this.radioButtonPerempuan.Text = "Perempuan";
            this.radioButtonPerempuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaki
            // 
            this.radioButtonLaki.AutoSize = true;
            this.radioButtonLaki.Location = new System.Drawing.Point(136, 101);
            this.radioButtonLaki.Name = "radioButtonLaki";
            this.radioButtonLaki.Size = new System.Drawing.Size(63, 24);
            this.radioButtonLaki.TabIndex = 33;
            this.radioButtonLaki.TabStop = true;
            this.radioButtonLaki.Text = "Laki";
            this.radioButtonLaki.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Negara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Alamat";
            // 
            // KembaliButton
            // 
            this.KembaliButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.KembaliButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KembaliButton.Location = new System.Drawing.Point(303, 343);
            this.KembaliButton.Name = "KembaliButton";
            this.KembaliButton.Size = new System.Drawing.Size(100, 38);
            this.KembaliButton.TabIndex = 30;
            this.KembaliButton.Text = "Kembali";
            this.KembaliButton.UseVisualStyleBackColor = false;
            this.KembaliButton.Click += new System.EventHandler(this.KembaliButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Jenis Kelamin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(99, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Location = new System.Drawing.Point(136, 57);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(278, 26);
            this.txtNamaLengkap.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "NIK";
            // 
            // txtNIK
            // 
            this.txtNIK.Location = new System.Drawing.Point(136, 14);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(278, 26);
            this.txtNIK.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonPerempuan);
            this.Controls.Add(this.radioButtonLaki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KembaliButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNIK);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonPerempuan;
        private System.Windows.Forms.RadioButton radioButtonLaki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button KembaliButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNIK;
    }
}