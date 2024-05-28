using System;
namespace Quan
{
    class Baichuyennhietdo
    {
        public static void Main()               
        {
            int C;
            double f;
            string strC;

            Console.WriteLine("Chao Mung Ban Den Voi Chuong Trinh Chuyen Doi Nhiet Do");
            Console.WriteLine("Moi ban nhap nhiet do can chuyen doi");
            strC =  Console.ReadLine();
            C = int.Parse(strC);
            f = (double)(((9 * C) / 5) + 32);
            Console.WriteLine("Ket qua sau khi chuyen doi la: " + f);
            Console.Read();
        }
    }
}