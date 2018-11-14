using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserDataT1708M1.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UserDataT1708M1User class
    public class UserDataT1708M1User : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
