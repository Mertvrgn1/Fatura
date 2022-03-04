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
    public partial class FrmYfatura : Form
    {
        public FrmYfatura()
        {
            InitializeComponent();
        }
        FatDbEntities db = new FatDbEntities();
        

        private void FrmYfatura_Load(object sender, EventArgs e)
        {
            Combo();
           
        }

        private void Fmaster()
        {
            FatMaster fm = new FatMaster();
            fm.Tarih = DateTime.Now;
            fm.MusteriId = (int)cbMusteri.SelectedValue;
            db.Set<FatMaster>().Add(fm);
            db.SaveChanges();
            frmFat frm = new frmFat(fm.FatNo,false);
            frm.Show();

        }

        private void Combo()
        {
            cbMusteri.DataSource = db.Set<Musteri>().Select(x => new
            {
                x.MusteriId,
                x.MusteriAd
            }).ToList();
            cbMusteri.DisplayMember = "MusteriAd";
            cbMusteri.ValueMember = "MusteriId";

      
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Fmaster();
        }
    }
}
