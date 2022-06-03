using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Kitchen : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}