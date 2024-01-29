namespace BTVB_Buoi_4
{
    internal class QLNguoiCT
    {
        List<NguoiCaoTuoi> lstNguoiCaoTuoi;
        string input;
        public QLNguoiCT()
        {
            lstNguoiCaoTuoi = new List<NguoiCaoTuoi>();
            NguoiCaoTuoi nct1 = new NguoiCaoTuoi("1", "Nguyễn Văn A", 70);
            NguoiCaoTuoi nct2 = new NguoiCaoTuoi("2", "Nguyễn Văn B", 80);
            NguoiCaoTuoi nct3 = new NguoiCaoTuoi("3", "Nguyễn Văn C", 90);
            lstNguoiCaoTuoi.Add(nct1);
            lstNguoiCaoTuoi.Add(nct2);
            lstNguoiCaoTuoi.Add(nct3);

        }
        public void Nhap()
        {
            do
            {
                NguoiCaoTuoi nguoiCaoTuoi = new NguoiCaoTuoi();
                Console.WriteLine("Xin mời nhập mã:");
                nguoiCaoTuoi.Ma = Console.ReadLine();
                Console.WriteLine("Xin mời nhập tên: ");
                nguoiCaoTuoi.Ten = Console.ReadLine();
                Console.WriteLine("Xin mời nhập tuổi: ");
                nguoiCaoTuoi.Tuoi = Convert.ToInt32(Console.ReadLine());
                lstNguoiCaoTuoi.Add(nguoiCaoTuoi);
                Console.WriteLine("Bạn có muốn nhập tiếp không? (Y/N)");
                input = Console.ReadLine();
            } while (input == "Y" || input == "y");
        }
        //Kiểm tra  listNguoiCaoTuoi có phần tử hay không
        private bool CheckCount()
        {
            if (lstNguoiCaoTuoi.Count == 0)
            {
                return true;
            }
            return false;
        }
        //In ra danh sách đối tượng
        public void Xuat()
        {
            if (CheckCount())
            {
                Console.WriteLine("Không có danh sách nào");
                return;
            }
            foreach (var item in lstNguoiCaoTuoi)
            {
                item.InThongTin();
            }
        }
        // xuất ra danh sách theo thuộc tính nào đó
        public void XuatDSNhoHon70()
        {
            if (CheckCount())
            {
                Console.WriteLine("Không có danh sách nào");
                return;
            }
            //tạo 1 biến flag để đánh dấu
            bool isExist = false;
            //với mỗi ngườ trong DS người cao tuổi
            foreach (var nguoi in lstNguoiCaoTuoi)
            {
                //nếu tuổi người < 70
                if (nguoi.Tuoi < 70)
                {
                    nguoi.InThongTin();
                    isExist = true;
                }
            }
            //nếu isExist = false thì không có người nào < 70
            if (!isExist)
            {
                Console.WriteLine("Không có người nào < 70 tuổi");
            }
        }
        //Tìm kiếm người theo mã
        //C1: dùng vòng lặp
        public void TimTheoMa()
        {
            //hàm checkcount
            // nhập mã cần tìm
            string input;
            Console.WriteLine("Xin mời nhập mã người cao tuôi");
            input = Console.ReadLine();
            //tạo biến flag để đánh dấu
            bool isExist = false;
            //với mỗi người trong danh sách người cao tuổi
            foreach (var x in lstNguoiCaoTuoi)
            {
                //tìm mã trung với người trong ds
                if (input == x.Ma)
                {
                    x.InThongTin();
                    isExist = true;
                }
            }
            if (!isExist) // is exist == false
            {
                Console.WriteLine("Không tìm thấy người có mã " + input);
            }
        }
        //C2: dùng linq
        public void TimTheoMaLinq()
        {
            //checkcount
            //nhập mã cần tìm
            Console.WriteLine("Xin mời nhập mã");
            string input = Console.ReadLine();
            //tạo 1 đối tượng mới để chứa kết quả tìm kiếm
            NguoiCaoTuoi nguoi;
            nguoi = lstNguoiCaoTuoi.FirstOrDefault(nguoi => nguoi.Ma == input);
            // trong DS nct : lstNguoiCaoTuoi
            // lấy người đầu tiên hoặc mặc định null :FirstOrDefault
            // với điều kiện tìm kiếm : nguoi => nguoi.Ma == input
            if (nguoi == null)
            {
                Console.WriteLine("không tìm thấy");
                return;
            }
            nguoi.InThongTin();
        }
        // Sửa thông tin người cao tuổi theo mã
        public void SuaTheoMa()
        {
            //checkcount
            // nhập mã mà cần sửa
            Console.WriteLine("Xin mời nhập mã");
            string input = Console.ReadLine();
            // 1 flag để check tồn tại
            bool IsExist = false;
            // sử dụng foreach để tìm mã trung
            foreach (var nguoi in lstNguoiCaoTuoi)
            {
                //nếu mÃ trùng với mã trong ds
                if (nguoi.Ma == input)
                {
                    nguoi.InThongTin();
                    Console.WriteLine("Xin mời nhập mã mới");
                    nguoi.Ma = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tên mới");
                    nguoi.Ten = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tuổi mới");
                    nguoi.Tuoi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sửa thành công");
                    // đặt flag = true
                    IsExist = true;
                    break;// tìm thấy và sửa rồi thì ko cần chạy tiếp nữa
                }
            }
            if (IsExist == false)
            {
                Console.WriteLine("Không tìm thấy người có mã" + input);
            }
        }
        // Xóa người cao tuổi theo mã
        //xóa hoạt động y hệt update, khác bên trong if của foreach
        public void XoaTheoMa()
        {
            //checkcount
            //tạo mới 1 đối tượng dùng để xóa
            NguoiCaoTuoi nguoiCanXoa = new NguoiCaoTuoi();
            // nhập mã mà cần sửa
            Console.WriteLine("Xin mời nhập mã cần xóa");
            string input = Console.ReadLine();
            // 1 flag để check tồn tại
            bool IsExist = false;
            // sử dụng foreach để tìm mã trung
            foreach (var nguoi in lstNguoiCaoTuoi)
            {
                //nếu mÃ trùng với mã trong ds
                if (nguoi.Ma == input)
                {
                    // gán thông tin người đang tìm = thông tin người cần xóa
                    nguoiCanXoa = nguoi;
                }
                IsExist = true;
                break;
            }
            if (IsExist == false)
            {
                Console.WriteLine("Không tìm thấy người có mã" + input);
                return;
            }
            //tiến hÀNH xóa người cần xóa
            lstNguoiCaoTuoi.Remove(nguoiCanXoa);
            Console.WriteLine("Xóa thành công");
        }

        //in thông tin kế thừa
        public void KeThua()
        {
            //B1: tạo danh sách người alzheimer
            List<NguoiAlzheimer> lstAlzheimers = new List<NguoiAlzheimer>() {
                new NguoiAlzheimer("1", "A", 70, "nặng", "Thuốc ngủ") ,
                new NguoiAlzheimer("2", "B", 80, "nhẹ", "Thuốc an thần") ,
                new NguoiAlzheimer("3", "C", 90, "nặng", "Bổ thận trung ương") ,
                new NguoiAlzheimer("4", "D", 60, "nặng", "trị xạ")
            };
            //B2: in
            foreach (var nguoi in lstAlzheimers)
            {
                nguoi.InThongTin();
            }

        }
    }
}
