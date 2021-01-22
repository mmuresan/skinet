namespace API.Dtos
{
    public class RegisterDto
    {
        public string DisplayName { get; set; }
        public string Email { get; init; }
        public string Password { get; set; }
    }
}