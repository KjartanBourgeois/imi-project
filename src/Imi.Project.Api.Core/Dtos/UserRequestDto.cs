using Imi.Project.Api.Core.Dtos.Base;
using Imi.Project.Api.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos
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
