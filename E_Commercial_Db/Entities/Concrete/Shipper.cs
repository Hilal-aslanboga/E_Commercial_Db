using E_Commercial_Db.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Entities.Concrete
{
   public class Shipper :BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
