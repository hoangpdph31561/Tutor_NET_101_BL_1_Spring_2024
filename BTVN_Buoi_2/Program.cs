using System.Text;
using System;

namespace BTVN_Buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Số nguyên tố
            //Tìm số nguyên tố 
            //int n;
            //bool check = true;
            //do
            //{
            //    Console.WriteLine("Nhập số");
            //    n = Convert.ToInt32(Console.ReadLine());
            //} while (n < 2);
            //for (int i = 2; i <= n/2; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        check = false;
            //        break;
            //    }
            //}
            //if(check )
            //{
            //    Console.WriteLine($"{n} là số nguyên tố");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} không là số nguyên tố");
            //}
            #endregion

            //Đếm số chẵn lẻ mà không sử dụng if else từ 1 - 100 
            int countSoChan = 0, countSoLe = 0;
            for (int i = 1; i <= 100; i++)
            {
                var x = i % 2 == 0 ? countSoChan++ : countSoLe++;
            }
            Console.WriteLine(countSoChan);
            Console.WriteLine(countSoLe); 
            Console.WriteLine("Hello, World!");
        }
    }
}
