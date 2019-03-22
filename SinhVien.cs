using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SinhVien
    {
        public String maSV;
        float Toan;
        float Ly;
        float Hoa;
        public void SV()
        {
            String maSV = "01";
            float Toan = (float)6.5;
            float Ly = (float)9.5;
            float Hoa = (float)8.4;
        }
        public void SV(String maSV, float Toan, float Ly, float Hoa)
        {
            this.maSV = maSV;
            this.Toan = Toan;
            this.Ly = Ly;
            this.Hoa = Hoa;
        }
        //Viet ham nhap
        public void Nhap()
        {
            Console.Write("Nhap ma SV: ");
            this.maSV = Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            this.Toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Ly: ");
            this.Ly = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            this.Hoa = float.Parse(Console.ReadLine());
        }
        //Viet Ham diem trung binh
        public float tinhTB()
        {
            return (this.Toan + this.Ly + this.Hoa) / 3;
        }
        //Ham in
        public void In()
        {
            Console.WriteLine("Ma {0} co diem trung binh la {1}", this.maSV, this.tinhTB());
        }
    }
}
