namespace FamilyTreeApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string Fio { get; set; }
        public string Password { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public UserParents Parents { get; set; }
        public ICollection<UserChildren> Children { get; set; }
    }
}
