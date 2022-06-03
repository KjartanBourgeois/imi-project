using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class LoginResult
    {
        public bool Succeeded { get; set; }
        public ICollection<string> ErrorMessages { get; set; }
        public string JwtToken { get; set; }
    }
}
