using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK
{
    class SachGiaoKhoa : Sach
    {
        String TinhTrangSach;
        float a = 0;
        public SachGiaoKhoa():base()
        {
            this.TinhTrangSach = "";
        }
        public SachGiaoKhoa(String TinhTrangSach) {
            this.TinhTrangSach = TinhTrangSach;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Tinh trang sach: ");
            this.TinhTrangSach = Console.ReadLine();
        }
        public new void In()
        {
            base.In();
            Console.Write("Tinh Tien Sach: ");
            Console.Write(TinhTienSach());
        }
        public float TinhTienSach()
        {
            if (this.TinhTrangSach == "Moi" || this.TinhTrangSach == "moi")
            {
                a = L() * G();
            }
            if (this.TinhTrangSach == "Cu" || this.TinhTrangSach == "cu")
            {
                a = L() * G() *(50 / 100);
            }
            return a;
        }
    }
}
