using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessObject
{
    public class User
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }

        public int BidID { get; set; }
        public Bid Bid { get; set; }

        public List<Comment> Comments { get; set; } 
    }
}
