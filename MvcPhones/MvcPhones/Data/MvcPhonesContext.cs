using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcPhones.Models
{
    public class MvcPhonesContext : DbContext
    {
        public MvcPhonesContext (DbContextOptions<MvcPhonesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPhones.Models.Phone> Phone { get; set; }
    }
}
