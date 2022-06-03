using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos
{
    public class IngredientRequestDto : DtoBase
    {
        [Required]
        public string Name { get; set; }
    }
}
