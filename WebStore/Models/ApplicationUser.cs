using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomerId { get; set; }
        public string ProviderId { get; set; }
        public string Discriminator { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
