namespace BTVB_Buoi_4
{
    //B1 : kế thừa bằng ": <class cha>:
    internal class NguoiAlzheimer : NguoiCaoTuoi
    {
        //các thuộc tính riêng của đối tương
        private string tinhTrang;
        private string donThuoc;

        //ctor + tab : constructor ko tham số
        public NguoiAlzheimer()
        {

        }

        public NguoiAlzheimer(string ma, string ten, int tuoi, string tinhTrang, string donThuoc) : base(ma, ten, tuoi)
        {
            this.tinhTrang = tinhTrang;
            this.donThuoc = donThuoc;
        }

        //tạo constructor có tham số
        //sang class cha
        //lấy tham số của constructor cha paste vào


        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DonThuoc { get => donThuoc; set => donThuoc = value; }

        public override void InThongTin()
        {
            //lấy hàm in thông tin ở bên cha để sử dung
            base.InThongTin();
            //thêm thông tin của chính class này
            Console.WriteLine($"{tinhTrang} | {donThuoc}");
        }
    }
}
