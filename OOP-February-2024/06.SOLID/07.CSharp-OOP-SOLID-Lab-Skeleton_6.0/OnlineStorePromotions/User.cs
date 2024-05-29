namespace OnlineStorePromotions
{
    public class User
    {
        public User(string v)
        {
            V = v;
        }

        public int Age { get; internal set; }
        public string V { get; }
    }
}