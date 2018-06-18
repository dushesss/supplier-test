namespace Supplier
{
    public class ObjZak
    {
        public int ID { get; set; }
        public string NameTov { get; set; }
        public int NumZak { get; set; }
        public int Kvo { get; set; }
        public string Ed { get; set; }
        public string Text { get; set; }

        public ObjZak() { }

        public ObjZak(int id, string nametov, int numzak, int kvo, string ed, string text)
        {
            ID = id;
            NameTov = nametov;
            NumZak = numzak;
            Kvo = kvo;
            Ed = ed;
            Text = text;
        }
    }
}
