using Imi.Project.Api.Core.Dtos.Base;
using System;

namespace Imi.Project.Api.Core.Dtos
{
    public class UserResponseDto : DtoBase
    {
        public bool TermsAndConditions { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

    }
}
