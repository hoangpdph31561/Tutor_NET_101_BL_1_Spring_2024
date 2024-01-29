namespace BTVB_Buoi_4
{
    internal abstract class XeCo
    {
        private string name;
        private string ma;
        private string namSanXuat;
        public XeCo()
        {

        }

        public XeCo(string name, string ma, string namSanXuat)
        {
            this.name = name;
            this.ma = ma;
            this.namSanXuat = namSanXuat;
        }

        public string Name { get => name; set => name = value; }
        public string Ma { get => ma; set => ma = value; }
        public string NamSanXuat { get => namSanXuat; set => namSanXuat = value; }

        public abstract void TiengBamCoi();
    }
}
