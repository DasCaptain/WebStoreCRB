using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebStore.Models;
using WebStore.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;


namespace WebStore.Services.Claims
{
    public class ApplicationUserClaimsPrincipleFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<ApplicationUser> _dbset;

        public ApplicationUserClaimsPrincipleFactory(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            
            var identity = await base.GenerateClaimsAsync(user);
            
            identity.AddClaim(new Claim("CustomerID", user.CustomerId));
            return identity;           
        }
    }
}
