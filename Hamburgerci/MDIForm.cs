using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    //deneme
    public partial class MDIForm : Form
    {
        public  static List<Siparis> _siparisler;
        public MDIForm()
        {
            InitializeComponent();
            _siparisler = SiparisOlusturForm.TumSiparisler;
        }
        
        public void LoadForm(Form ChildForm)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            this.Width = ChildForm.Width +20;
            this.Height = ChildForm.Height+67;
            ChildForm.MdiParent = this;
            this.ActivateMdiChild(ChildForm);
            ChildForm.Show();
        
    }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new SiparisOlusturForm());
        }
        

        private void siparişListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new SiparisListeleForm(_siparisler));
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new MenuEkleForm());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new SosEkleForm());
        }
    }
}

