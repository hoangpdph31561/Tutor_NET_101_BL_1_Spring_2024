using System.Text;

namespace BTVN_Buoi_3
{
    internal class Program
    {
        #region main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Tạo MENU thông qua hàm, và gọi lại trên Program
             * có switch case, và chọn lại chương trình. Ân 0 để thoát
             * 1. Nhập tên của bạn, năm sinh, In ra thông tin + tuổi
             * 2. Tính tiền nước: Có số khối
             *          0<= x <=15: 23000
             *          15 < x <=20: 25000
             *          20 <x  <= 30: 30000
             *          > 30: 50000
             *  3. Tính ngày trước và sau khi nhập ngày chỉ định
             *      Nhập ngày, tháng, năm.
             *      return ngày trước đó, và ngày sau đó.
             *  4. Nâng cao: Mảng zig zag
             *  Cho một mảng: nếu số ở giữa hoặc đều lớn hơn hoặc đều nhỏ hơn
             *  2 số cạnh nó thì là mảng zigzag
             *  Ví dụ: 2 5 3 6 4 8 
             *  Biểu diễn qua hàm và gọi lại vào switch case
             *      
             */

            //Gọi Menu
            Menu();
        }
        #endregion

        #region Tạo menu
        static void Menu()
        {
            //Tại một biến chọn để chọn chương trình
            int chon;
            //Vòng lặp để chọn chương trình
            do
            {
                Console.WriteLine("--------MENU--------");
                Console.WriteLine("1. Nhập tên, năm sinh in ra thông tin + tuổi");
                Console.WriteLine("2. Tính tiền nước");
                Console.WriteLine("3. Tình ngày trước sau");
                Console.WriteLine("4. Mảng zig zag");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("--------------------");
                Console.WriteLine("Nhập lựa chọn của bạn");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Console.WriteLine("Bạn đã chọn thoát chương trình");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Bạn đã chọn chương trình nhập thông tin");
                        //Gọi hàm nhập thông tin
                        InPutInfo();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn chương trình tính tiền nước");
                        //Gọi hàm tính tiền nước
                        TinhTienNuoc();
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn chương trình tính ngày trước sau");
                        //Gọi hàm tính ngày trước sau
                        InputDate();
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn chương trình mảng zig zag");
                        //Gọi hàm mảng zig zag
                        InputArray();
                        break;
                    default:
                        Console.WriteLine("Sai chương trình, mời chọn lại");
                        break;
                }
            } while (chon != 0);
        }
        #endregion

        #region Hàm nhập thông tin  
        /// <summary>
        /// Nhập tên, năm sinh, in ra thông tin đó và tuổi
        /// </summary>
        static void InPutInfo()
        {
            Console.WriteLine("Nhập tên của bạn");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh của bạn");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tên của bạn là {name}, năm sinh của bạn là {year}, tuổi của bạn là {DateTime.Now.Year - year}");
        }
        #endregion

        #region Tính tiền nước
        /// <summary>
        /// Nhập vào số khối nước và tính ra tiền. Lưu ý lũy kế.
        /// </summary>
        static void TinhTienNuoc()
        {
            double soKhoi, giaTien;
            do
            {
                Console.WriteLine("Nhập số khối nước");
                soKhoi = Convert.ToDouble(Console.ReadLine());
                if (soKhoi < 0)
                {
                    Console.WriteLine("Số khối nước không được nhỏ hơn 0");
                }
            } while (soKhoi < 0);
            if (soKhoi <= 15)
            {
                giaTien = soKhoi * 23000;
            }
            else if (soKhoi <= 20)
            {
                giaTien = (15 * 23000) + (soKhoi - 15) * 25000;
            }
            else if (soKhoi <= 30)
            {
                giaTien = (15 * 23000 + 5 * 20000) + (soKhoi - 20) * 30000;
            }
            else
            {
                giaTien = (15 * 23000 + 5 * 20000 + 10 * 30000) + (soKhoi - 30) * 50000;
            }
            Console.WriteLine($"Số tiền phải trả là: {giaTien} VNĐ");
        }
        #endregion

        #region Tính ngày trước sau
        /// <summary>
        /// Kiểm tra năm nhuận hay không
        /// </summary>
        /// <param name="year">năm</param>
        /// <returns></returns>
        static bool CheckLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Kiểm tra số ngày lớn nhất của tháng đó
        /// </summary>
        /// <param name="month">tháng</param>
        /// <param name="year">năm</param>
        /// <returns>Trả về số ngày trong tháng</returns>
        static int MaxDayOfMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (CheckLeapYear(year))
                    {
                        return 29;
                    }
                    return 28;
                default:
                    return -1;
            }
        }
        /// <summary>
        /// Tìm ngày trước đó
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        static void GetPreviousDay(int day, int month, int year)
        {
            int maxDayOfMonth = MaxDayOfMonth(month, year);
            if (day == 1)
            {
                if(month == 1)
                {
                       Console.WriteLine($"Ngày trước đó là {maxDayOfMonth}/{12}/{year - 1}");
                }
                else
                {
                    Console.WriteLine($"Ngày trước đó là {maxDayOfMonth}/{month - 1}/{year}");
                }
            }
            else
            {
                Console.WriteLine($"Ngày trước đó là {day - 1}/{month}/{year}");
            }
        }
        /// <summary>
        /// Tìm ngày sau đó
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        static void GetNextDay(int day, int month, int year)
        {
            int maxDayOfMonth = MaxDayOfMonth(month, year);
            if (day == maxDayOfMonth)
            {
                if (month == 12)
                {
                    Console.WriteLine($"Ngày sau đó là {1}/{1}/{year + 1}");
                }
                else
                {
                    Console.WriteLine($"Ngày sau đó là {1}/{month + 1}/{year}");
                }
            }
            else
            {
                Console.WriteLine($"Ngày sau đó là {day + 1}/{month}/{year}");
            }   
        }
        /// <summary>
        /// Thêm dữ liệu ngày tháng năm 
        /// </summary>
        static void InputDate()
        {
            int day, month, year;
            do
            {
                Console.WriteLine("Nhập ngày");
                day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tháng");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập năm");
                year = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > MaxDayOfMonth(month,year) || month < 1 || month > 12 || year <= 0)
                {
                    Console.WriteLine("Ngày tháng năm không hợp lệ");
                }
            } while (day < 1 || day > MaxDayOfMonth(month, year) || month < 1 || month > 12 || year <= 0);
            GetPreviousDay(day, month, year);
            GetNextDay(day, month, year);
        }

        #endregion

        #region Mảng zig zag
        /// <summary>
        /// Kiểm tra mảng zig zag
        /// </summary>
        /// <param name="arr">Mảng cần check</param>
        /// <returns>Nếu là mảng zig zag thì trả về true, không thì là false</returns>
        static bool CheckZigZag(int[] arr)
        {
            if(arr.Length < 3)
            {
                return false;
            }
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    continue;
                }
                if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        /// <summary>
        /// Nhập mảng và gọi hàm check zig zag
        /// </summary>
        static void InputArray()
        {
            int n;
            do
            {
                Console.WriteLine("Nhập số phần tử của mảng");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Số phần tử của mảng phải lớn hơn 0");
                }
            } while (n <= 0);
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (CheckZigZag(arr))
            {
                Console.WriteLine("Mảng zig zag");
            }
            else
            {
                Console.WriteLine("Mảng không zig zag");
            }
        }
        #endregion
    }
}
