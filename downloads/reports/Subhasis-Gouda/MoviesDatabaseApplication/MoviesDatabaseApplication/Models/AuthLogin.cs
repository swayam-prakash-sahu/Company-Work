using System.ComponentModel;

namespace MoviesDatabaseApplication.Models
{
    public class AuthLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool isloggedin { get; set; }
    }
}
