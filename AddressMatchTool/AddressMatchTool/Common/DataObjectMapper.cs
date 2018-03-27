using AddressMatchTool.DataAccessLayer.DataAccessObjects;
using AddressMatchTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMatchTool.DataAccessLayer.Common
{
    public static class DataObjectMapper
    {
        public static CustomerDTO ToCustomerDTO(Customer customer)
        {
            CustomerDTO custDTO = new CustomerDTO();
            custDTO.ID = customer.ID;
            custDTO.Name = customer.Name;

            custDTO.Address = ToAddressDTO(customer.Address);

            return custDTO;
        }

        public static AddressDTO ToAddressDTO(Address address)
        {
            AddressDTO addressDTO = new AddressDTO();
            addressDTO.ID = address.ID;
            addressDTO.AddressLine1 = address.AddressLine1;
            addressDTO.AddressLine2 = address.AddressLine2;
            addressDTO.City = address.City;
            addressDTO.State = address.State;
            addressDTO.ZipCode = address.ZipCode;

            return addressDTO;
        }

        public static Customer ToCustomer(CustomerDTO customerDTO)
        {
            Customer customer = new Customer();
            customer.ID = customerDTO.ID;
            customer.Name = customerDTO.Name;

            customer.Address = ToAddress(customerDTO.Address);

            return customer;
        }

        public static Address ToAddress(AddressDTO addressDTO)
        {
            Address address = new Address();
            address.ID = addressDTO.ID;
            address.AddressLine1 = addressDTO.AddressLine1;
            address.AddressLine2 = addressDTO.AddressLine2;
            address.City = addressDTO.City;
            address.State = addressDTO.State;
            address.ZipCode = addressDTO.ZipCode;

            return address;
        }
    }
}
