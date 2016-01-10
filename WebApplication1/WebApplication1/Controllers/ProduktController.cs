using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProduktController : ApiController
    {
        private List<Produkt> produkty = new List<Produkt>() 
        {
            new Produkt{Id = 1, Nazwa = "T-Shirt", Cena = 20, Rozmiar = "L" },
            new Produkt{Id = 2, Nazwa = "T-Shirt 2", Cena = 25, Rozmiar = "XL" },
            new Produkt{Id = 3, Nazwa = "T-Shirt 3", Cena = 30, Rozmiar = "XXL"}
        };
        public IEnumerable<Produkt> Get()
        {
            return produkty.ToList();
        }
        public IHttpActionResult Get(int id)
        {
            var produkt = produkty.Where(x => x.Id == id);
            if (produkt == null)
                return NotFound();
            return Ok(produkt);
        }
    }
}
