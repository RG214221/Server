using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
    public class User
    {
        public int UserId { get; set; }  
        public string PrivateName { get; set; }
        public string LastName { get; set; }
        public string UserIDNumber { get; set; }

        //To cancel lazy loading
        public virtual ICollection<Child> Children { get; set; }
        public DateTime DOB { get; set; }
        public string HMO { get; set; }
        public string Gender { get; set; }
    }
}
