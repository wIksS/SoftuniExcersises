namespace _01.Loader.Models
{
    public class User : BaseEntity
    {
        public User(int id, int? parentId) 
            : base(id, parentId)
        {
        }
    }
}
