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
    class FlatsRepository
    {
        public List<Flat> GetAll()
        {
            using (var ctx = new FlatsDataContext())
            {
                return ctx.Flats.ToList();
            }
        }
        public DataTable GetDataFrame()
        {
            DbSet<Flat> data;
            using (var ctx = new FlatsDataContext())
            {
                data = ctx.Flats;
                PropertyDescriptorCollection properties =
                    TypeDescriptor.GetProperties(typeof(Flat));
                DataTable table = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach (var item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
                return table;
            }
        }
        public void CleanData()
        {
            using (var ctx = new FlatsDataContext())
            {
                ctx.Flats.RemoveRange(ctx.Flats.ToList());
                ctx.SaveChanges();
            }
        }

        public void Add(Flat obj)
        {
            using (var ctx = new FlatsDataContext())
            {
                ctx.Flats.Add(obj);
                ctx.SaveChanges();
            }
        }

        public async Task<List<Flat>> GetAllAsync()
        {
            using (var ctx = new FlatsDataContext())
            {
                return await ctx.Flats.ToListAsync();
            }
        }

    }
}
