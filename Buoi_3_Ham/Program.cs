using System.Text;

namespace Buoi_3_Ham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * 3 loại hàm: 
             * Hàm không trả về, hàm trả về, hàm trả về bool
             * 2 loại:
             * Hàm có tham số và không có tham số
             * */
            //GetName();
            //Khai báo 2 biến a, b
            //Console.WriteLine("Nhập a");
            //int babiShark = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhập b");
            //int kratos = Convert.ToInt32(Console.ReadLine());
            //Từ khóa ref và out => Con trỏ
            //CalculateSum(babiShark, kratos); 
            //Pointer(babiShark, ref  kratos);
            //Console.WriteLine(kratos);
            //string name = GetNamePart2();
            //Console.WriteLine(name);
            //Console.WriteLine(CalculateSumP2(babiShark,kratos));
            Console.WriteLine("Nga nhập tuổi đi");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            if (NghiaVu(tuoi))
            {
                Console.WriteLine("Đủ tuổi lấy chồng");
            }
            else
            {
                Console.WriteLine("Cẩn thận bị bắt");
            }
            
        }
        #region Không trả về, không có tham số
        /// <summary>
        /// Get the name of me
        /// </summary>
        static void GetName()
        {
            Console.WriteLine("Nhập tên của bạn");
            string name = Console.ReadLine();
            Console.WriteLine(name);
        }
        #endregion
        #region Hàm không trả về, nhưng có tham số
        static void CalculateSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Pointer(int a, ref int b)
        {
            b = a + b;
        }
        #endregion
        #region Hàm có trả về không tham số
        static string GetNamePart2()
        {
            Console.WriteLine("Nhập tên của bạn");
            return Console.ReadLine();
        }
        #endregion
        #region Hàm có trả về và có tham số
        static int CalculateSumP2(int a, int b)
        {
            return a + b;
        }

        #endregion
        #region Hàm trả về bool
        static bool NghiaVu(int tuoi)
        {
            if (tuoi < 18)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
