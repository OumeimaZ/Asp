using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }
    }
}