namespace FamilyTreeApi.Models
{
    public class UserParents
    {
        public int Id { get; set; }
        public string PinMother { get; set; }
        public string PinFather { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
