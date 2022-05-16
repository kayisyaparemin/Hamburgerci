namespace Hamburgerci
{
    partial class SiparisOlusturForm
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
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpEkstralar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSiparisAdet = new System.Windows.Forms.NumericUpDown();
            this.grbBoyutlar = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.grbMenuler = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparişTamamla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiparisAdet)).BeginInit();
            this.grbBoyutlar.SuspendLayout();
            this.grbMenuler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(2, 43);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(346, 33);
            this.cmbMenuler.TabIndex = 2;
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.BackColor = System.Drawing.SystemColors.Info;
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.ItemHeight = 25;
            this.lbxSiparisler.Location = new System.Drawing.Point(375, 31);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(783, 579);
            this.lbxSiparisler.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSiparisEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudSiparisAdet);
            this.groupBox1.Controls.Add(this.grbBoyutlar);
            this.groupBox1.Controls.Add(this.grbMenuler);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 721);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpEkstralar);
            this.groupBox2.Location = new System.Drawing.Point(6, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 205);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Seçin";
            // 
            // flpEkstralar
            // 
            this.flpEkstralar.AutoScroll = true;
            this.flpEkstralar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEkstralar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEkstralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpEkstralar.Location = new System.Drawing.Point(3, 28);
            this.flpEkstralar.Name = "flpEkstralar";
            this.flpEkstralar.Size = new System.Drawing.Size(327, 174);
            this.flpEkstralar.TabIndex = 0;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSiparisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisEkle.Location = new System.Drawing.Point(36, 643);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(255, 61);
            this.btnSiparisEkle.TabIndex = 10;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 592);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADET";
            // 
            // nudSiparisAdet
            // 
            this.nudSiparisAdet.Location = new System.Drawing.Point(100, 590);
            this.nudSiparisAdet.Name = "nudSiparisAdet";
            this.nudSiparisAdet.Size = new System.Drawing.Size(181, 32);
            this.nudSiparisAdet.TabIndex = 9;
            this.nudSiparisAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbBoyutlar
            // 
            this.grbBoyutlar.Controls.Add(this.rbBuyuk);
            this.grbBoyutlar.Controls.Add(this.rbOrta);
            this.grbBoyutlar.Controls.Add(this.rbKucuk);
            this.grbBoyutlar.Location = new System.Drawing.Point(6, 296);
            this.grbBoyutlar.Name = "grbBoyutlar";
            this.grbBoyutlar.Size = new System.Drawing.Size(342, 79);
            this.grbBoyutlar.TabIndex = 7;
            this.grbBoyutlar.TabStop = false;
            this.grbBoyutlar.Text = "Boyut Seçin";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(172, 47);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(91, 30);
            this.rbBuyuk.TabIndex = 6;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(94, 47);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(72, 30);
            this.rbOrta.TabIndex = 6;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(8, 47);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(91, 30);
            this.rbKucuk.TabIndex = 6;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // grbMenuler
            // 
            this.grbMenuler.Controls.Add(this.cmbMenuler);
            this.grbMenuler.Location = new System.Drawing.Point(0, 208);
            this.grbMenuler.Name = "grbMenuler";
            this.grbMenuler.Size = new System.Drawing.Size(357, 82);
            this.grbMenuler.TabIndex = 6;
            this.grbMenuler.TabStop = false;
            this.grbMenuler.Text = "Menü Seçin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = global::Hamburgerci.Properties.Resources.TzjgX93BLmHbKXIc_637497622071664663;
            this.pictureBox1.Image = global::Hamburgerci.Properties.Resources.TzjgX93BLmHbKXIc_6374976220716646631;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(471, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.Brown;
            this.lblTutar.Location = new System.Drawing.Point(696, 681);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 37);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "0";
            // 
            // btnSiparişTamamla
            // 
            this.btnSiparişTamamla.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSiparişTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparişTamamla.ForeColor = System.Drawing.Color.Black;
            this.btnSiparişTamamla.Location = new System.Drawing.Point(840, 657);
            this.btnSiparişTamamla.Name = "btnSiparişTamamla";
            this.btnSiparişTamamla.Size = new System.Drawing.Size(255, 61);
            this.btnSiparişTamamla.TabIndex = 10;
            this.btnSiparişTamamla.Text = "Siparişi Tamamla";
            this.btnSiparişTamamla.UseVisualStyleBackColor = false;
            this.btnSiparişTamamla.Click += new System.EventHandler(this.btnSiparişTamamla_Click);
            // 
            // SiparisOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1171, 758);
            this.Controls.Add(this.btnSiparişTamamla);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxSiparisler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SiparisOlusturForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Siparis Olustur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSiparisAdet)).EndInit();
            this.grbBoyutlar.ResumeLayout(false);
            this.grbBoyutlar.PerformLayout();
            this.grbMenuler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbMenuler;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSiparisAdet;
        private System.Windows.Forms.GroupBox grbBoyutlar;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSiparişTamamla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpEkstralar;
    }
}

