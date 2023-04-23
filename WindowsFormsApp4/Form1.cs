using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class MainForm : Form
    {
        private List<NhanVien> dsNhanVien = new List<NhanVien>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control trên form
            string ten = txtTen.Text;
            string maNV = txtMaNV.Text;
            DateTime gioVao = dtpGioVao.Value;
            DateTime gioRa = dtpGioRa.Value;

            // Tạo đối tượng NhanVien và thêm vào danh sách
            NhanVien nv = new NhanVien(ten, maNV, gioVao, gioRa);
            dsNhanVien.Add(nv);

            // Hiển thị thông tin của nhân viên vừa thêm vào ListView
            ListViewItem item = new ListViewItem(new string[] { nv.Ten, nv.MaNV, nv.GioVao.ToString(), nv.GioRa.ToString() });
            lvwDanhSachNV.Items.Add(item);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            // Tính lương cho từng nhân viên và hiển thị kết quả
            foreach (NhanVien nv in dsNhanVien)
            {
                double tongGioLam = (nv.GioRa - nv.GioVao).TotalHours;
                double luong = tongGioLam * 100000; // Giả sử mỗi giờ làm được trả 100.000 VNĐ
                MessageBox.Show("Nhân viên " + nv.Ten + " có lương: " + luong.ToString("N0") + " VNĐ");
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
        }
    }

    // Định nghĩa class NhanVien để lưu trữ thông tin của nhân viên
    public class NhanVien
    {
        public string Ten { get; set; }
        public string MaNV { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }

        public NhanVien(string ten, string maNV, DateTime gioVao, DateTime gioRa)
        {
            Ten = ten;
            MaNV = maNV;
            GioVao = gioVao;
            GioRa = gioRa;
        }
    }
}
