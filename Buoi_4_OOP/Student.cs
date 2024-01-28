using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_OOP
{
    internal class Student
    {
        // MSV
        // họ ten
        // namsinh
        #region thuộc tính
        // khai báo các thuộc tính đã nêu
        private string msv;
        private string ten;
        private int namsinh;
        #endregion

        //B2: tạo constructor:
        /// <summary>
        /// hỗ trợ các bạn khơi tạo đối tượng
        /// </summary>
        // ctor + tab
        public Student()
        {

        }

        //b3:
        // bôi đen toàn bộ thuộc tính
        // ctrl . | chuột phải, chọn quick action and refactoring
        // chọn generate constructor
        //constructor có tham số
        public Student(string msv, string ten, int namsinh)
        {
            this.msv = msv;
            this.ten = ten;
            this.namsinh = namsinh;
        }

        //b4:
        // thuộc tính đang private
        // => không truy cập từ class khác được
        // 1 hàm trung gian public để lấy và gán giá trị

        //ctrl + ., chọn encapsoluted field (but still use field)
        public string Msv { get => msv; set => msv = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }

        // hàm riêng của đối tượng
        public void InThongTin()
        {
            Console.WriteLine($"{msv} | {ten} | {namsinh}");
        }

    }
}
