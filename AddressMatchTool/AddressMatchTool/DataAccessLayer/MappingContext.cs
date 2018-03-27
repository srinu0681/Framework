using AddressMatchTool.DataAccessLayer.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMatchTool.DataAccessLayer
{
    public class MappingContext : DbContext
    {
        public MappingContext() : base("MappingContext")
        {
        }

        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<AddressDTO> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
