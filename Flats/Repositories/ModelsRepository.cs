using Flats.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Repositories
{
    class ModelsRepository
    {
        public List<Model> GetAll()
        {
            using (var ctx = new ModelsDataContext())
            {
                return ctx.Models.ToList();
            }
        }
        public void CleanData()
        {
            using (var ctx = new ModelsDataContext())
            {
                ctx.Models.RemoveRange(ctx.Models.ToList());
                ctx.SaveChanges();
            }
        }

        public void Add(Model obj)
        {
            using (var ctx = new ModelsDataContext())
            {
                ctx.Models.Add(obj);
                ctx.SaveChanges();
            }
        }

        public async Task<List<Model>> GetAllAsync()
        {
            using (var ctx = new ModelsDataContext())
            {
                return await ctx.Models.ToListAsync();
            }
        }
    }
}
