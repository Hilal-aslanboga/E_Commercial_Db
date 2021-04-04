using E_Commercial_Db.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Entities.Concrete
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
