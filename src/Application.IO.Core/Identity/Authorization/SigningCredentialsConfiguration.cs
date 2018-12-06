using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Application.IO.Core.Identity.Authorization
{
    public class SigningCredentialsConfiguration
    {
        private const string SecretKey = "3A3EFD11-5A19-4FF0-A71E-2E893806F52A";
        public static readonly SymmetricSecurityKey Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
        public SigningCredentials SigningCredentials { get; }

        public SigningCredentialsConfiguration()
        {
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
        }
    }
}
