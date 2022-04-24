namespace ApiApplikation.Models.Entities.User
{
    public class UserEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public int PhoneNumber { get; set; }


    }
}
