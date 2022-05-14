namespace Hamburgerci
{
    partial class MenuEkleForm
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
            this.txtEkleMenuAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniMenuKaydet = new System.Windows.Forms.Button();
            this.nudEklEMenuFiyati = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEklEMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEkleMenuAdi
            // 
            this.txtEkleMenuAdi.Location = new System.Drawing.Point(141, 85);
            this.txtEkleMenuAdi.Name = "txtEkleMenuAdi";
            this.txtEkleMenuAdi.Size = new System.Drawing.Size(252, 26);
            this.txtEkleMenuAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menü Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyatı";
            // 
            // btnYeniMenuKaydet
            // 
            this.btnYeniMenuKaydet.Location = new System.Drawing.Point(141, 185);
            this.btnYeniMenuKaydet.Name = "btnYeniMenuKaydet";
            this.btnYeniMenuKaydet.Size = new System.Drawing.Size(252, 71);
            this.btnYeniMenuKaydet.TabIndex = 3;
            this.btnYeniMenuKaydet.Text = "MENÜ KAYDET";
            this.btnYeniMenuKaydet.UseVisualStyleBackColor = true;
            this.btnYeniMenuKaydet.Click += new System.EventHandler(this.btnYeniMenuKaydet_Click);
            // 
            // nudEklEMenuFiyati
            // 
            this.nudEklEMenuFiyati.DecimalPlaces = 2;
            this.nudEklEMenuFiyati.Location = new System.Drawing.Point(141, 137);
            this.nudEklEMenuFiyati.Name = "nudEklEMenuFiyati";
            this.nudEklEMenuFiyati.Size = new System.Drawing.Size(252, 26);
            this.nudEklEMenuFiyati.TabIndex = 4;
            // 
            // MenuEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 292);
            this.Controls.Add(this.nudEklEMenuFiyati);
            this.Controls.Add(this.btnYeniMenuKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkleMenuAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudEklEMenuFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkleMenuAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniMenuKaydet;
        private System.Windows.Forms.NumericUpDown nudEklEMenuFiyati;
    }
}