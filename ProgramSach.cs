using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGiaoKhoa s = new SachGiaoKhoa();
            s.Nhap();
            s.In();
            Console.ReadLine();
        }
    }
}
