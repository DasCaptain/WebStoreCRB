using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Provider Provider { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
