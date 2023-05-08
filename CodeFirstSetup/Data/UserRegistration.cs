namespace CodeFirstSetup.Data
{
    public class UserRegistration
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Contries Contry { get; set; }
        public UserType Usertype { get; set; }
    }
}
