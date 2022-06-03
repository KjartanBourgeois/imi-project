using Imi.Project.Common.Dto.Base;
using System;

namespace Imi.Project.Common.Dto
{
    public class UserResponseDto : DtoBase
    {
        public bool TermsAndConditions { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}