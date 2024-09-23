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
        List<SinhVien> danhsach1 = new List<SinhVien>();
        private void button1_Click(object sender, EventArgs e)
        {
            double diemtb;
            if (double.TryParse(txt_dtb.Text, out diemtb))
            {

                SinhVien sinhVien = new SinhVien(txt_hoten.Text, dt_ngaysinh.Value.ToString(), txt_gioitinh.Text, txt_mssv.Text, txt_nganhhoc.Text, diemtb);

                danhsach1.Add(sinhVien);
                dt_1.DataSource = null;
                dt_1.DataSource = danhsach1;

            }
            else
            {
                MessageBox.Show("nhập số");
            }


        }
        List<NhanVien> danhsach2 = new List<NhanVien>();

        private void button2_Click(object sender, EventArgs e)
        {
            double Luong;

            if (double.TryParse(txt_luong.Text, out Luong))
            {
                NhanVien nhanvien = new NhanVien(txt_hoten2.Text, dt_ngaysinh2.Value.ToString(), txt_gioitinh2.Text, txt_msnv.Text, txt_chucvu.Text, Luong.ToString());
                danhsach2.Add(nhanvien);
                dt_2.DataSource = null;
                dt_2.DataSource = danhsach2;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (SinhVien i in danhsach1)
            {
                if (i.Mssv == txt_mssv.Text) 
                {
                    i.Hoten = txt_hoten.Text;
                    i.Dtb = double.Parse(txt_dtb.Text);
                }

            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;


        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (SinhVien i in danhsach1)
            {
                if (i.Mssv == txt_mssv.Text) 
                {
                    danhsach1.Remove(i);
                    break;
                }

            }
            dt_1.DataSource = null;
            dt_1.DataSource = danhsach1;
        }
    }
}

