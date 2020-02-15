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
    public partial class CatagoryManagement : Form
    {
        public CatagoryManagement()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();


        private void CatagoryManagement_Load(object sender, EventArgs e)
        {
            btnKaydet.Tag = 0;
            btnKaydet.Text = "Kaydet";
            // GetDB();
            dgvListele.DataSource = db.Categories.ToList();

        }

        private void GetDB(List<Category> Category)
        {
            dgvListele.DataSource = db.Categories.Select(x => new
            {
                x.CategoryName,
                x.Description,
                x.Picture
            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(btnKaydet.Tag) == 0)
            {
                Category yeni = new Category();
                yeni.CategoryName = txtKatagoriAdi.Text;
                yeni.Description = txtTanim.Text;

                db.Categories.Add(yeni);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetDB(db.Categories.ToList());
                    MessageBox.Show("Katagori ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgilerKatagori.Controls);
                }
                else
                {
                    MessageBox.Show("Katagori ekleme işleminizde hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                guncellenecek.CategoryName = txtKatagoriAdi.Text;
                guncellenecek.Description = txtTanim.Text;
                db.Entry(db.Categories.Find(guncellenecek.CategoryID)).CurrentValues.SetValues(guncellenecek);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc)
                {
                    GetDB(db.Categories.ToList());
                    MessageBox.Show("Katagori güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgilerKatagori.Controls);
                }
                else
                {
                    MessageBox.Show("Katagori güncelleme işleminiz yapılamamıştır.Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnKaydet.Text = "Kaydet";
                btnKaydet.Tag = 0;
            }

        }
        Category guncellenecek;
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);

            guncellenecek = db.Categories.Find(id);
            txtKatagoriAdi.Text = guncellenecek.CategoryName;
            txtTanim.Text = guncellenecek.Description;

            btnKaydet.Tag = 1;
            btnKaydet.Text = "Güncelle";
        }



        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            GetDB(db.Categories.Where(x => x.CategoryName.Contains(txtAra.Text) && x.Description.Contains(txtAra.Text)).ToList());
        }

        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Categories.Find(id);
            db.Categories.Remove(guncellenecek);
            //Category silinecek = db.Categories.Find(id);

            //db.Entry(db.Categories.Find(silinecek.CategoryID)).CurrentValues.SetValues(silinecek);

            bool sonuc = db.SaveChanges() > 0;
            if (sonuc)
            {
                GetDB(db.Categories.ToList());
                MessageBox.Show("Katagori silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpBilgilerKatagori.Controls);
            }
            else
            {
                MessageBox.Show("Katagori silme işleminiz yapılamamıştır.Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
