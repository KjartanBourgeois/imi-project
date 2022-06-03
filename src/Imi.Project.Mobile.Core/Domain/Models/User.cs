using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        // For later use

        //public bool TermsAndConditions { get; set; }
        //public DateTime DoB { get; set; }
        //public string Password { get; set; }
        //public string ProfilePicture { get; set; }
    }
}
