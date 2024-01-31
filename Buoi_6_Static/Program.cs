namespace Buoi_6_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConNguoi human = new ConNguoi();
            human.Name = "Test";
            human.InThongTin();
            ThuVien.InThongTin();
            int namSinh = ThuVien.namSinh;
            Menu();
            Program pr = new Program();
            pr.Test();
        }
        static void Menu()
        {

        }
        void Test()
        {

        }
    }
}
