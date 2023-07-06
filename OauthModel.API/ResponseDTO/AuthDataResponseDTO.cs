namespace OauthModel.API.DTO
{
    public class AuthDataDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RefreshToken { get; set; }
        public string ExpirationDate { get; set; }
    }
}