using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessObject
{
    public class Bid
    {
        public int BidID { get; set; }
        public double BidAmount { get; set; }
        public List<Auction> Auctions { get; set; }

    }
}
