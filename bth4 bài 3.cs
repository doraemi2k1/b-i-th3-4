using System;
using System.Collections.Generic;
using System.Text;

namespace btt4 //bài 3
{ 
    class Person
    {
        private string hoten;
        private int namsinh;
        private double diemthi;

        public Person()
        {
            hoten = " ";
            diemthi = 0;
            namsinh = 1900;

        }
        //======================================================
        public Person(string hoten, double diemthi, int namsinh)
        {
            this.hoten = hoten;
            this.diemthi = diemthi;
            this.namsinh = namsinh;
        }
        // nhập thông tin 

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên học viên : ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Điểm thi= ");
            diemthi = double.Parse(Console.ReadLine());
            Console.Write("Năm sinh");
            namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //===========================================================================
        }
        // hiển thị thông tin học sinh
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("HỌ TÊN HỌC VIÊN {0}", hoten);
            Console.WriteLine("NĂM SINH{0} ", namsinh);
            Console.WriteLine("ĐIỂM THI{0} ", diemthi);
        }
        //

    }
    class TEst
    {
        static void Main(string[] args)
        {

        }
    }
}


