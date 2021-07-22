namespace _02.Data.Models
{
    public class User : BaseEntity
    {
        public User(int id, int? parentId)
            : base(id, parentId)
        {
        }
    }
}
