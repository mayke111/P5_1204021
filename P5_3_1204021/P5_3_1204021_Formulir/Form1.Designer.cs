namespace P5_3_1204021_Formulir
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.thak = new System.Windows.Forms.TextBox();
            this.lk = new System.Windows.Forms.RadioButton();
            this.pr = new System.Windows.Forms.RadioButton();
            this.progcb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.semes = new P5_3_1204021.NumericTB();
            this.NIM = new P5_3_1204021.NumericTB();
            this.alamat = new System.Windows.Forms.TextBox();
            this.kuri = new System.Windows.Forms.GroupBox();
            this.k2014 = new System.Windows.Forms.RadioButton();
            this.k2010 = new System.Windows.Forms.RadioButton();
            this.k2006 = new System.Windows.Forms.RadioButton();
            this.matkul = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pem1 = new System.Windows.Forms.CheckBox();
            this.mtk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nama = new P5_3_1204021_Formulir.CharTB();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.kuri.SuspendLayout();
            this.matkul.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM                  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama               :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat              :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Program Studi       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tahun Akademik  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Semester               : ";
            // 
            // thak
            // 
            this.thak.Location = new System.Drawing.Point(520, 102);
            this.thak.Name = "thak";
            this.thak.Size = new System.Drawing.Size(167, 20);
            this.thak.TabIndex = 9;
            this.thak.TextChanged += new System.EventHandler(this.thak_TextChanged);
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.Location = new System.Drawing.Point(134, 130);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(70, 17);
            this.lk.TabIndex = 10;
            this.lk.TabStop = true;
            this.lk.Text = "Laki - laki";
            this.lk.UseVisualStyleBackColor = true;
            // 
            // pr
            // 
            this.pr.AutoSize = true;
            this.pr.Location = new System.Drawing.Point(238, 130);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(79, 17);
            this.pr.TabIndex = 11;
            this.pr.TabStop = true;
            this.pr.Text = "Perempuan";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // progcb
            // 
            this.progcb.FormattingEnabled = true;
            this.progcb.Items.AddRange(new object[] {
            "D3",
            "D4",
            "S1",
            "S2",
            "S3"});
            this.progcb.Location = new System.Drawing.Point(521, 75);
            this.progcb.Name = "progcb";
            this.progcb.Size = new System.Drawing.Size(166, 21);
            this.progcb.TabIndex = 12;
            this.progcb.Text = "     - Pilih Program Studi -";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(547, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Pilih Mata Kuliah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // semes
            // 
            this.semes.Location = new System.Drawing.Point(520, 130);
            this.semes.Name = "semes";
            this.semes.Size = new System.Drawing.Size(167, 20);
            this.semes.TabIndex = 15;
            // 
            // NIM
            // 
            this.NIM.Location = new System.Drawing.Point(134, 74);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(183, 20);
            this.NIM.TabIndex = 14;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(134, 158);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(183, 43);
            this.alamat.TabIndex = 8;
            // 
            // kuri
            // 
            this.kuri.Controls.Add(this.k2014);
            this.kuri.Controls.Add(this.k2010);
            this.kuri.Controls.Add(this.k2006);
            this.kuri.Location = new System.Drawing.Point(54, 239);
            this.kuri.Name = "kuri";
            this.kuri.Size = new System.Drawing.Size(200, 161);
            this.kuri.TabIndex = 17;
            this.kuri.TabStop = false;
            this.kuri.Text = "Kurikulum Pilihan";
            // 
            // k2014
            // 
            this.k2014.AutoSize = true;
            this.k2014.Location = new System.Drawing.Point(20, 109);
            this.k2014.Name = "k2014";
            this.k2014.Size = new System.Drawing.Size(93, 17);
            this.k2014.TabIndex = 2;
            this.k2014.TabStop = true;
            this.k2014.Text = "Kurikurul 2014";
            this.k2014.UseVisualStyleBackColor = true;
            // 
            // k2010
            // 
            this.k2010.AutoSize = true;
            this.k2010.Location = new System.Drawing.Point(20, 71);
            this.k2010.Name = "k2010";
            this.k2010.Size = new System.Drawing.Size(98, 17);
            this.k2010.TabIndex = 1;
            this.k2010.TabStop = true;
            this.k2010.Text = "Kurikulum 2010";
            this.k2010.UseVisualStyleBackColor = true;
            // 
            // k2006
            // 
            this.k2006.AutoSize = true;
            this.k2006.Location = new System.Drawing.Point(20, 33);
            this.k2006.Name = "k2006";
            this.k2006.Size = new System.Drawing.Size(98, 17);
            this.k2006.TabIndex = 0;
            this.k2006.TabStop = true;
            this.k2006.Text = "Kurikulum 2006";
            this.k2006.UseVisualStyleBackColor = true;
            // 
            // matkul
            // 
            this.matkul.Controls.Add(this.checkBox9);
            this.matkul.Controls.Add(this.checkBox10);
            this.matkul.Controls.Add(this.checkBox11);
            this.matkul.Controls.Add(this.checkBox12);
            this.matkul.Controls.Add(this.checkBox5);
            this.matkul.Controls.Add(this.checkBox6);
            this.matkul.Controls.Add(this.checkBox7);
            this.matkul.Controls.Add(this.checkBox8);
            this.matkul.Controls.Add(this.checkBox4);
            this.matkul.Controls.Add(this.checkBox3);
            this.matkul.Controls.Add(this.pem1);
            this.matkul.Controls.Add(this.mtk);
            this.matkul.Location = new System.Drawing.Point(278, 239);
            this.matkul.Name = "matkul";
            this.matkul.Size = new System.Drawing.Size(425, 161);
            this.matkul.TabIndex = 18;
            this.matkul.TabStop = false;
            this.matkul.Text = "Mata Kuliah Pilihan";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(269, 102);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(148, 17);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Manajemen Rental Pasok";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(269, 79);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(90, 17);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "Sistem Oprasi";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(269, 56);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(114, 17);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "Jaringan Komputer";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(269, 33);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(114, 17);
            this.checkBox12.TabIndex = 8;
            this.checkBox12.Text = "Pengantar Logistik";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(129, 102);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Pemrograman 7";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(129, 79);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Pemrograman 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(129, 56);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 17);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Pemrograman 5";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(129, 33);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(100, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Pemrograman 4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Pemrograman 3";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Pemrograman 2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // pem1
            // 
            this.pem1.AutoSize = true;
            this.pem1.Location = new System.Drawing.Point(7, 56);
            this.pem1.Name = "pem1";
            this.pem1.Size = new System.Drawing.Size(100, 17);
            this.pem1.TabIndex = 1;
            this.pem1.Text = "Pemrograman 1";
            this.pem1.UseVisualStyleBackColor = true;
            // 
            // mtk
            // 
            this.mtk.AutoSize = true;
            this.mtk.Location = new System.Drawing.Point(7, 33);
            this.mtk.Name = "mtk";
            this.mtk.Size = new System.Drawing.Size(81, 17);
            this.mtk.TabIndex = 0;
            this.mtk.Text = "Matematika";
            this.mtk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(134, 104);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(183, 20);
            this.nama.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.matkul);
            this.Controls.Add(this.kuri);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.semes);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progcb);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.thak);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Matakuliah Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.kuri.ResumeLayout(false);
            this.kuri.PerformLayout();
            this.matkul.ResumeLayout(false);
            this.matkul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox thak;
        private System.Windows.Forms.RadioButton lk;
        private System.Windows.Forms.RadioButton pr;
        private System.Windows.Forms.ComboBox progcb;
        private System.Windows.Forms.Button button1;
        private P5_3_1204021.NumericTB NIM;
        private P5_3_1204021.NumericTB semes;
        private System.Windows.Forms.ErrorProvider epWarning;
        private CharTB nama;
        private System.Windows.Forms.GroupBox matkul;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox pem1;
        private System.Windows.Forms.CheckBox mtk;
        private System.Windows.Forms.GroupBox kuri;
        private System.Windows.Forms.RadioButton k2014;
        private System.Windows.Forms.RadioButton k2010;
        private System.Windows.Forms.RadioButton k2006;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

