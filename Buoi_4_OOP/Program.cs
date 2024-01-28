using System.Text;

namespace Buoi_4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //// khai báo
            //Student std;
            //// khởi tạo
            //std = new Student();
            //Console.WriteLine("Xin mòi nhập MSV");
            //std.Msv = Console.ReadLine();
            //Console.WriteLine("Xin mòi nhập tên");
            //std.Ten = Console.ReadLine();
            //Console.WriteLine("Xin mòi nhập năm sinh");
            //std.Namsinh = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Thông tin sinh viên vừa nhập");
            //std.InThongTin();
            ////
            //Student std2 = new Student("PH23456", "Lê Văn B", 2005);
            //std2.InThongTin();
            Menu();

            //Tạo đối tượng class XeHoi
            //

        }
        static void Menu()
        {
            StudentService service = new StudentService();
            int chon;
            do
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Nhập đối tượng sinh viên");
                Console.WriteLine("2. Xuất ra thông tin đối tượng đó");
                Console.WriteLine("0. Thoát");
                Console.WriteLine();
                Console.WriteLine("Chọn chương trình");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Nhập đối tượng");
                        service.NhapDoiTuong();
                        break;
                    case 2:
                        Console.WriteLine("Xuất đối tượng");
                        service.XuatDoiTuong();
                        break;
                    default:
                        Console.WriteLine("Chọn vớ vẩn");
                        break;
                }
            } while (chon != 0);
        }
    }
}
