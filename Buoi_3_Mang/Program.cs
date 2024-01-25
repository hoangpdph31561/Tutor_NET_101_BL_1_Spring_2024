using System.Collections;
using System.Text;

namespace Buoi_3_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //#region mảng
            //            Console.WriteLine("Nhập độ lớn của mảng");
            //            int n = Convert.ToInt32(Console.ReadLine());
            //            int[] arr = new int[n];
            //            //Nhập dữ liệu vào mảng
            //            for (int i = 0; i < arr.Length; i++)
            //            {
            //                Console.WriteLine($"Nhập phần tử thứ {i+1}");
            //                arr[i] = Convert.ToInt32(Console.ReadLine());
            //            }
            //            Console.WriteLine("Các phần tử ở trong mảng là");
            //            //In ra mảng vừa nhập
            //            for (int i = 0;i < arr.Length;i++)
            //            {
            //                Console.WriteLine($"{arr[i]}");
            //            }
            //            Console.WriteLine("Giá trị lớn nhất là");
            //            Console.WriteLine($"{arr.Max()}");
            //            Console.WriteLine("Giá trị bé nhất là");
            //            Console.WriteLine($"{arr.Min()}");
            //            Array.Sort(arr);
            //            //Sắp xếp tăng dần
            //            Console.WriteLine("Sắp xếp tăng dần");
            //            for (int i = 0; i < arr.Length; i++)
            //            {
            //                Console.WriteLine($"{arr[i]}");
            //            }
            //            //Lưu ý khi sắp xếp giảm dần, phải sort trước rồi mới reverse
            //            Array.Reverse(arr);
            //            Console.WriteLine("Sắp xếp giảm dần");
            //            for (int i = 0; i < arr.Length; i++)
            //            {
            //                Console.WriteLine($"{arr[i]}");
            //            }
            //#endregion

            //Khởi tạo list
            //#region List
            //List<int> lstSoNguyen = new List<int>();
            ////Thêm vào list
            //lstSoNguyen.Add(0);
            //lstSoNguyen.Add(1);
            //lstSoNguyen.Add(2);
            //lstSoNguyen.Add(3);
            ////Dùng vòng for
            //Console.WriteLine("Dùng for");
            //for (int i = 0; i < lstSoNguyen.Count; i++)
            //{
            //    Console.WriteLine(lstSoNguyen[i]);
            //}
            ////Dùng foreach
            //Console.WriteLine("Dùng foreach");
            //foreach (int item in lstSoNguyen)
            //{
            //    Console.WriteLine(item);
            //}
            //#endregion
            #region ArrayList
            ArrayList arrLst = new ArrayList();
            arrLst.Add(1);
            arrLst.Add(2);
            arrLst.Add("baloteli");
            arrLst.Add(true);
            foreach (var i in arrLst)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
