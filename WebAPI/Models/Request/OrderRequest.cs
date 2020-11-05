using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Request
{
    public class OrderRequest
    {
        public string ClientName { get; set; }
        public string ClientContactNo { get; set; }
        public string ItemName{get;set;}
        public string ItemQty { get; set; }
    }
}
