namespace UserRegistration.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public AdressModel Adress { get; set; }

    }
}
