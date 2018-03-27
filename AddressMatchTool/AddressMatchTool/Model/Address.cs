using AddressMatchTool.Common;
using System;

namespace AddressMatchTool.Model
{
    public class Address : BaseProperty
    {
        public Address()
        {

        }

        public bool IsValid()
        {
            return true;
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }

        private int _addressNumber;
        public int AddressNumber
        {
            get { return _addressNumber; }
            set
            {
                if (value != _addressNumber)
                {
                    _addressNumber = value;
                    NotifyPropertyChanged("AddressNumber");
                }
            }
        }

        private String _addressLine1;
        public String AddressLine1
        {
            get { return _addressLine1; }
            set
            {
                if (value != _addressLine1)
                {
                    _addressLine1 = value;
                    NotifyPropertyChanged("AddressLine1");
                }
            }
        }

        private String _addressLine2;
        public String AddressLine2
        {
            get { return _addressLine2; }
            set
            {
                if (value != _addressLine2)
                {
                    _addressLine2 = value;
                    NotifyPropertyChanged("AddressLine2");
                }
            }
        }

        private String _city;
        public String City
        {
            get { return _city; }
            set
            {
                if (value != _city)
                {
                    _city = value;
                    NotifyPropertyChanged("City");
                }
            }
        }

        private String _state;
        public String State
        {
            get { return _state; }
            set
            {
                if (value != _state)
                {
                    _state = value;
                    NotifyPropertyChanged("State");
                }
            }
        }


        private String _zipCode;
        public String ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (value != _zipCode)
                {
                    _zipCode = value;
                    NotifyPropertyChanged("ZipCode");
                }
            }
        }
    }
}
