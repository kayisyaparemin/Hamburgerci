﻿namespace Hamburgerci
{
    partial class MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.siparişListeleToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.siparişOluşturToolStripMenuItem_Click);
            // 
            // siparişListeleToolStripMenuItem
            // 
            this.siparişListeleToolStripMenuItem.Name = "siparişListeleToolStripMenuItem";
            this.siparişListeleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparişListeleToolStripMenuItem.Text = "Sipariş Listele";
            this.siparişListeleToolStripMenuItem.Click += new System.EventHandler(this.siparişListeleToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüEkleToolStripMenuItem,
            this.ekstraMalzemeEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            this.menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            this.menüEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menüEkleToolStripMenuItem.Text = "Menü Ekle";
            this.menüEkleToolStripMenuItem.Click += new System.EventHandler(this.menüEkleToolStripMenuItem_Click);
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            this.ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            this.ekstraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            this.ekstraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraMalzemeEkleToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 610);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}