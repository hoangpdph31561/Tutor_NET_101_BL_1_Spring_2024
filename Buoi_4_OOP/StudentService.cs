using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_OOP
{
    internal class StudentService
    {
        List<Student> lstStudent;
        string input;
        public StudentService()
        {
            lstStudent = new();
        }
        public void NhapDoiTuong()
        {
            do
            {
                //Khởi tạo đối tượng student
                Student student = new Student();
                //Nhập thông tin cần thiết
                Console.WriteLine("Mã sinh viên");
                student.Msv = Console.ReadLine();
                Console.WriteLine("Tên");
                student.Ten = Console.ReadLine();
                Console.WriteLine("Năm sinh");
                student.Namsinh = Convert.ToInt32(Console.ReadLine());
                //Thêm student vào list
                lstStudent.Add(student);
                ///Kiểm tra xem muốn nhập tiếp hay không
                do
                {
                    Console.WriteLine("Muốn tiếp tục nhập hay không");
                    input = Console.ReadLine();
                    if (String.Compare(input, "có", true) != 0 && String.Compare(input, "không", true) != 0)
                    {
                        Console.WriteLine("Nhập lại đi");
                    }
                } while (String.Compare(input, "có", true) != 0 && String.Compare(input, "không", true) != 0);
            } while (String.Compare(input, "có", true) == 0);
        }
        private bool CheckLstIsNull()
        {
            if (lstStudent.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void XuatDoiTuong()
        {
            if (CheckLstIsNull())
            {
                Console.WriteLine("Không có đối tượng nào trong danh sách");
                return;
            }
            foreach (var item in lstStudent)
            {
                item.InThongTin();
            }

        }
    }
}
