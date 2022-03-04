using Fatura.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura.Forms
{
    public partial class frmSehir : Form
    {
        public frmSehir()
        {
            InitializeComponent();
        }

        FatDbEntities db =new FatDbEntities();
        Sehir secSehir;
        

        private void frmSehir_Load(object sender, EventArgs e)
        {
            

            Doldur();
            
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Sehir>().Select(x => new
            {
                Id=x.SehirId,
                Ad=x.SehirAd

            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int secId = (int)(dataGridView1.CurrentRow.Cells[0].Value);
            secSehir = db.Set<Sehir>().Find(secId);
            txSehirAd.Text = secSehir.SehirAd;
            txSehirId.Text = secSehir.SehirId.ToString();
            
        }

        private void txEkle_Click(object sender, EventArgs e)
        {

            Sehir sehir = new Sehir();
            sehir.SehirAd = txSehirAd.Text;
            sehir.SehirId =Convert.ToInt32 (txSehirId.Text);
            db.Set<Sehir>().Add(sehir);
            db.SaveChanges();
            Doldur();
        }
    }
}
