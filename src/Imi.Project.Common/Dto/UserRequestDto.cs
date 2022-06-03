using Imi.Project.Common.Dto.Base;
using Imi.Project.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Common.Dto
{
    public class UserRequestDto : DtoBase
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Gender Gender { get; set; }
    }
}