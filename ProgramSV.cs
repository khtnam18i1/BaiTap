using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so sinh vien: ");
            n = Int32.Parse(Console.ReadLine());
            //Tao mang doi tuong SinhVien
            SinhVien[] sv = new SinhVien[n];
            for(int i=0; i<n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].tinhTB();
                sv[i].Nhap();
                sv[i].In();
            }
            //Tim ra sinh vien nao co diem trung binh thap nhat
            float min = sv[0].tinhTB();
            for(int i = 0; i < n; i++)
            {
                if (sv[i].tinhTB() < min) min = sv[i].tinhTB();
            }
            Console.WriteLine("Sinh vien co diem thap nhat la {0}", min);
            //Tim ra ma sinh vien co chua chu 18IT
            for (int i = 0; i < n; i++)
            {
                if (sv[i].maSV.Contains("18IT")) ;
                Console.WriteLine("SV ma {0} co diem TB la {1} co chu 18IT", sv[i].maSV, sv[i].tinhTB());
            }
            //Sap xep mang sv theo diem TB giam dan
            SinhVien tmp;
            {
                for(int i=1; i<n; i++)
                {
                    for(int j=1; j<n; j++)
                        if(sv[i].tinhTB() > sv[j].tinhTB())
                        {
                            tmp = sv[i];
                            sv[i] = sv[j];
                            sv[j] = tmp;
                        }
                }
            }
            Console.WriteLine("Sinh vien sap xep theo thu tu giam dan: ");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Sinh vien ma {0} co diem TB {1} ", sv[i].maSV, sv[i].tinhTB());
            }
            Console.ReadLine();
        }
    }
}
