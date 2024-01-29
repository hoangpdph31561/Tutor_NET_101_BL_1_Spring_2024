namespace BTVB_Buoi_4
{
    internal class NguoiCaoTuoi
    {
        //ma– string, ten – string, tuoi–int– 
        //khai báo các thuộc tính cho lớp NguoiCaoTuoi
        private string ma;
        private string ten;
        private int tuoi;
        //Constructor không tham số
        public NguoiCaoTuoi()
        {

        }
        //Constructor có tham số
        public NguoiCaoTuoi(string ma, string ten, int tuoi)
        {
            this.ma = ma;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        //Phương thức InThongTin

        public virtual void InThongTin()
        {
            Console.WriteLine($"{ma}| {ten}| {tuoi}");
        }
    }
}
