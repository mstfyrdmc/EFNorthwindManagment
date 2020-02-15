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
    public partial class CustomersManagement : Form
    {
        public CustomersManagement()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void CustomersManagement_Load(object sender, EventArgs e)
        {
            btnKaydet.Tag = 0;
            btnKaydet.Text = "Kaydet";
            GetData();
        }
        private void GetData()
        {
            dgvListele.DataSource = db.Customers.Select(x => new
            {
                x.CustomerID,
                x.CompanyName,
                x.ContactName,
                x.ContactTitle,
                x.City,
                x.Country,
                x.Address,
                x.Phone

            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(btnKaydet.Tag) == 0)
            {
                Customer yeni = new Customer();
                yeni.Address = txtAdress.Text;
                yeni.City = txtCity.Text;
                yeni.CompanyName = txtCompanyName.Text;
                yeni.ContactName = txtContactName.Text;
                yeni.ContactTitle = txtContactTitle.Text;
                yeni.Country = txtCountry.Text;
                yeni.Phone = txtPhoneNumber.Text;

                db.Customers.Add(yeni);

                bool sonuc = db.SaveChanges() < 0;

                if (sonuc == false)
                {
                    GetData();
                    MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt işleminizde Hata Oluştu. Lütfen tekrar deneyin...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                guncellenecek.Address = txtAdress.Text;
                guncellenecek.City = txtCity.Text;
                guncellenecek.CompanyName = txtCompanyName.Text;
                guncellenecek.ContactName = txtContactName.Text;
                guncellenecek.ContactTitle = txtContactTitle.Text;
                guncellenecek.Country = txtCountry.Text;
                guncellenecek.Phone = txtPhoneNumber.Text;
                db.Entry(db.Customers.Find(guncellenecek.CustomerID)).CurrentValues.SetValues(guncellenecek);

                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetData();
                    MessageBox.Show("Müşteri güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpBilgilerCustomers.Controls);
                }
                else
                {
                    MessageBox.Show("Müşteri güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnKaydet.Tag = 0;
                btnKaydet.Text = "Kaydet";
            }
          

        }
        Customer guncellenecek = new Customer();

        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Customers.Find(id);
            guncellenecek.Address = txtAdress.Text;
            guncellenecek.City = txtCity.Text;
            guncellenecek.CompanyName = txtCompanyName.Text;
            guncellenecek.ContactName = txtContactName.Text;
            guncellenecek.ContactTitle = txtContactTitle.Text;
            guncellenecek.Country = txtCountry.Text;
            guncellenecek.Phone = txtPhoneNumber.Text;

            btnKaydet.Tag = 1;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncellenecek = db.Customers.Find(id);
            db.Customers.Remove(guncellenecek);

            bool sonuc = db.SaveChanges() > 0;
            if (sonuc == true)
            {
                GetData();
                MessageBox.Show("Müşteri güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpBilgilerCustomers.Controls);
            }
            else
            {
                MessageBox.Show("Müşteri güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
