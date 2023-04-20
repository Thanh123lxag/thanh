using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách các loại lẩu và giá tiền
        private Dictionary<string, int> soupList = new Dictionary<string, int>()
    {
        {"Lẩu thái", 100000},
        {"Lẩu Hàn Quốc", 120000},
        {"Lẩu Sichuan", 150000},
        {"Lẩu nấm", 90000},
    };

        public Form1()
        {
            InitializeComponent();

            // Thêm danh sách các loại lẩu vào ComboBox
            foreach (var soup in soupList)
            {
                comboBoxSoup.Items.Add(soup.Key + " - " + soup.Value.ToString("N0") + " VNĐ");
            }

            // Thiết lập giao diện DataGridView
            dataGridViewBill.Columns.Add("colItem", "Món ăn");
            dataGridViewBill.Columns.Add("colQuantity", "Số lượng");
            dataGridViewBill.Columns.Add("colPrice", "Đơn giá");
            dataGridViewBill.Columns.Add("colTotal", "Thành tiền");

            dataGridViewBill.Columns["colItem"].Width = 200;
            dataGridViewBill.Columns["colQuantity"].Width = 70;
            dataGridViewBill.Columns["colPrice"].Width = 100;
            dataGridViewBill.Columns["colTotal"].Width = 120;

            dataGridViewBill.Columns["colPrice"].DefaultCellStyle.Format = "N0";
            dataGridViewBill.Columns["colTotal"].DefaultCellStyle.Format = "N0";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Lấy thông tin lẩu được chọn từ ComboBox
            string selectedSoup = comboBoxSoup.SelectedItem.ToString().Split('-')[0].Trim();
            int soupPrice = soupList[selectedSoup];

            // Lấy thông tin số lượng thịt, rau, xí quách
            int meatQuantity = Convert.ToInt32(textBoxMeat.Text);
            int vegQuantity = Convert.ToInt32(textBoxVeg.Text);
            int xiquachQuantity = Convert.ToInt32(textBoxXiquach.Text);

            // Tính tổng tiền hóa đơn
            int totalPrice = soupPrice + meatQuantity * 50000 + vegQuantity * 20000 + xiquachQuantity * 15000;

            // Hiển thị thông tin hóa đơn trên DataGridView
            dataGridViewBill.Rows.Add(selectedSoup, meatQuantity + " phần", "50,000", meatQuantity * 50000);
            dataGridViewBill.Rows.Add("Rau thêm", vegQuantity + " phần", "20,000", vegQuantity * 20000);
            dataGridViewBill.Rows.Add("Xí quách", xiquachQuantity + " phần", "15,000", xiquachQuantity * 15000);

            // Hiển thị tổng tiền hóa đơn
            labelTotal.Text = totalPrice.ToString("N0") + " VNĐ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
