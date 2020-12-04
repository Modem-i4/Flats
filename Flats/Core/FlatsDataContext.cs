using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Core
{

    public class FlatsDataContext : DbContext
    {
        public FlatsDataContext() : base("flatsConnectionString")
        {

        }
        public DbSet<Flat> Flats { get; set; }
    }
}
