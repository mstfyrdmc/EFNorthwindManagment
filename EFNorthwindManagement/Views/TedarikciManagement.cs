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
    public partial class TedarikciManagement : Form
    {
        public TedarikciManagement()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void TedarikciManagement_Load(object sender, EventArgs e)
        {
            btnKaydet.Tag = 0;
            btnKaydet.Text = "Kaydet";
            GetDB();
        }

        private void GetDB()
        {
           
            dgvListele.DataSource = db.Suppliers.Select(x => new
            {
                x.SupplierID,
                x.CompanyName,
                x.ContactName,
                x.ContactTitle,
                x.Address,
                x.City,
                x.Country,
                x.Phone
            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16 (btnKaydet.Tag) == 0)
            {
                Supplier yeni = new Supplier();
                yeni.CompanyName = txtSirketAdi.Text;
                yeni.ContactName = txtKontakAdi.Text;
                yeni.ContactTitle = txtKontakUnvani.Text;
                yeni.Address = txtAdress.Text;
                yeni.City = txtSehir.Text;
                yeni.Country = txtUlke.Text;
                yeni.Phone = txtTelefonNo.Text;

                db.Suppliers.Add(yeni);

                bool sonuc = db.SaveChanges() > 0;

                if (sonuc == true)
                {
                    GetDB();
                    MessageBox.Show("Tedarikçi ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgilerTedarik.Controls);
                }
                else
                {
                    MessageBox.Show("Tedarikçi ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                guncellenecek.CompanyName = txtSirketAdi.Text;
                guncellenecek.ContactName = txtKontakAdi.Text;
                guncellenecek.ContactTitle = txtKontakUnvani.Text;
                guncellenecek.Address = txtAdress.Text;
                guncellenecek.City = txtSehir.Text;
                guncellenecek.Country = txtUlke.Text;
                guncellenecek.Phone = txtTelefonNo.Text;

                db.Entry(db.Suppliers.Find(guncellenecek.SupplierID)).CurrentValues.SetValues(guncellenecek);
                bool sonuc = db.SaveChanges() > 0;

                if (sonuc == true)
                {
                    GetDB();
                    MessageBox.Show("Tedarikçi güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgilerTedarik.Controls);
                }
                else
                {
                    MessageBox.Show("Tedarikçi güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnKaydet.Text = "Kaydet";
                btnKaydet.Tag = 0;
            }
        }
        Supplier guncellenecek = new Supplier();
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Suppliers.Find(id);
            guncellenecek.CompanyName = txtSirketAdi.Text;
            guncellenecek.ContactName = txtKontakAdi.Text;
            guncellenecek.ContactTitle = txtKontakUnvani.Text;
            guncellenecek.Address = txtAdress.Text;
            guncellenecek.City = txtSehir.Text;
            guncellenecek.Country = txtUlke.Text;
            guncellenecek.Phone = txtTelefonNo.Text;

            btnKaydet.Tag = 1;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( dgvListele.SelectedRows[0].Cells[0].Value);

             Supplier silinecek = new Supplier();
            silinecek = db.Suppliers.Find(id);
            db.Suppliers.Remove(silinecek);
            //db.Entry(db.Suppliers.Find(silinecek.SupplierID)).CurrentValues.SetValues(silinecek);
            //silinecek= db.Suppliers.Find()

            bool sonuc = db.SaveChanges() > 0;

            if (sonuc == true)
            {
                GetDB();
                MessageBox.Show("Tedarikçi silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpBilgilerTedarik.Controls);
            }
            else
            {
                MessageBox.Show("Tedarikçi silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    
}
