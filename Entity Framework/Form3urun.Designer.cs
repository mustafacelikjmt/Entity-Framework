namespace Entity_Framework
{
    partial class Form3urun
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
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxdurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonlist = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxkategori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(108, 56);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(197, 26);
            this.textBoxad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // textBoxmarka
            // 
            this.textBoxmarka.Location = new System.Drawing.Point(108, 92);
            this.textBoxmarka.Name = "textBoxmarka";
            this.textBoxmarka.Size = new System.Drawing.Size(197, 26);
            this.textBoxmarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // textBoxstok
            // 
            this.textBoxstok.Location = new System.Drawing.Point(108, 128);
            this.textBoxstok.Name = "textBoxstok";
            this.textBoxstok.Size = new System.Drawing.Size(197, 26);
            this.textBoxstok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok:";
            // 
            // textBoxfiyat
            // 
            this.textBoxfiyat.Location = new System.Drawing.Point(108, 164);
            this.textBoxfiyat.Name = "textBoxfiyat";
            this.textBoxfiyat.Size = new System.Drawing.Size(197, 26);
            this.textBoxfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // textBoxdurum
            // 
            this.textBoxdurum.Location = new System.Drawing.Point(108, 200);
            this.textBoxdurum.Name = "textBoxdurum";
            this.textBoxdurum.Size = new System.Drawing.Size(197, 26);
            this.textBoxdurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori:";
            // 
            // buttonlist
            // 
            this.buttonlist.Location = new System.Drawing.Point(311, 23);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(132, 43);
            this.buttonlist.TabIndex = 14;
            this.buttonlist.Text = "Listele";
            this.buttonlist.UseVisualStyleBackColor = true;
            this.buttonlist.Click += new System.EventHandler(this.buttonlist_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(311, 72);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(132, 43);
            this.buttonadd.TabIndex = 15;
            this.buttonadd.Text = "Ekle";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(311, 121);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(132, 43);
            this.buttondelete.TabIndex = 16;
            this.buttondelete.Text = "Sil";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(311, 170);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(132, 44);
            this.buttonupdate.TabIndex = 17;
            this.buttonupdate.Text = "Güncelle";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(311, 220);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(132, 45);
            this.buttonclear.TabIndex = 18;
            this.buttonclear.Text = "Temizle";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 264);
            this.dataGridView1.TabIndex = 19;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(108, 20);
            this.maskedTextBoxID.Mask = "000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(197, 26);
            this.maskedTextBoxID.TabIndex = 20;
            this.maskedTextBoxID.ValidatingType = typeof(int);
            // 
            // comboBoxkategori
            // 
            this.comboBoxkategori.FormattingEnabled = true;
            this.comboBoxkategori.Location = new System.Drawing.Point(108, 236);
            this.comboBoxkategori.Name = "comboBoxkategori";
            this.comboBoxkategori.Size = new System.Drawing.Size(197, 28);
            this.comboBoxkategori.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Son İşlem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 23;
            // 
            // Form3urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 548);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxkategori);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonlist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3urun";
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.Form3urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxdurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonlist;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.ComboBox comboBoxkategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}