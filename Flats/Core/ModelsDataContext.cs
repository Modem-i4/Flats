using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Core
{

    public class ModelsDataContext : DbContext
    {
        public ModelsDataContext() : base("flatsConnectionString")
        {

        }
        public DbSet<Model> Models { get; set; }
    }
}
