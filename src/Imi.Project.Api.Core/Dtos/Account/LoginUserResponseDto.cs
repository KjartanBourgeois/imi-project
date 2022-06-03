using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.Account
{
    public class LoginUserResponseDto
    {
        public bool Succeeded { get; set; }
        public ICollection<string> ErrorMessages { get; set; }
        public string JwtToken { get; set; }
    }
}