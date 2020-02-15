using EFNorthwindManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFNorthwindManagement.Views
{
    public partial class KargoFirmalarıManagement : Form
    {
        public KargoFirmalarıManagement()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities(); 
        private void KargoFirmalarıManagement_Load(object sender, EventArgs e)
        {
            btnKaydet.Tag = 0;
            btnKaydet.Text = "Kaydet";
            GetData();
        }

        private void GetData()
        {
            dgvListele.DataSource = db.Shippers.Select(x => new
            {
                x.ShipperID,
                x.CompanyName,
                x.Phone
            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16( btnKaydet.Tag)==0)
            {
                Shipper yeni = new Shipper();
                yeni.CompanyName = txtSirketAdi.Text;
                yeni.Phone = txtTelefonNo.Text;

                db.Shippers.Add(yeni);

                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetData();
                    MessageBox.Show("Kargo ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpKargoFirmalarıBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Kargo ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                guncellenecek.CompanyName = txtSirketAdi.Text;
                guncellenecek.Phone = txtTelefonNo.Text;

                db.Entry(db.Shippers.Find(guncellenecek.ShipperID)).CurrentValues.SetValues(guncellenecek);

                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetData();
                    MessageBox.Show("Kargo güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpKargoFirmalarıBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Kargo güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnKaydet.Tag = 0;
                btnKaydet.Text = "Kaydet";
            }
           
        }
        Shipper guncellenecek = new Shipper();
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Shippers.Find(id);
            guncellenecek.CompanyName = txtSirketAdi.Text;
            guncellenecek.Phone = txtTelefonNo.Text;

            btnKaydet.Tag = 1;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Shippers.Find(id);
            db.Shippers.Remove(guncellenecek);

            bool sonuc = db.SaveChanges() > 0;
            if (sonuc == true)
            {
                GetData();
                MessageBox.Show("Kargo güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpKargoFirmalarıBilgiler.Controls);
            }
            else
            {
                MessageBox.Show("Kargo güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
