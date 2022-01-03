using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau3
{
    public partial class Form1 : Form
    {
        CompositeNuoc dsNgot = new CompositeNuoc();
        CompositeNuoc dsEp = new CompositeNuoc();
        CompositeNuoc dsKhoang = new CompositeNuoc();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNgot_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Ngot" };
            
            dsNgot.AddNuoc(nuoc);
        }

        private void btnAddEp_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Ep" };
            
            dsEp.AddNuoc(nuoc);
        }

        private void btnAddKhoang_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Khoang" };
            
            dsKhoang.AddNuoc(nuoc);
        }

        private void btnDelNgot_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Ngot" };
            dsEp.RemoveNuoc(nuoc, txtTenHang.Text);
        }

        private void btnDelEp_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Ep" };
            dsEp.RemoveNuoc(nuoc, txtTenHang.Text);
        }

        private void btnDelKhoang_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat nuoc = new NuocGiaiKhat() { TenHang = txtTenHang.Text, Loai = "Nuoc Khoang" };
            dsKhoang.RemoveNuoc(nuoc, txtTenHang.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            INuocGiaiKhat cola = new NuocGiaiKhat() { TenHang = "Cola", Loai = "Nuoc Ngot" };
            INuocGiaiKhat pepsi = new NuocGiaiKhat() { TenHang = "Pepsi", Loai = "Nuoc Ngot" };
            INuocGiaiKhat olong = new NuocGiaiKhat() { TenHang = "O Long", Loai = "Nuoc Ngot" };
            dsNgot.AddNuoc(cola);
            dsNgot.AddNuoc(pepsi);
            dsNgot.AddNuoc(olong);
            //loaiNuocNgot.DisplayDetail();

            INuocGiaiKhat dau = new NuocGiaiKhat() { TenHang = "Nuoc Dau", Loai = "Nuoc Ep" };
            INuocGiaiKhat tao = new NuocGiaiKhat() { TenHang = "Nuoc Tao", Loai = "Nuoc Ep" };
            INuocGiaiKhat xoai = new NuocGiaiKhat() { TenHang = "Nuoc Xoai", Loai = "Nuoc Ep" };
            dsEp.AddNuoc(dau);
            dsEp.AddNuoc(tao);
            dsEp.AddNuoc(xoai);
            //nuocEp.DisplayDetail();

            INuocGiaiKhat lavie = new NuocGiaiKhat() { TenHang = "Lavie", Loai = "Nuoc Khoang" };
            INuocGiaiKhat vinhHao = new NuocGiaiKhat() { TenHang = "Vinh Hao", Loai = "Nuoc Khoang" };
            dsKhoang.AddNuoc(lavie);
            dsKhoang.AddNuoc(vinhHao);

            CompositeNuoc mayban = new CompositeNuoc() { Loai = "May ban nuoc" };
            mayban.AddNuoc(dsEp);
            mayban.AddNuoc(dsNgot);
            mayban.AddNuoc(dsKhoang);
            richTextBox1.Text = mayban.DisplayDetail();
        }
    }
}
