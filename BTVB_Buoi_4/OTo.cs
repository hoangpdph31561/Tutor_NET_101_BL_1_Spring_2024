namespace BTVB_Buoi_4
{
    internal class OTo : XeCo
    {
        public OTo()
        {

        }

        public OTo(string name, string ma, string namSanXuat) : base(name, ma, namSanXuat)
        {
        }

        public void Cong()
        {
            Console.WriteLine("a + b");
        }

        public void Cong(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Cong(int a, int b, int c)
        {
            return a + b + c;
        }

        public override void TiengBamCoi()
        {
            Console.WriteLine("abc");
        }
    }
}
