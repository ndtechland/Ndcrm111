using Microsoft.EntityFrameworkCore;
using NdCRM.Models.entities;

namespace NdCRM.Models.DBContext
{
    public class CrmDBcontext : DbContext
    {       
        public CrmDBcontext(DbContextOptions<CrmDBcontext> options) : base(options)
        {
        }
        public DbSet<Product1> Product { get; set; }
    }
}
