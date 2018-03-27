using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMatchTool.DataAccessLayer.DataAccessObjects
{
    [Table("Address")]
    public class AddressDTO
    {
        public int ID { get; set; }
        public int AddressNumber { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String ZipCode { get; set; }

        public virtual ICollection<AddressDTO> Enrollments { get; set; }
    }
}
