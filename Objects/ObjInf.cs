using System;

namespace Supplier
{
    public class ObjInf
    {
        public int ID { get; set; }
        public string NamePost { get; set; }
        public int NumZak { get; set; }
        public string State { get; set; }
        public DateTime date { get; set; }
        public string Cex { get; set; }
        public float Price { get; set; }
        public float OplCen { get; set; }

        public ObjInf() { }
        
        public ObjInf(int id, string namepost, int numzak,
            string state, DateTime Date, string cex, float price, float oplcen)
        {
            ID = id;
            NamePost = namepost;
            NumZak = numzak;
            State = state;
            date = Date;
            Cex = cex;
            Price = price;
            OplCen = oplcen;
        }

        public string Str()
        {
            string ss = $"{NamePost} {NumZak} {State} {date} {Price} {OplCen} {Cex}";
            return ss;
        }
    }
}
