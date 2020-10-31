using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 /* bai4_BTH4: a) Cho lớp “PhanTu” (lớp biểu diễn cho một phần tử trong một đa thức) được khai báo
như sau:
class PhanTu {
 private double heso; //Hệ số
 private int mu; // Số mũ của một phần tử
}
Hãy xây dựng cho lớp “PhanTu” gồm các phương thức sau:
- Phương thức khởi tạo không tham số với việc khởi tạo các thành phần dữ liệu kiểu số
là 0
- Phương thức khởi tạo 2 tham số tương ứng với các thuộc tính
- Phương thức “Nhap” để nhập thông tin cho một phần tử
- Phương thức “HienThi” để in thông tin của một phần tử ra màn hình.
b) Sau đó xây dựng lớp “DaThuc” (lớp biểu diễn cho một đa thức) được khai báo như
sau:
class DaThuc {
private int n; //Bậc của đa thức
 private PhanTu []p; //Mảng chứa các phần tử của đa thứ*/
{
    class phantu
    {
        private double heso;
        private int somu;

        public phantu()
        {
            heso = somu = 0;
        }

        public phantu(double heso, int somu)
        {
            this.heso = heso;
            this.somu = somu;
        }
        //--------------------------------------------------------------------------------
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Hệ số= ");
            heso = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Số mũ: ");
            somu = int.Parse(Console.ReadLine());
        }
        //----------------------------------------------------------------------------------
        public void Hien()
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("HỆ SỐ :{0}", heso);
            Console.Write("SỐ  MŨ :{0}", somu);
        }
    }

    class DaThuc
    {
        private int n;
        private phantu[] p;
        private double x;


    }
    //---------------------------------------------------------------------------------------------
    public void nhap()
    {

    }
    //---------------------------------------------------------------------------------------------
    public void hien()
    {

    }
    class TEST
    {
        static void Main()
        {

        }
    }
}

