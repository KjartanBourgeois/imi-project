using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? Liked { get; set; }
        public int? Rating { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }
        public Uri WebsiteLink { get; set; }
        public int NumberOfPersons { get; set; }
    }
}
