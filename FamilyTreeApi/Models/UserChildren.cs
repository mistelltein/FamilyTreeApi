namespace FamilyTreeApi.Models
{
    public class UserChildren
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string Fio { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
