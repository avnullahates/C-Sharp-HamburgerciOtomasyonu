using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class MyMdiForm : Form
    {
        public MyMdiForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childform)
        {
            this.Width = childform.Width + 21;
            this.Height = childform.Height + 70;

            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    form.Dock = DockStyle.Fill;
                    form.Activate();
                }
                else                
                    form.Close();                
            }
            if (durum == false)
            {                
                childform.MdiParent = this;
                childform.Dock = DockStyle.Fill;
                childform.Show();
            }          
                        
        }


        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {        
            ChildForm(new SiparisOlusturForm());
        }

        private void tsmSpiarisBilgiler_Click(object sender, EventArgs e)
        {
            ChildForm(new TumSiparislerForm());
        }

        private void tsmMenuEkleme_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuBilgileriForm());
        }

        private void tsmExtraEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new ExtraMalzemeForm());
        }
    }
}
