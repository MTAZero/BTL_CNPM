using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        #region Sự kiện
        private void barNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhapHang uc = new ucNhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
        }

        private void barBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucBanHang uc = new ucBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucKho uc = new ucKho();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeHangHoa uc = new ucThongKeHangHoa();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongKeDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeDoanhThu uc = new ucThongKeDoanhThu();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinCaNhan form = new FrmThongTinCaNhan();
            form.ShowDialog();
        }

        private void barDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau();
            form.ShowDialog();
        }

        private void barNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhanVien uc = new ucDanhSachNhanVien();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachMatHang uc = new ucDanhSachMatHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBanAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachBanAn uc = new ucDanhSachBanAn();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongTinNhaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinNhaHang form = new FrmThongTinNhaHang();
            form.ShowDialog();
        }
        #endregion

    }
}
