namespace RealEstate_Dapper_Api.Tools
{
    public class TokenResponseViewModel
    {
        public TokenResponseViewModel(string token, DateTime expiredate)
        {
            Token = token;
            ExpireDate = expiredate;
        }

        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
