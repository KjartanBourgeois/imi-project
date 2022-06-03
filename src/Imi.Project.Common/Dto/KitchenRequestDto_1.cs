using Imi.Project.Common.Dto.Base;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Common.Dto
{
    public class CategoryRequestDto : DtoBase
    {
        [Required]
        public string Name { get; set; }
    }
}