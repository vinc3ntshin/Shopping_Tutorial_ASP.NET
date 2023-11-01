using Microsoft.AspNetCore.Identity;

namespace Shopping_Tutor.Models
{
    public class AppUserModel: IdentityUser
    {
        public string Occupation {  get; set; }
    }
}
