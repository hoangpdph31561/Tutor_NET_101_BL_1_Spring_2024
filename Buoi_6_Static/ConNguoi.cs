namespace Buoi_6_Static
{
    internal class ConNguoi
    {
        private string name;
        public ConNguoi()
        {

        }

        public ConNguoi(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public void InThongTin()
        {
            Console.WriteLine(name);
        }
    }
}
