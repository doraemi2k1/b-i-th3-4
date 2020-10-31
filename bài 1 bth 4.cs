using System;
using System.Collections.Generic;
using System.Text;

namespace btth4
{
    class matran
    {
        private int m, n;
        private int[,] a;
        public matran()
        {
            m = n = 2;
            a = new int[m, n];
        }
        public matran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];

        }
        public matran(matran t2)
        {
            this.m = t2.m;
            this.n = t2.n;
            this.a = new int[m, n];
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    this.a[i, j] = t2.a[i, j];
        }
        // phương thức nhập
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" nhập thông tin cho các phần tử của ma trận");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                {
                    Console.WriteLine("a{0},{1}=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        // phương thức hiện
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" các phần tử của ma trận");
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    Console.WriteLine("{0}\t", a[i, j]);
            Console.WriteLine();

        }
        // tính ma trận tổng 
        public matran Tong(matran t2)
        {
            if (this.m == t2.m && this.n == t2.n)
            {
                matran t = new matran(this.m, this.n);
                for (int i = 0; i < t.m; ++i)
                    for (int j = 0; j < t.n; ++j)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
    }
    // test 
    class test
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin cho ma trận:");
            matran t1 = new matran(2, 3); t1.Nhap();
            Console.WriteLine("Nhập thông tin cho ma trận 1");
            matran t2 = new matran(t1);
            matran t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("2 ma trận không cùng kích thước không tính được , ko tinh tong dc");
            else
            {
                Console.WriteLine("Thông tin ma trận tổng");
                t3.Hien();
            }
            Console.ReadKey();
        }
    }


}


