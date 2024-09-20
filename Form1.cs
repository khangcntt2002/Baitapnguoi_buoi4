namespace Baitapnguoi_buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_MSSV_TextChanged(object sender, EventArgs e)
        {

        }
        List<string> txt_MSSV= new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Nguoi nguoi = new Nguoi(txt_hoten.Text,txt_gioitinh.Text,txt_ngaysinh.Text,txt_mssv.Text,txt_nganhhoc.Text,txt_dtb.Text,txt_hoten2.Text,txt_ngaysinh2.Text,txt_gioitinh2.Text,txt_msnv.Text,txt_luong.Text,txt_chucvu.Text);
        }
    }
}
