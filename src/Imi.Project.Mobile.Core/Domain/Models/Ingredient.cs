using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string Unit { get; set; }
        public Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }
    }
}
