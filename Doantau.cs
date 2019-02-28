using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    class Doantau
    {
        int soLuongkhach;
        string maDoantau;
        public void nhapMadoantau()
        {
            Console.WriteLine("Nhap Ma Doan Tau: ");
            this.maDoantau = Console.ReadLine();
            Console.WriteLine("Nhap So Luong Khach Hang; ");
            this.soLuongkhach = Convert.ToInt32(Console.ReadLine());
        }
        public float tinhTien()
        {
            float S = 0;
            if (this.soLuongkhach<100)
            {
                S = this.soLuongkhach * 100000;
            }
            else
            {
                S = this.soLuongkhach * 80000;
            }
            return S;
        }
        public void inMatau()
        {
            Console.WriteLine(tinhTien());
            Console.WriteLine("In ra Ma Doan Tau 2 lan ");
            Console.WriteLine(this.maDoantau);

            Console.WriteLine(this.maDoantau);
        }
    }
}
