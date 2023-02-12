using Server.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string PrivateName { get; set; }
        public string LastName { get; set; }
        public string UserIDNumber { get; set; }
        public ICollection<Child> Children { get; set; }
        public DateTime DOB { get; set; }
        public string HMO { get; set; }
        public string Gender { get; set; }
    }
}
