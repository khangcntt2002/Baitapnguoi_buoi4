using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnguoi_buoi4
{
    internal class NhanVien : Nguoi

    {
        string msnv;
        string luong;
        string chucvu;

        public string Msnv { get => msnv; set => msnv = value; }
        public string Luong { get => luong; set => luong = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public NhanVien() { }   

        public NhanVien(string hoten, string ngaysinh, string gioitinh,string msnv, string luong, string chucvu )
            : base(hoten, ngaysinh, gioitinh)
        {
            this.Msnv = msnv;
            this.Luong = luong;
            this.Chucvu = chucvu;
           

        }
    }
}
