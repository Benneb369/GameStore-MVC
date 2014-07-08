using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameStore.Domain.Entities;

namespace GameStore.WebUI2.Models
{
    public class CartIndexView
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}