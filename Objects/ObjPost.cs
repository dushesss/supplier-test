namespace Supplier
{
    public class ObjPost
    {
        public int ID { get; set; }
        public string NamePost { get; set; }
        public string EmailPost { get; set; }
        public string TelPost { get; set; }

        public ObjPost(){}

        public ObjPost(int id, string namepost, string emailpost, string telpost) {
            ID = id;
            NamePost = namepost;
            EmailPost = emailpost;
            TelPost = telpost;
        }


    }
}
