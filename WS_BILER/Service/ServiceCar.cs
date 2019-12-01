using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS_BILER.Interface;
using WS_BILER.Models;

namespace WS_BILER.Service
{
    public class ServiceCar : ICar
    {
        private readonly BilerContext _context;

        public ServiceCar(BilerContext context)
        {
            _context = context;
        }


        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<SearchMenu> GetSearchMenu()
        {
            

            var url = "https://www.guloggratis.dk/biler/erhvervsbiler/volvo/xc60/?sort=price&order=asc";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("searchResultCategoriesShort"));

            ICollection<SearchMenu> sm = new List<SearchMenu>();

            try
            {
               
                    foreach (var node in nodes)
                    {
                     var menu = node.Descendants().Where(n => n.HasClass("font")).FirstOrDefault().InnerText;

                        
                        
                        sm.Add( new SearchMenu
                        {
                            Menu = menu
                            
                        });
                        
                    }
                
                

            }
            catch (Exception)
            {

                //throw;
            }
            return sm;
        }



        public void StartScrapping()
        {
            var url = "https://www.guloggratis.dk/biler/erhvervsbiler/volvo/xc60/?sort=price&order=asc";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("item"));

            try
            {
                using (var con = _context)
                {
                    foreach (var node in nodes)
                    {
                        var car = node.Descendants().Where(n => n.HasClass("black")).FirstOrDefault().InnerText;
                        var price = node.Descendants().Where(n => n.HasClass("col4")).FirstOrDefault().InnerText;

                        con.Add(new CarModel
                        {
                            Title = car.Substring(0,50),
                            Price = price
                        });
                        con.SaveChanges();
                    }
                }

            }
            catch (Exception)
            {

                //throw;
            }
            //return RedirectToAction(nameof(Index));
            
        }
    }
}
