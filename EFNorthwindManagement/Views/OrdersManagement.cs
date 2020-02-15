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
    public partial class OrdersManagement : Form
    {
        public OrdersManagement()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        
        private void OrdersManagement_Load(object sender, EventArgs e)
        {
            btnKaydet.Tag = 0;
            btnKaydet.Text = "Kaydet";
            GetData();
        }

        private void GetData()
        {
            dgvListele.DataSource = db.Orders.Select(x => new
            {
                x.OrderID,
                x.Freight,
                x.OrderDate,
                x.RequiredDate,
                x.ShipAddress,
                x.ShipCity,
                x.ShipCountry,
                x.ShipName,
                x.ShippedDate,
                x.ShipVia
            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16( btnKaydet.Tag) == 0)
            {
                Order yeni = new Order();
                yeni.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                yeni.ShippedDate = Convert.ToDateTime(txtShippedDate.Text);
                yeni.Freight = Convert.ToDecimal(txtFreight.Text);
                yeni.ShipName = txtShipName.Text;
                yeni.ShipAddress = txtShipAdress.Text;
                yeni.ShipCity = txtShipCity.Text;
                yeni.ShipCountry = txtShipCountry.Text;

                db.Orders.Add(yeni);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetData();
                    MessageBox.Show("Sipariş Kayıt işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpOrderBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Sipariş Kayıt işleminiz esnasında bir hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                
                guncelle.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                guncelle.ShippedDate = Convert.ToDateTime(txtShippedDate.Text);
                guncelle.Freight = Convert.ToDecimal(txtFreight.Text);
                guncelle.ShipName = txtShipName.Text;
                guncelle.ShipAddress = txtShipAdress.Text;
                guncelle.ShipCity = txtShipCity.Text;
                guncelle.ShipCountry = txtShipCountry.Text;

                db.Entry(db.Orders.Find(guncelle.OrderID)).CurrentValues.SetValues(guncelle);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc == true)
                {
                    GetData();
                    MessageBox.Show("Sipariş güncelleme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FxFunction.Temizle(grpOrderBilgiler.Controls);
                }
                else
                {
                    MessageBox.Show("Sipariş güncelleme işleminiz esnasında bir hata oluştu. Lütfen tekrar deneyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnKaydet.Tag = 0;
                btnKaydet.Text = "Kaydet";
            }
            


        }
        Order guncelle = new Order();
        private void dgvListele_DoubleClick(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncelle = db.Orders.Find(id);
            guncelle.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            guncelle.ShippedDate = Convert.ToDateTime(txtShippedDate.Text);
            guncelle.Freight = Convert.ToDecimal(txtFreight.Text);
            guncelle.ShipName = txtShipName.Text;
            guncelle.ShipAddress = txtShipAdress.Text;
            guncelle.ShipCity = txtShipCity.Text;
            guncelle.ShipCountry = txtShipCountry.Text;

            btnKaydet.Tag = 1;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgvListele.SelectedRows[0].Cells[0].Value);
            guncelle = db.Orders.Find(id);
            db.Orders.Remove(guncelle);
            bool sonuc = db.SaveChanges() > 0;
            if (sonuc == true)
            {
                GetData();
                MessageBox.Show("Sipariş silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FxFunction.Temizle(grpOrderBilgiler.Controls);
            }
            else
            {
                MessageBox.Show("Sipariş silme işleminiz başarıyla gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
