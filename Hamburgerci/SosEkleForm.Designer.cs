namespace Hamburgerci
{
    partial class SosEkleForm
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
            this.btnYeniMenuKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkleSosAdi = new System.Windows.Forms.TextBox();
            this.nudEkleSosFiyati = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkleSosFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniMenuKaydet
            // 
            this.btnYeniMenuKaydet.Location = new System.Drawing.Point(202, 232);
            this.btnYeniMenuKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnYeniMenuKaydet.Name = "btnYeniMenuKaydet";
            this.btnYeniMenuKaydet.Size = new System.Drawing.Size(209, 79);
            this.btnYeniMenuKaydet.TabIndex = 9;
            this.btnYeniMenuKaydet.Text = "EKSTRA MALZEME KAYDET";
            this.btnYeniMenuKaydet.UseVisualStyleBackColor = true;
            this.btnYeniMenuKaydet.Click += new System.EventHandler(this.btnYeniMenuKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(164, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ekstra Malzeme Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // txtEkleSosAdi
            // 
            this.txtEkleSosAdi.Location = new System.Drawing.Point(228, 123);
            this.txtEkleSosAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtEkleSosAdi.Name = "txtEkleSosAdi";
            this.txtEkleSosAdi.Size = new System.Drawing.Size(306, 29);
            this.txtEkleSosAdi.TabIndex = 4;
            // 
            // nudEkleSosFiyati
            // 
            this.nudEkleSosFiyati.DecimalPlaces = 2;
            this.nudEkleSosFiyati.Location = new System.Drawing.Point(228, 167);
            this.nudEkleSosFiyati.Name = "nudEkleSosFiyati";
            this.nudEkleSosFiyati.Size = new System.Drawing.Size(306, 29);
            this.nudEkleSosFiyati.TabIndex = 10;
            // 
            // SosEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 368);
            this.Controls.Add(this.nudEkleSosFiyati);
            this.Controls.Add(this.btnYeniMenuKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkleSosAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SosEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SosEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudEkleSosFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniMenuKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEkleSosAdi;
        private System.Windows.Forms.NumericUpDown nudEkleSosFiyati;
    }
}