using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
    public class Child
    {
        public int ChildID { get; set; }
        public string ChildName { get; set; }
        public string ChildIDNumber { get; set; }
        public DateTime DOB { get; set; }
    }
}
