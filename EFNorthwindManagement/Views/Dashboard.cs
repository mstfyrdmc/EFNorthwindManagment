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
    public partial class Dashboard : Form
    {
        public Dashboard(Employee _girisYapan)
        {
            InitializeComponent();
            this.Text = $"Dashboard - Hoşgeldiniz; {_girisYapan.FirstName} {_girisYapan.LastName}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.ShowDialog();

           
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatagoryManagement cm = new CatagoryManagement();
            cm.ShowDialog();
            
        }

        private void tedarikçiYönteimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciManagement tm = new TedarikciManagement();
            tm.ShowDialog();
        }

        private void kargoFirmalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KargoFirmalarıManagement kf = new KargoFirmalarıManagement();
            kf.ShowDialog();
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yapılmadı
            OrdersManagement om = new OrdersManagement();
            om.ShowDialog();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CustomersManagement cmg = new CustomersManagement();
            cmg.ShowDialog();
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Yapılmadı
            EmployeesManagement em = new EmployeesManagement();
            em.ShowDialog();
        }

        
    }
}
