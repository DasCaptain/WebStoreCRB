using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Customer : ApplicationUser
    {
        public string FullName { get; set; }

    }
}
