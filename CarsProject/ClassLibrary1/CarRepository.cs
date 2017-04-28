using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CarRepository
    {
        List<Cars> list = new List<Cars>
        {  new Cars() { Id=1, BrandType="Toyota", Model="Tacoma", Price=9000 },
            new Cars() { Id=1,BrandType="Toyota", Model="Camry", Price=3500 },
            new Cars() { Id=1, BrandType="Toyota", Model="Corola", Price=4000 },
            new Cars() { Id=2, BrandType="Honda", Model="Civic", Price=6000 },
            new Cars() { Id=2, BrandType="Honda", Model="Pilot", Price=12000 },
             new Cars() { Id=2, BrandType="Honda", Model="Acora", Price=10000 }
        };

        public List<string> GetAllCarBrand()
        {
            List<string> d = new List<string>();
            foreach (var item in list.GroupBy(Cars => Cars.BrandType).Select(group => group.First()))
            {
                d.Add(item.BrandType);
            }
            return d;
        }
        public Dictionary<string, decimal> GetAllModel(string BrandType)
        {
            Dictionary<string, decimal> d = new Dictionary<string, decimal>();
            foreach (var item in list.Where(x => x.BrandType == BrandType))
            {
                d.Add(item.Model, item.Price);
            }
            return d;
        }
        public decimal GetPriseByModel(string model)
        {
            return list.Where(x => x.Model == model).FirstOrDefault().Price;
        }
        public decimal GetTotal(string br,int qty)
        {
            return GetPriseByModel(br) * qty;
        }

        }
  }

