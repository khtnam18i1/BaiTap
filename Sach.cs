using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK
{
    class Sach
    {
        String MaSach;
        DateTime NgayNhap;
        float DonGia;
        int SoLuong;
        public Sach()
        {
            this.MaSach = MaSach;
            this.NgayNhap = NgayNhap;
            this.DonGia = DonGia;
            this.SoLuong = SoLuong;
        }
        public void Nhap() {
            Console.Write("Ma Sach: ");
            this.MaSach = Console.ReadLine();
            Console.Write("Ngay Nhap: ");
            this.NgayNhap = DateTime.Parse(Console.ReadLine());
            Console.Write("Don Gia: ");
            this.DonGia = float.Parse(Console.ReadLine());
            Console.Write("So Luong: ");
            this.SoLuong = int.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("Ma sach {0} muon vao ngay {1} co gia {2} so luong {3} ", this.MaSach, this.NgayNhap, this.DonGia, this.SoLuong);
        }
        public float G()
        {
            return DonGia;
        }
        public int L()
        {
            return SoLuong;
        }
    }
}
