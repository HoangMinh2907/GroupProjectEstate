using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessObject
{
    public class Comment
    {
        public int CommentID { get; set; }
        public DateTime CommentDate { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public int RealEstateID { get; set; }
         public RealEstate RealEstate { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }


    }
}
