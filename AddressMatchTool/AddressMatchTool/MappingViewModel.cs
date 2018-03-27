using AddressMatchTool.DataAccessLayer;
using AddressMatchTool.Model;
using AddressMatchTool.Commands;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using AddressMatchTool.DataAccessLayer.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AddressMatchTool
{
    public class MappingViewModel : INotifyPropertyChanged
    {
        private DataProvider dataProvider = new DataProvider();

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                NotifyPropertyChanged("Customer");
            }
        }

        public DelegateCommand getCustomersCommand;
        public DelegateCommand customerSaveCommand;
        public DelegateCommand newCustomerCommand;

        public MappingViewModel()
        {
            Customer = new Customer();
            customerSaveCommand = new DelegateCommand(SaveCustomer, () => Customer.Address.IsValid());
            getCustomersCommand = new DelegateCommand(GetCustomers, () => true);
            newCustomerCommand = new DelegateCommand(CreateNewCustomer, () => true);
        }

        private void CreateNewCustomer()
        {
            Customer = new Customer();
        }

        private void SaveCustomer()
        {
            try
            {
                dataProvider.SaveCustomer(DataObjectMapper.ToCustomerDTO(Customer));
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Concat("Error in adding record.", Environment.NewLine, ex.Message));
                return;
            }

            MessageBox.Show("Added 1 record");
        }

        private void GetCustomers()
        {
            var customers = dataProvider.GetCustomers();
            var custDTO = customers.FirstOrDefault();
            if (custDTO != null)
            {
                Customer = DataObjectMapper.ToCustomer(custDTO);
            }
        }

        #region properties

        public ICommand saveCustomersBtnClick
        {
            get
            {
                return customerSaveCommand;
            }
        }

        public ICommand getCustomersBtnClick
        {
            get
            {
                return getCustomersCommand;
            }
        }

        public ICommand newCustomerBtnClick
        {
            get
            {
                return newCustomerCommand;
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
