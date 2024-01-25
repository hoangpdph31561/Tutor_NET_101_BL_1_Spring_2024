using System.Text;

namespace Buoi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Đọc và ghi tiếng Việt trong Console
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ///Kiểu dữ liêu số: int, double, float, decimal, byte, long, short, uint, ulong, ushort
            ///Chú ý: int là kiểu dữ liệu số nguyên, double và float là kiểu dữ liệu số thực
            ///Kiểu dữ liệu chuỗi: string, char
            ///Kiểu logic: bool
            ///<kiểu dữ liệu <tên biến>
            int soNguyen; //Khai báo biến kiểu số nguyên
            double soThuc; //Khai báo biến kiểu số thực
            string chuoi; //Khai báo biến kiểu chuỗi
            bool isStudent; //Khai báo biến kiểu logic

            ///Khai báo nhiều biến trên cùng 1 dòng
            //int soThuNhat, soThuHai, soThuBa;

            ///Gán giá trị cho biến
            soNguyen = 10;
            soThuc = 10.5;
            chuoi = "Hello World";
            isStudent = true;

            int soThuTu = 4; //Khai báo biến và gán giá trị cho biến

            ///Khai báo gán nhiều giá trị trên cùng dòng
            int soMot = 1, soHai = 2, soBa = 3;

            ///Kiểu dữ liệu var, dynamic. Đây là 2 kiểu dữ liệu đặc biệt
            var x = 10;
            var y = "Hello World";
            dynamic z = 'c';
            //x = "Hello World"; //Lỗi, x đã được khai báo là kiểu dữ liệu int
            z = 23.4; //Không lỗi, z là kiểu dữ liệu dynamic

            ///Kiểu dữ liệu const
            ///const <kiểu dữ liệu> <tên biến> = <giá trị>;
            const int KHONG = 0;
            //KHONG = 1; //Lỗi, không thể gán giá trị mới cho biến const
            //Comment nhanh: Ctrl + K + C
            //Bỏ comment nhanh: Ctrl + K + U

            //Console.WriteLine(soNguyen);
            /////Các cách gọi biến vào Console.WriteLine
            //Console.WriteLine("Đây là số nguyên "+ soNguyen);
            //Console.WriteLine($"Đây là cách viết khác của số nguyên: {soNguyen}");

            ///Nhập dữ liệu từ bàn phím
            ///
            //B1: Khai báo biến
            int soThuNhat;

            //B2: Thông báo cho người dùng biết cần nhập gì

            //Console.WriteLine("Mời bạn nhập số thứ nhất: ");
            ////B3: Nhập dữ liệu từ bàn phím
            ////soThuNhat = Console.ReadLine(); //Lỗi, vì Console.ReadLine() trả về kiểu dữ liệu string
            ////Parse
            //soThuNhat = int.Parse(Console.ReadLine()); //Chuyển đổi kiểu dữ liệu string sang kiểu dữ liệu int

            ////Convert
            //soThuNhat = Convert.ToInt32(Console.ReadLine()); //Chuyển đổi kiểu dữ liệu string sang kiểu dữ liệu int

            ////B4: Hiển thị kết quả
            //Console.WriteLine($"Số thứ nhất là: {soThuNhat}");

            ///Nhập và xuất ra màn hình thông tin của sinh viên FPoly
            ///Tên sinh viên - string, mã sinh viên - string, số điện thoại - string, email - string, Năm sinh-int, tuổi(Tính theo năm sinh) int. Điểm môn C# - double, điểm môn SQL - duoble, điểm môn HTMLCSS - duoble. Điểm trung bình double. 
            //Gợi ý: Datetime.Now.Year

            //B1: Khai báo biến
            string tenSinhVien, maSinhVien, soDienThoai, email;
            int namSinh, tuoi;
            double diemCSharp, diemSQL, diemHTMLCSS, diemTrungBinh;
            //float diemTrungBinh2 = Convert.ToSingle(Console.ReadLine());
            //B2: Thông báo cho người dùng biết cần nhập gì
            //Console.WriteLine("Mời bạn nhập tên sinh viên: ");
            //tenSinhVien = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            //maSinhVien = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập số điện thoại: ");
            //soDienThoai = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập email: ");
            //email = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập năm sinh: ");
            //namSinh = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mời bạn nhập điểm C#: ");
            //diemCSharp = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Mời bạn nhập điểm SQL: ");
            //diemSQL = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Mời bạn nhập điểm HTMLCSS: ");
            //diemHTMLCSS = Convert.ToDouble(Console.ReadLine());
            //tuoi = DateTime.Now.Year - namSinh;
            //diemTrungBinh = (diemCSharp + diemSQL + diemHTMLCSS) / 3;

            ////B3: Hiển thị kết quả
            //Console.WriteLine($"Tên sinh viên: {tenSinhVien}\n" +
            //    $"Mã sinh viên: {maSinhVien}\n" +
            //    $"Số điện thoại: {soDienThoai}\n" +
            //    $"Email: {email}\n" +
            //    $"Năm sinh: {namSinh}\n" +
            //    $"Tuổi: {DateTime.Now.Year - namSinh}\n" +
            //    $"Điểm C#: {diemCSharp}\n" +
            //    $"Điểm SQL: {diemSQL}\n" +
            //    $"Điểm HTML/CSS: {diemHTMLCSS}\n" +
            //    $"Điểm trung bình: {(diemCSharp + diemSQL + diemHTMLCSS) / 3}.");

            ///Các toán tử trong C#
            //TOán thử số học: +, -, *, /, %
            int a = 10, b = 3;
            Console.WriteLine($"{a} : {b} = {a * 1.0 / b} dư {a % 3}");
            //Toán tử tăng giảm: ++, --
            int c = 10;
            //c++; //c = c + 1; vẫn lấy giá trị cũ, nhưng c đã tăng lên 1 đơn vị
            //++c; //c = c + 1; lấy giá trị mới của c+1
            Console.WriteLine($"Giá trị của {c++} và {++c}");
            //Toán tử gán: =, +=, -=, *=, /=, %=
            int d = 10;
            d += 100; // d = d + 100;
            Console.WriteLine($"Số d là: " + d);
            //Toán tử so sánh: >, <, >=, <=, ==, !=
            //Toán tử logic: &&, ||, !
            // &&: ANd, DK 1 && DK 2
            //DK 1 = true, DK 2 = true => true
            //DK 1 = true, DK 2 = false => false
            //|| : OR
            //DK1 = true, DK2 = true => true
            //DK1 = true, DK2 = false => true
            //DK1 = false, DK2 = false => false
            //!: NOT
            // DK = true => false


            //giải phương trình bâc 1: ax + b = 0
            //Giải pt bậc 2: ax^2 + bx + c = 0
        }
    }
    
}
