using EFNorthwindManagement.Models;
using EFNorthwindManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFNorthwindManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı veya şifrenizi girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (db.Employees.Any(x => x.FirstName == txtKullaniciAdi.Text && x.LastName == txtSifre.Text))
            {
                Employee girisYapan = db.Employees.FirstOrDefault(x => x.FirstName == txtKullaniciAdi.Text && x.LastName == txtSifre.Text);
                Dashboard yoneticiSayfasi = new Dashboard(girisYapan);
                this.Hide();
                yoneticiSayfasi.Show();
            }
            else
            {
                MessageBox.Show($"Girmiş olduğunuz {txtKullaniciAdi.Text} kullanıcı bilgilerinde bir çalışan bulunamadı. Lütfen bilgilerinizi kontrol edin veya sistem yöneticisine başvurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
