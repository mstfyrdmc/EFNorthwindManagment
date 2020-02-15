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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            btnIslem.Tag = 0;
            btnIslem.Text = "Kaydet";

            GetData(db.Products.Where(x => x.Discontinued == false).ToList());

            cbKategoriler.DataSource = db.Categories.ToList();
            cbKategoriler.DisplayMember = "CategoryName";
            cbKategoriler.ValueMember = "CategoryID";

            cbTedarikciler.DataSource = db.Suppliers.ToList();
        }

        private void GetData(List<Product> products)
        {
            dgvListele.DataSource = products.Select(x => new {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock,
                x.Category.CategoryName,
                x.Supplier.CompanyName
            }).ToList();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnIslem.Tag) == 0)
            {
                Product yeni = new Product();
                yeni.ProductName = txtUrunAdi.Text;
                yeni.UnitPrice = nmrFiyat.Value;
                yeni.UnitsInStock = Convert.ToInt16(nmrStokMiktari.Value);
                yeni.Category = (Category)cbKategoriler.SelectedItem;
                yeni.Supplier = (Supplier)cbTedarikciler.SelectedItem;

                db.Products.Add(yeni);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc)
                {
                    GetData(db.Products.Where(x => x.Discontinued == false).ToList());
                    MessageBox.Show("Ürün ekleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Ürün ekleme işleminiz sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                guncellenecek.ProductName = txtUrunAdi.Text;
                guncellenecek.UnitPrice = nmrFiyat.Value;
                guncellenecek.UnitsInStock = Convert.ToInt16(nmrStokMiktari.Value);
                guncellenecek.Category = (Category)cbKategoriler.SelectedItem;
                guncellenecek.Supplier = (Supplier)cbTedarikciler.SelectedItem;

                db.Entry(db.Products.Find(guncellenecek.ProductID)).CurrentValues.SetValues(guncellenecek);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc)
                {
                    GetData(db.Products.Where(x => x.Discontinued == false).ToList());
                    MessageBox.Show("Ürün güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Ürün güncelleme işleminiz sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnIslem.Text = "Kaydet";
                btnIslem.Tag = 0;
            }
        }

        Product guncellenecek;
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);

            guncellenecek = db.Products.Find(id);
            txtUrunAdi.Text = guncellenecek.ProductName;
            nmrFiyat.Value = Convert.ToInt32(guncellenecek.UnitPrice);
            nmrStokMiktari.Value = Convert.ToInt32(guncellenecek.UnitsInStock);
            cbKategoriler.SelectedItem = guncellenecek.Category;
            cbTedarikciler.SelectedItem = guncellenecek.Supplier;



            btnIslem.Tag = 1;
            btnIslem.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);

            Product silinecek = db.Products.Find(id);
            silinecek.Discontinued = true;

            db.Entry(db.Products.Find(silinecek.ProductID)).CurrentValues.SetValues(silinecek);
            bool sonuc = db.SaveChanges() > 0;
            if (sonuc)
            {
                GetData(db.Products.Where(x => x.Discontinued == false).ToList());
                MessageBox.Show("Ürün silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpBilgiler.Controls);
            }
            else
            {
                MessageBox.Show("Ürün silme işleminiz sırasında bir hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            GetData(db.Products.Where(x => x.ProductName.Contains(txtArama.Text) && x.Discontinued == false).ToList());
        }
    }
}
