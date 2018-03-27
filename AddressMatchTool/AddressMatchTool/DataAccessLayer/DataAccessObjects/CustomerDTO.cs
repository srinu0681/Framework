using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMatchTool.DataAccessLayer.DataAccessObjects
{
    [Table("Customer")]
    public class CustomerDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual AddressDTO Address { get; set; }
    }
}
