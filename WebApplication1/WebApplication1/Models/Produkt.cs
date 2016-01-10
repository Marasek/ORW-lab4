using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public string Rozmiar { get; set; }
    }
}