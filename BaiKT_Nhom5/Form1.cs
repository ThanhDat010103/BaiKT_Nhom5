namespace BaiKT_Nhom5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double so1 = Convert.ToDouble(txt1.Text);
                double so2 = Convert.ToDouble(txt2.Text);

                // Thực hiện phép nhân
                double ketQua = so1 * so2;

                // Hiển thị kết quả
                txtKQ.Text = "Kết quả: " + ketQua.ToString();
            }
            catch (FormatException)
            {
                // Xử lý trường hợp người dùng nhập không phải số
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
            }
        }
    }
}