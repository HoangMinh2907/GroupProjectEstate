using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessObject
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public List<User> Users { get; set; }
    }
}
