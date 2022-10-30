namespace P5_4_1214073
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.cbjk = new System.Windows.Forms.ComboBox();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.cbkomposer = new System.Windows.Forms.CheckBox();
            this.cbvokal = new System.Windows.Forms.CheckBox();
            this.cbdrum = new System.Windows.Forms.CheckBox();
            this.cbkonduktor = new System.Windows.Forms.CheckBox();
            this.cbgitar = new System.Windows.Forms.CheckBox();
            this.cbbiola = new System.Windows.Forms.CheckBox();
            this.cbangklung = new System.Windows.Forms.CheckBox();
            this.cbpiano = new System.Windows.Forms.CheckBox();
            this.jadwal = new System.Windows.Forms.GroupBox();
            this.rbjadwal4 = new System.Windows.Forms.RadioButton();
            this.rbjadwal3 = new System.Windows.Forms.RadioButton();
            this.rbjadwal2 = new System.Windows.Forms.RadioButton();
            this.rbjadwal1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kelas.SuspendLayout();
            this.jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(263, 52);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 1;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Lahir";
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(263, 138);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(200, 20);
            this.dtTglLahir.TabIndex = 4;
            // 
            // cbjk
            // 
            this.cbjk.FormattingEnabled = true;
            this.cbjk.Items.AddRange(new object[] {
            "Laki Laki",
            "perempuan"});
            this.cbjk.Location = new System.Drawing.Point(263, 97);
            this.cbjk.Name = "cbjk";
            this.cbjk.Size = new System.Drawing.Size(120, 21);
            this.cbjk.TabIndex = 5;
            this.cbjk.Text = "-- Pilih Jenis Kelamin --";
            this.cbjk.SelectedIndexChanged += new System.EventHandler(this.cbjk_SelectedIndexChanged);
            // 
            // kelas
            // 
            this.kelas.Controls.Add(this.cbkomposer);
            this.kelas.Controls.Add(this.cbvokal);
            this.kelas.Controls.Add(this.cbdrum);
            this.kelas.Controls.Add(this.cbkonduktor);
            this.kelas.Controls.Add(this.cbgitar);
            this.kelas.Controls.Add(this.cbbiola);
            this.kelas.Controls.Add(this.cbangklung);
            this.kelas.Controls.Add(this.cbpiano);
            this.kelas.Location = new System.Drawing.Point(99, 211);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(305, 174);
            this.kelas.TabIndex = 6;
            this.kelas.TabStop = false;
            this.kelas.Text = "Pilihan Kelas";
            this.kelas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbkomposer
            // 
            this.cbkomposer.AutoSize = true;
            this.cbkomposer.Location = new System.Drawing.Point(177, 140);
            this.cbkomposer.Name = "cbkomposer";
            this.cbkomposer.Size = new System.Drawing.Size(73, 17);
            this.cbkomposer.TabIndex = 7;
            this.cbkomposer.Text = "Komposer";
            this.cbkomposer.UseVisualStyleBackColor = true;
            this.cbkomposer.CheckedChanged += new System.EventHandler(this.cbkomposer_CheckedChanged);
            // 
            // cbvokal
            // 
            this.cbvokal.AutoSize = true;
            this.cbvokal.Location = new System.Drawing.Point(177, 105);
            this.cbvokal.Name = "cbvokal";
            this.cbvokal.Size = new System.Drawing.Size(53, 17);
            this.cbvokal.TabIndex = 6;
            this.cbvokal.Text = "Vokal";
            this.cbvokal.UseVisualStyleBackColor = true;
            this.cbvokal.CheckedChanged += new System.EventHandler(this.cbvokal_CheckedChanged);
            // 
            // cbdrum
            // 
            this.cbdrum.AutoSize = true;
            this.cbdrum.Location = new System.Drawing.Point(177, 69);
            this.cbdrum.Name = "cbdrum";
            this.cbdrum.Size = new System.Drawing.Size(51, 17);
            this.cbdrum.TabIndex = 5;
            this.cbdrum.Text = "Drum";
            this.cbdrum.UseVisualStyleBackColor = true;
            this.cbdrum.CheckedChanged += new System.EventHandler(this.cbdrum_CheckedChanged);
            // 
            // cbkonduktor
            // 
            this.cbkonduktor.AutoSize = true;
            this.cbkonduktor.Location = new System.Drawing.Point(177, 32);
            this.cbkonduktor.Name = "cbkonduktor";
            this.cbkonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbkonduktor.TabIndex = 4;
            this.cbkonduktor.Text = "Konduktor";
            this.cbkonduktor.UseVisualStyleBackColor = true;
            this.cbkonduktor.CheckedChanged += new System.EventHandler(this.cbkonduktor_CheckedChanged);
            // 
            // cbgitar
            // 
            this.cbgitar.AutoSize = true;
            this.cbgitar.Location = new System.Drawing.Point(6, 140);
            this.cbgitar.Name = "cbgitar";
            this.cbgitar.Size = new System.Drawing.Size(48, 17);
            this.cbgitar.TabIndex = 3;
            this.cbgitar.Text = "Gitar";
            this.cbgitar.UseVisualStyleBackColor = true;
            this.cbgitar.CheckedChanged += new System.EventHandler(this.cbgitar_CheckedChanged);
            // 
            // cbbiola
            // 
            this.cbbiola.AutoSize = true;
            this.cbbiola.Location = new System.Drawing.Point(6, 105);
            this.cbbiola.Name = "cbbiola";
            this.cbbiola.Size = new System.Drawing.Size(49, 17);
            this.cbbiola.TabIndex = 2;
            this.cbbiola.Text = "Biola";
            this.cbbiola.UseVisualStyleBackColor = true;
            this.cbbiola.CheckedChanged += new System.EventHandler(this.cbbiola_CheckedChanged);
            // 
            // cbangklung
            // 
            this.cbangklung.AutoSize = true;
            this.cbangklung.Location = new System.Drawing.Point(6, 69);
            this.cbangklung.Name = "cbangklung";
            this.cbangklung.Size = new System.Drawing.Size(71, 17);
            this.cbangklung.TabIndex = 1;
            this.cbangklung.Text = "Angklung";
            this.cbangklung.UseVisualStyleBackColor = true;
            this.cbangklung.CheckedChanged += new System.EventHandler(this.cbangklung_CheckedChanged);
            // 
            // cbpiano
            // 
            this.cbpiano.AutoSize = true;
            this.cbpiano.Location = new System.Drawing.Point(6, 32);
            this.cbpiano.Name = "cbpiano";
            this.cbpiano.Size = new System.Drawing.Size(53, 17);
            this.cbpiano.TabIndex = 0;
            this.cbpiano.Text = "Piano";
            this.cbpiano.UseVisualStyleBackColor = true;
            this.cbpiano.CheckedChanged += new System.EventHandler(this.cbpiano_CheckedChanged);
            // 
            // jadwal
            // 
            this.jadwal.Controls.Add(this.rbjadwal4);
            this.jadwal.Controls.Add(this.rbjadwal3);
            this.jadwal.Controls.Add(this.rbjadwal2);
            this.jadwal.Controls.Add(this.rbjadwal1);
            this.jadwal.Location = new System.Drawing.Point(422, 211);
            this.jadwal.Name = "jadwal";
            this.jadwal.Size = new System.Drawing.Size(326, 174);
            this.jadwal.TabIndex = 7;
            this.jadwal.TabStop = false;
            this.jadwal.Text = "Pilihan Jadwal";
            this.jadwal.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbjadwal4
            // 
            this.rbjadwal4.AutoSize = true;
            this.rbjadwal4.Location = new System.Drawing.Point(18, 140);
            this.rbjadwal4.Name = "rbjadwal4";
            this.rbjadwal4.Size = new System.Drawing.Size(129, 17);
            this.rbjadwal4.TabIndex = 3;
            this.rbjadwal4.TabStop = true;
            this.rbjadwal4.Text = "Minggu, 14.00 - 17.00";
            this.rbjadwal4.UseVisualStyleBackColor = true;
            this.rbjadwal4.CheckedChanged += new System.EventHandler(this.rbjadwal4_CheckedChanged);
            // 
            // rbjadwal3
            // 
            this.rbjadwal3.AutoSize = true;
            this.rbjadwal3.Location = new System.Drawing.Point(18, 105);
            this.rbjadwal3.Name = "rbjadwal3";
            this.rbjadwal3.Size = new System.Drawing.Size(163, 17);
            this.rbjadwal3.TabIndex = 2;
            this.rbjadwal3.TabStop = true;
            this.rbjadwal3.Text = "Sabtu & Minggu, 09.00 - 11.00";
            this.rbjadwal3.UseVisualStyleBackColor = true;
            this.rbjadwal3.CheckedChanged += new System.EventHandler(this.rbjadwal3_CheckedChanged);
            // 
            // rbjadwal2
            // 
            this.rbjadwal2.AutoSize = true;
            this.rbjadwal2.Location = new System.Drawing.Point(18, 69);
            this.rbjadwal2.Name = "rbjadwal2";
            this.rbjadwal2.Size = new System.Drawing.Size(160, 17);
            this.rbjadwal2.TabIndex = 1;
            this.rbjadwal2.TabStop = true;
            this.rbjadwal2.Text = "Selasa & Kamis, 14.00 - 16.00";
            this.rbjadwal2.UseVisualStyleBackColor = true;
            this.rbjadwal2.CheckedChanged += new System.EventHandler(this.rbjadwal2_CheckedChanged);
            // 
            // rbjadwal1
            // 
            this.rbjadwal1.AutoSize = true;
            this.rbjadwal1.Location = new System.Drawing.Point(18, 32);
            this.rbjadwal1.Name = "rbjadwal1";
            this.rbjadwal1.Size = new System.Drawing.Size(150, 17);
            this.rbjadwal1.TabIndex = 0;
            this.rbjadwal1.TabStop = true;
            this.rbjadwal1.Text = "Senin & Rabu, 14.00 -16.00";
            this.rbjadwal1.UseVisualStyleBackColor = true;
            this.rbjadwal1.CheckedChanged += new System.EventHandler(this.rbjadwal1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Form Pendaftaran";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jadwal);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.cbjk);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.jadwal.ResumeLayout(false);
            this.jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.ComboBox cbjk;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.GroupBox jadwal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbkomposer;
        private System.Windows.Forms.CheckBox cbvokal;
        private System.Windows.Forms.CheckBox cbdrum;
        private System.Windows.Forms.CheckBox cbkonduktor;
        private System.Windows.Forms.CheckBox cbgitar;
        private System.Windows.Forms.CheckBox cbbiola;
        private System.Windows.Forms.CheckBox cbangklung;
        private System.Windows.Forms.CheckBox cbpiano;
        private System.Windows.Forms.RadioButton rbjadwal4;
        private System.Windows.Forms.RadioButton rbjadwal3;
        private System.Windows.Forms.RadioButton rbjadwal2;
        private System.Windows.Forms.RadioButton rbjadwal1;
    }
}

