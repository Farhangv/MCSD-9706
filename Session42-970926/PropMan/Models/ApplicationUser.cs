using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace PropMan.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }

        public ApplicationUser()
        {
            PhotoFilePath = "../person.jpg";
        }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Family { get; set; }
        [MaxLength(150)]
        public string PhotoFilePath { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}