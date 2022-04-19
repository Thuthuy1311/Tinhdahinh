using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhdahinh
{
    class Shape
    {
        public virtual void Xuat()
        {
            Console.WriteLine("Day la hinh");
        }
            
    }
    class HinhChuNhat : Shape
    {
        //private int socanh;
        //private int sodinh;
        //private int sogocvuong;
       // public HinhChuNhat(int a, int b, int c)
       // {
        //    socanh = a;
        //    sodinh = b;
        //    sogocvuong = c;
        //}
        public override void Xuat()
        {
            Console.WriteLine("Day la hinh chu nhat");
        }
    }

    class HinhBinhHanh : Shape
    {
      
        public override void Xuat()
        {
            Console.WriteLine("Day la hinh binh hanh");
        }
    }

    class HinhTamGiac : Shape
    {
        public override void Xuat()
        {
            Console.WriteLine("Day la hinh tam giac");
        }
    }

    class HinhVuong : Shape
    {
        public override void Xuat()
        {
            Console.WriteLine("Day la hinh vuong");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh da hinh trong C#");
            Console.WriteLine("--------------------------");
            int option;
            do
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Shape hinhchunhat = new HinhChuNhat();
                        hinhchunhat.Xuat();
                        break;
                    case 2:
                        Shape hinhtamgiac = new HinhTamGiac();
                        hinhtamgiac.Xuat();
                        break;
                    case 3:
                        Shape hinhvuong = new HinhVuong();
                        hinhvuong.Xuat();
                        break;
                    case 4:
                        Shape hinhbinhhanh = new HinhBinhHanh();
                        hinhbinhhanh.Xuat();
                        break;
                }
            } while (option < 5 && option > 0 );
        }
    }
}
