using AddressMatchTool.DataAccessLayer.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMatchTool.DataAccessLayer
{
    public class DataProvider
    {
        private MappingContext context = new MappingContext();

        public DataProvider()
        {

        }

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return context.Customers;
        }

        public void SaveCustomer(CustomerDTO customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
