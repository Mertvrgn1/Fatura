using Fatura.Context;
using Fatura.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FatDbEntities db = new FatDbEntities();
        Label lb = new Label();
        TextBox txFatno = new TextBox();
        Button btnOk = new Button();

        private void ilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehir frm = new frmSehir();
            frm.Show();

        }

        private void ilçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlce frm = new frmIlce();
            frm.Show();

        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrun frm = new frmUrun();
            frm.Show();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            frm.Show();
        }

        private void birimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBirim frm = new frmBirim();
            frm.Show();
        }

        private void görüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            btnOk.Text = "Ok";
            lb.Text = "Fatura No";
            this.flowLayoutPanel1.Controls.Add(lb);
            flowLayoutPanel1.Controls.Add(txFatno);
            flowLayoutPanel1.Controls.Add(btnOk);
            btnOk.Click += BtnOk_Click;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            FatMaster fm = db.Set<FatMaster>().Find(Convert.ToInt32(txFatno.Text));
            if (fm == null)
            {
                MessageBox.Show("Böyle Fatura yok.");
            }
            else
            {
                if (fm.Sevk_Tarihi == null)
                {
                    frmFat frm = new frmFat(fm.FatNo,false);
                    frm.Show();
                }
                else
                {
                    frmFat frm = new frmFat(fm.FatNo, true);
                    frm.Show();
                }
               
            }
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYfatura frm = new FrmYfatura();
            frm.Show();
        }
    }
}
