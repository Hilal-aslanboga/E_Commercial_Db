using E_Commercial_Db.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.Entities.Concrete
{
   public class Employee:BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string  Adress { get; set; }
        public string  City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }

    }
}
