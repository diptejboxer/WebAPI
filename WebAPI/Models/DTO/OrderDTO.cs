using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace WebAPI.Models.DTO
{
    public class OrderDTO
    {
        public string OrderId { get; set; }
      
    }
    public class ClientDTO
    {
        public string ClientId { get; set; }

    }
}
