using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP_Form
{

    [Serializable]
    public class Producer
    {
        public string Organization { set; get; }
        public string Country { set; get; }
        public string Address { set; get; }

        [RegularExpression(@"^\([1-9]\d{2}\)\s\d{3}-\d{4}$")]
        public string Phone { set; get; }
        public Producer() { }
        public Producer(string Organization, string Country, string Address, string Phone)
        {
            this.Organization = Organization;
            this.Country = Country;
            this.Address = Address;
            this.Phone = Phone;
        }
    }
}
