using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1
            Tinhtong tong = new Tinhtong();
            tong.nhapn();
            tong.tinhTong();
            tong.inTong();
            tong.tinhTong2();
            tong.tinhTong3();
            tong.tongUoc();

            //Bai2
            Doantau tau = new Doantau();
            tau.nhapMadoantau();
            tau.tinhTien();
            tau.inMatau();

            Console.ReadLine();

        }
    }
}
