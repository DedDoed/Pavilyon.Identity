using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pavilyon.Identity.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
