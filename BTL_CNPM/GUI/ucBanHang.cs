using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_CNPM.Data;
using DevExpress.XtraEditors;

namespace BTL_CNPM.GUI
{
    public partial class ucBanHang : UserControl
    {
        private RM_Context db = Helper.db;
        private int IDBanAn = 0;

        #region Hàm khởi tạo
        public ucBanHang()
        {
            InitializeComponent();
            Helper.Reload();
        }

        #endregion

        #region LoadForm

        private void LoadDgvHoaDon(int idHoaDon)
        {
            int i = 0;
            var listChiTiet = db.CHITIETHOADONs.ToList()
                              .Where(p => p.HOADONID == idHoaDon)
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  STT = ++i,
                                  MatHang = db.MATHANGs.Where(z=>z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                  DonGia = ((int)p.DONGIA).ToString("N0"),
                                  SoLuong = p.SOLUONG,
                                  ThanhTien = ((int) (p.DONGIA * p.SOLUONG)).ToString("N0")
                              });

            dgvHoaDonMain.DataSource = listChiTiet;
        }
        private void LoadDsBanAn()
        {
            var listBanAn = db.BANANs.ToList();

            panelDsBanAn.Controls.Clear();
            foreach(var item in listBanAn)
            {
                ucBanAn uc = new ucBanAn(item, ucClick);
                panelDsBanAn.Controls.Add(uc);
            }
        }

        private void ucClick(object sender,EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            UpdateDetail((int)button.Tag);
        }

        private void LoadInitControl()
        {
            try
            {
                cbxGMMatHang.Properties.DataSource = db.MATHANGs
                                                     .Select(p => new
                                                     {
                                                         ID = p.ID,
                                                         MatHang = p.TEN
                                                     })
                                                     .ToList();
                cbxGMMatHang.Properties.DisplayMember = "MatHang";
                cbxGMMatHang.Properties.ValueMember = "ID";
                cbxGMMatHang.ItemIndex = 0;

                LoadBanTrong();
            }
            catch
            {

            }
        }

        private void LoadBanTrong()
        {
            try
            {
                cbxCBBanAn.Properties.DataSource = db.BANANs.Where(p => p.TRANGTHAI == 0).ToList()
                                                   .Select(p => new
                                                   {
                                                       ID = p.ID,
                                                       BanAn = p.TEN
                                                   }).ToList();
                cbxCBBanAn.Properties.DisplayMember = "BanAn";
                cbxCBBanAn.Properties.ValueMember = "ID";

                cbxCBBanAn.ItemIndex = 0;
            }
            catch { }
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            ClearControl();
            LoadDsBanAn();
        }
        #endregion

        #region Hàm chức năng
        private void UpdateDetail(int ID)
        {
            try
            {
                BANAN ba = db.BANANs.Where(p => p.ID == ID).FirstOrDefault();
                if (ba == null) return;

                IDBanAn = ID;
                txtTenBanAn.Text = ba.TEN + " : ";

                ClearControl();
                if (ba.TRANGTHAI == 0) return;

                if (ba.TRANGTHAI == 1)
                {
                    int idHoaDon = (int)ba.HOADONID;
                    LoadDgvHoaDon(idHoaDon);
                    HOADON hd = db.HOADONs.Where(p => p.ID == ba.HOADONID).FirstOrDefault();
                    txtTongTien.Text = ((int)hd.TONGTIEN).ToString("N0");
                }
            }
            catch
            {

            }
        }

        private void ClearControl()
        {
            txtTongTien.Text = "0";
            dgvHoaDonMain.DataSource = null;
        }
        #endregion

    }
}
