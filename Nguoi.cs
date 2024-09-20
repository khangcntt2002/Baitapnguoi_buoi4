using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnguoi_buoi4
{
    internal class Nguoi
    {
        string hoten;
        string ngaysinh;
        string gioitinh;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public Nguoi() { }

        public Nguoi(string hoten, string ngaysinh, string gioitinh)
        {
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }





    }
}
