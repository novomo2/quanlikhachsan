using QLKSHOANGLONG.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSHOANGLONG
{
    public partial class formManHinhChinh : Form
    {
        public formManHinhChinh()
        {
            InitializeComponent();
        }

        public void DatPhongTruoc(ThongTinPhieuPhong thongTinPhieuPhong)
        {
            int soPhong = thongTinPhieuPhong.soPhong;
            Console.WriteLine(soPhong + "");
            switch (soPhong)
            {
                case 1:
                    lblNoiDungKhachDat1.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach1.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach1.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich1.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI1.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO1.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien1.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 2:
                    lblNoiDungKhachDat2.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach2.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach2.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich2.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI2.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO2.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien2.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 3:
                    lblNoiDungKhachDat3.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach3.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach3.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich3.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI3.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO3.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien3.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 4:
                    lblNoiDungKhachDat4.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach4.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach4.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich4.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI4.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO4.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien4.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 5:
                    lblNoiDungKhachDat5.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach5.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach5.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich5.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI5.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO5.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien5.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 6:
                    lblNoiDungKhachDat6.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach6.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach6.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich6.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI6.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO6.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien6.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 7:
                    lblNoiDungKhachDat7.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach7.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach7.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich7.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI7.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO7.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien7.Text = thongTinPhieuPhong.tongTien + "";
                    break;
                case 8:
                    lblNoiDungKhachDat8.Text = thongTinPhieuPhong.tenKhachDat;
                    lblNoiDungTenKhach8.Text = thongTinPhieuPhong.tenKhachHang;
                    lblNoiDungSoKhach8.Text = thongTinPhieuPhong.soKhach + "";
                    lblNoiDungQuocTich8.Text = thongTinPhieuPhong.quocTich;
                    lblNoiDungNgayCI8.Text = thongTinPhieuPhong.ngayCI.ToString("dd/MM/yyyy");
                    lblNoiDungCO8.Text = thongTinPhieuPhong.ngayCO.ToString("dd/MM/yyyy");
                    lblNoiDungTien8.Text = thongTinPhieuPhong.tongTien + "";
                    break;
            }


            //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();

            //var listHD = HoaDon.GetAll();
            //Console.WriteLine(listHD.Count);
            //var hd1 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 1);
            //if (hd1 != null)  
            //{
            //    DateTime dt = DateTime.ParseExact(hd1.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    //if (dt.Date >= DateTime.Now)
            //    //{
            //        DatPhong findBook = DatPhong.GetDatPhong(hd1.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat1.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach1.Text = hd1.KhachHang.TenKH;
            //        lblNoiDungSoKhach1.Text = hd1.SoKhach + "";
            //        lblNoiDungQuocTich1.Text = hd1.KhachHang.QuocTich;
            //        lblNoiDungNgayCI1.Text = dt.AddDays(0 - hd1.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO1.Text = hd1.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    //}
            //}

            //var hd2 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 2);
            //if (hd2 != null)  
            //{
            //    DateTime dt = DateTime.ParseExact(hd2.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd2.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat2.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach2.Text = hd2.KhachHang.TenKH;
            //        lblNoiDungSoKhach2.Text = hd2.SoKhach + "";
            //        lblNoiDungQuocTich2.Text = hd2.KhachHang.QuocTich;
            //        lblNoiDungNgayCI2.Text = dt.AddDays(0 - hd2.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO2.Text = hd2.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}

            //var hd3 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 3);
            //if (hd3 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd3.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd3.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat3.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach3.Text = hd3.KhachHang.TenKH;
            //        lblNoiDungSoKhach3.Text = hd3.SoKhach + "";
            //        lblNoiDungQuocTich3.Text = hd3.KhachHang.QuocTich;
            //        lblNoiDungNgayCI3.Text = dt.AddDays(0 - hd3.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO3.Text = hd3.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}

            //var hd4 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 4);
            //if (hd4 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd4.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd4.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat4.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach4.Text = hd4.KhachHang.TenKH;
            //        lblNoiDungSoKhach4.Text = hd4.SoKhach + "";
            //        lblNoiDungQuocTich4.Text = hd4.KhachHang.QuocTich;
            //        lblNoiDungNgayCI4.Text = dt.AddDays(0 - hd4.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO4.Text = hd4.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}
            //var hd5 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 5);
            //if (hd5 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd5.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd5.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat5.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach5.Text = hd5.KhachHang.TenKH;
            //        lblNoiDungSoKhach5.Text = hd5.SoKhach + "";
            //        lblNoiDungQuocTich5.Text = hd5.KhachHang.QuocTich;
            //        lblNoiDungNgayCI5.Text = dt.AddDays(0 - hd5.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO5.Text = hd5.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}
            //var hd6 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 6);
            //if (hd6 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd6.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd6.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat6.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach6.Text = hd6.KhachHang.TenKH;
            //        lblNoiDungSoKhach6.Text = hd6.SoKhach + "";
            //        lblNoiDungQuocTich6.Text = hd6.KhachHang.QuocTich;
            //        lblNoiDungNgayCI6.Text = dt.AddDays(0 - hd6.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO6.Text = hd6.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}
            //var hd7 = listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 7);
            //if (hd7 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd7.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd7.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat7.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach7.Text = hd7.KhachHang.TenKH;
            //        lblNoiDungSoKhach7.Text = hd7.SoKhach + "";
            //        lblNoiDungQuocTich7.Text = hd7.KhachHang.QuocTich;
            //        lblNoiDungNgayCI7.Text = dt.AddDays(0 - hd7.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO7.Text = hd7.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}
            //var hd8= listHD.LastOrDefault(p => p.IDPhong != null && p.IDPhong == 8);
            //if (hd8 != null)  // cần thêm đk && ngay hoa don >= datetime.Now
            //{
            //    DateTime dt = DateTime.ParseExact(hd8.NgayHD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //    if (dt.Date >= DateTime.Now)
            //    {
            //        DatPhong findBook = DatPhong.GetDatPhong(hd8.IDDatPhong.Value);
            //        if (findBook != null)
            //        {
            //            lblNoiDungKhachDat8.Text = findBook.TenKhachDat;
            //        }
            //        lblNoiDungTenKhach8.Text = hd8.KhachHang.TenKH;
            //        lblNoiDungSoKhach8.Text = hd8.SoKhach + "";
            //        lblNoiDungQuocTich8.Text = hd8.KhachHang.QuocTich;
            //        lblNoiDungNgayCI8.Text = dt.AddDays(0 - hd8.SoDem.Value).ToString("dd/MM/yyyy");
            //        lblNoiDungCO8.Text = hd8.NgayHD;
            //        //lblNoiDungTien1.Text = hd1.Phong.GiaPhong.ToString();
            //    }
            //}

        }

        private void fctpp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyKhachHang fqlkh = new FQuanLyKhachHang();
            fqlkh.Show();
            this.Hide();
        }
        private void fqlkh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FManHinhChinh_Load(object sender, EventArgs e)
        {

            //DatPhongTruoc();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongKe fThongKe = new FThongKe();
            fThongKe.Show();
            this.Hide();    
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLienHe fLienHe = new FLienHe();
            fLienHe.Show();
            this.Hide();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyPhong qlp = new FQuanLyPhong();
            qlp.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyNhanVien qlnv = new FQuanLyNhanVien();
            qlnv.Show();
            this.Hide();
        }

        private void btCO1_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat1.Text = "___________________";
            lblNoiDungTenKhach1.Text = "___________________";
            lblNoiDungSoKhach1.Text = "___________________";
            lblNoiDungQuocTich1.Text = "___________________";
            lblNoiDungNgayCI1.Text = "___________________";
            lblNoiDungCO1.Text = "___________________";
            lblNoiDungTien1.Text = "0";
            cbPhong1.Text = "";
            lblPhong1.Text = "          Đã Thanh Toán           ";
            lblPhong1.BackColor = Color.Gray;
        }

        private void btCO2_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat2.Text = "___________________";
            lblNoiDungTenKhach2.Text = "___________________";
            lblNoiDungSoKhach2.Text = "___________________";
            lblNoiDungQuocTich2.Text = "___________________";
            lblNoiDungNgayCI2.Text = "___________________";
            lblNoiDungCO2.Text = "___________________";
            lblNoiDungTien2.Text = "0";
            cbPhong2.Text = "";
            lblPhong2.Text = "          Đã Thanh Toán           ";
            lblPhong2.BackColor = Color.Gray;
        }

        private void btCO3_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat3.Text = "___________________";
            lblNoiDungTenKhach3.Text = "___________________";
            lblNoiDungSoKhach3.Text = "___________________";
            lblNoiDungQuocTich3.Text = "___________________";
            lblNoiDungNgayCI3.Text = "___________________";
            lblNoiDungCO3.Text = "___________________";
            lblNoiDungTien3.Text = "0";
            cbPhong3.Text = "";
            lblPhong3.Text = "          Đã Thanh Toán           ";
            lblPhong3.BackColor = Color.Gray;
        }

        private void btCO4_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat4.Text = "___________________";
            lblNoiDungTenKhach4.Text = "___________________";
            lblNoiDungSoKhach4.Text = "___________________";
            lblNoiDungQuocTich4.Text = "___________________";
            lblNoiDungNgayCI4.Text = "___________________";
            lblNoiDungCO4.Text = "___________________";
            lblNoiDungTien4.Text = "0";
            cbPhong4.Text = "";
            lblPhong4.Text = "          Đã Thanh Toán           ";
            lblPhong4.BackColor = Color.Gray;
        }

        private void btCO5_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat5.Text = "___________________";
            lblNoiDungTenKhach5.Text = "___________________";
            lblNoiDungSoKhach5.Text = "___________________";
            lblNoiDungQuocTich5.Text = "___________________";
            lblNoiDungNgayCI5.Text = "___________________";
            lblNoiDungCO5.Text = "___________________";
            lblNoiDungTien5.Text = "0";
            cbPhong5.Text = "";
            lblPhong5.Text = "          Đã Thanh Toán           ";
            lblPhong5.BackColor = Color.Gray;
        }

        private void btCO6_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat6.Text = "___________________";
            lblNoiDungTenKhach6.Text = "___________________";
            lblNoiDungSoKhach6.Text = "___________________";
            lblNoiDungQuocTich6.Text = "___________________";
            lblNoiDungNgayCI6.Text = "___________________";
            lblNoiDungCO6.Text = "___________________";
            lblNoiDungTien6.Text = "0";
            cbPhong6.Text = "";
            lblPhong6.Text = "          Đã Thanh Toán           ";
            lblPhong6.BackColor = Color.Gray;
        }

        private void btCO7_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat7.Text = "___________________";
            lblNoiDungTenKhach7.Text = "___________________";
            lblNoiDungSoKhach7.Text = "___________________";
            lblNoiDungQuocTich7.Text = "___________________";
            lblNoiDungNgayCI7.Text = "___________________";
            lblNoiDungCO7.Text = "___________________";
            lblNoiDungTien7.Text = "0";
            cbPhong7.Text = "";
            lblPhong7.Text = "          Đã Thanh Toán           ";
            lblPhong7.BackColor = Color.Gray;
        }

        private void btCO8_Click(object sender, EventArgs e)
        {
            lblNoiDungKhachDat8.Text = "___________________";
            lblNoiDungTenKhach8.Text = "___________________";
            lblNoiDungSoKhach8.Text = "___________________";
            lblNoiDungQuocTich8.Text = "___________________";
            lblNoiDungNgayCI8.Text = "___________________";
            lblNoiDungCO8.Text = "___________________";
            lblNoiDungTien8.Text = "0";
            cbPhong8.Text = "";
            lblPhong8.Text = "          Đã Thanh Toán           ";
            lblPhong8.BackColor = Color.Gray;
        }

        private void cbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong1.Text ="           Đã Có Khách              ";
                    lblPhong1.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong1.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong1.Text = "            Chưa Có Khách         ";
                    lblPhong1.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong1.Text = "           Khách Mới Trả          ";
                    lblPhong1.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong2.Text = "           Đã Có Khách              ";
                    lblPhong2.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong2.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong2.Text = "            Chưa Có Khách         ";
                    lblPhong2.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong2.Text = "           Khách Mới Trả          ";
                    lblPhong2.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong3.Text = "           Đã Có Khách              ";
                    lblPhong3.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong3.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong3.Text = "            Chưa Có Khách         ";
                    lblPhong3.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong3.Text = "           Khách Mới Trả          ";
                    lblPhong3.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong4.Text = "           Đã Có Khách              ";
                    lblPhong4.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong4.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong4.Text = "            Chưa Có Khách         ";
                    lblPhong4.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong4.Text = "           Khách Mới Trả          ";
                    lblPhong4.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong5.Text = "           Đã Có Khách              ";
                    lblPhong5.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong5.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong5.Text = "            Chưa Có Khách         ";
                    lblPhong5.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong5.Text = "           Khách Mới Trả          ";
                    lblPhong5.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong6.Text = "           Đã Có Khách              ";
                    lblPhong6.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong6.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong6.Text = "            Chưa Có Khách         ";
                    lblPhong6.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong6.Text = "           Khách Mới Trả          ";
                    lblPhong6.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong7.Text = "           Đã Có Khách              ";
                    lblPhong7.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong7.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong7.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong7.Text = "            Chưa Có Khách         ";
                    lblPhong7.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong7.Text = "           Khách Mới Trả          ";
                    lblPhong7.BackColor = Color.Gray;
                    break;
            }
        }

        private void cbPhong8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cbPhong8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Có Khách":
                    lblPhong8.Text = "           Đã Có Khách              ";
                    lblPhong8.BackColor = Color.Red;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong8.Text = "        Đang Được Vệ Sinh         ";
                    lblPhong8.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong8.Text = "            Chưa Có Khách         ";
                    lblPhong8.BackColor = Color.Green;
                    break;
                case "Phòng Mới Trả":
                    lblPhong8.Text = "           Khách Mới Trả          ";
                    lblPhong8.BackColor = Color.Gray;
                    break;
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Close();
        }

        private void btChiTiet8_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuPhong fmmhctpp = new frmChiTietPhieuPhong(this);
            fmmhctpp.Show();
        }

        private void btDatPhong_Click(object sender, EventArgs e)
        {
            FDatPhong fdp = new FDatPhong();
            fdp.Show();
            this.Hide();
        }
    }
}
