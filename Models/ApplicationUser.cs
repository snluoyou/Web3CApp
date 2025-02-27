using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Web3CApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        
        public async Task<ClaimsPrincipal> GenerateClaimsPrincipalAsync(UserManager<ApplicationUser> userManager)
        {
            var claims = new List<Claim>();
            claims.Add(ClaimTypes.Name, UserName);
            claims.Add(ClaimTypes.Email, Email);
            
            // 添加更多自定义声明...
            
            return await Task.FromResult(new ClaimsPrincipal(new ClaimsIdentity(claims)));
        }
    }
}